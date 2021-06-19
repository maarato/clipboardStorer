/*
 * Created by SharpDevelop.
 * User: manuelra
 * Date: 11/3/2016
 * Time: 11:58 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace ClipBoardStorer
{
	
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		ArrayList Nombres = new ArrayList();
		ArrayList Datos = new ArrayList();
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public int checkExist(string nombre){
			int tam=Nombres.Count;
			for (int i=0;i<tam;i++){
				if(Nombres[i].ToString()==nombre){
					return i;
				}
			}
			return -1;
		}
		void Button1Click(object sender, EventArgs e)
		{
			//Aqui va el de agregar
			string nombre=textBox1.Text.ToString();
			if (AgregarElemento(nombre,Datos,Nombres))
			{ArrayListToListBox(Nombres,listBox1);}
		}
		
		void ListBox1MouseDown(object sender, MouseEventArgs e)
		{
			int indice=listBox1.SelectedIndex;
			if (indice>-1){
				if(Datos[indice].GetType() == typeof(System.Drawing.Bitmap)){
					Clipboard.SetImage((System.Drawing.Image)Datos[indice]);
				}else if(Datos[indice].GetType() == typeof(System.Collections.Specialized.StringCollection)){
					Clipboard.SetFileDropList((System.Collections.Specialized.StringCollection)Datos[indice]);
				}else{ //Es texto u otra cosa
					Clipboard.SetDataObject(Datos[indice].ToString());
				}
			}
		}
		
		void DeleteToolStripMenuItemClick(object sender, EventArgs e)
		{
			int indice=listBox1.SelectedIndex;
			if (indice>-1){
				if(MessageBox.Show("Seguro que deseas borrarlo?","Borrar elemento",MessageBoxButtons.YesNo) == DialogResult.Yes)
					{
						Datos.RemoveAt(indice);
						Nombres.RemoveAt(indice);
						ArrayListToListBox(Nombres,listBox1);
					}
			}
		}
		void ArrayListToListBox(ArrayList array,ListBox list){
			int tam=array.Count;
			list.Items.Clear();
			for(int i=0;i<tam;i++){
				list.Items.Add(array[i].ToString());
			}
		}
		
		void TextBox1KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
			  {
				string nombre=textBox1.Text.ToString();
				if (AgregarElemento(nombre,Datos,Nombres))
				{ArrayListToListBox(Nombres,listBox1);}
			  }
		}
		
		int searchElement(ArrayList Lista,string nombre){
			int tam=Lista.Count;
		for (int i=0;i<tam;i++){
				if((Lista[i].ToString()).Contains(nombre)){
				return i;
			}
		}
		return -1;
}
		
		
		bool AgregarElemento(string nombre,ArrayList dato,ArrayList names){
			 //nombre=textBox1.Text.ToString();
			if (nombre!=""){
				int indice=checkExist(nombre);
				string texto;
				System.Drawing.Image imagenClipboard=null;
				System.Collections.Specialized.StringCollection returnList = null;
				
				if(Clipboard.ContainsImage()){ //Verificar si tiene imagen el clipboard
					imagenClipboard = Clipboard.GetImage();
				}else if(Clipboard.ContainsText()){ //Sino tiene un texto u otro tipo de info
					texto=Clipboard.GetText(TextDataFormat.Html);
				}else if(Clipboard.ContainsFileDropList()){
					returnList = Clipboard.GetFileDropList();
				}
				IDataObject iData = Clipboard.GetDataObject();
				
				if(iData.GetDataPresent(DataFormats.Text)) {
	       			if (indice>-1){
						dato[indice]=(String)iData.GetData(DataFormats.Text);
					}else{
						dato.Add((String)iData.GetData(DataFormats.Text));
						names.Add(nombre);
						return true;
					}
				}else if(Clipboard.ContainsImage()){ //es una imagen lo que hay que guardar
					if (indice>-1){
						dato[indice]=imagenClipboard;
					}else{
						dato.Add(imagenClipboard);
						names.Add(nombre);
						return true;
					}
				}else if(Clipboard.ContainsFileDropList()){
					if (indice>-1){
						dato[indice]=returnList;
					}else{
						dato.Add(returnList);
						names.Add(nombre);
						return true;
					}
				}
			}return false;
		}
		
		void GenerarToolStripMenuItemClick(object sender, EventArgs e)
		{
			int tam=Nombres.Count;
			if (tam>-1){
				string generado="";
				for(int i=0;i<tam;i++){
					generado=generado+Nombres[i].ToString()+" : "+Datos[i].ToString()+"\n";
				}	
				Clipboard.SetDataObject(generado);
			}
		}
		
		String generarClipboardGeneral(){
			string toRet = "";
			//1. Leer uno a uno los nombres
			//2. ponerlo en un string
			//3. leer el dato del indice actual del nombre
			//4. hacerle split por el /n
			//5. agregarle a cada linea un tabulador a la izquierda
			//6. poner la linea con el tabulador en el string
			//7. repetir desde 1 hasta terminar con el arraylist
			for( int indice = 0; indice<Nombres.Count; indice++ ){
				toRet = toRet + Nombres[indice] + "\n";
				string dato = (string)Datos[indice];
				string[] lineas = dato.Split('\n');
				for( int subLn = 0 ; subLn < lineas.Length ; subLn++ ){
					toRet = toRet + "\t" + lineas[subLn] + "\n";
				}
			}
			return toRet;
		}

		
		void OnTopToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.TopMost=!this.TopMost;			
		}
	}
}
