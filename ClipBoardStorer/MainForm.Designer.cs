/*
 * Created by SharpDevelop.
 * User: manuelra
 * Date: 11/3/2016
 * Time: 11:58 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
 using System.Windows.Forms;
 using System;
 using System.IO;
 using System.Collections;
namespace ClipBoardStorer
{
	partial class MainForm
	{
		public bool viendoContenido = false;
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.lToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.generarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.verContenidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.onTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(8, 60);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(266, 342);
			this.listBox1.TabIndex = 0;
			this.listBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListBox1MouseDown);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(8, 34);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(213, 20);
			this.textBox1.TabIndex = 1;
			this.textBox1.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1KeyPress);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(228, 34);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(44, 21);
			this.button1.TabIndex = 2;
			this.button1.Text = "Add";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.fileToolStripMenuItem1,
									this.fileToolStripMenuItem,
									this.onTopToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(280, 24);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem1
			// 
			this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.lToolStripMenuItem,
									this.saveToolStripMenuItem});
			this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
			this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem1.Text = "File";
			// 
			// lToolStripMenuItem
			// 
			this.lToolStripMenuItem.Name = "lToolStripMenuItem";
			this.lToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
			this.lToolStripMenuItem.Text = "Load";
			this.lToolStripMenuItem.Click += new System.EventHandler(this.LToolStripMenuItemClick);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItemClick);
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.deleteToolStripMenuItem,
									this.generarToolStripMenuItem,
									this.verContenidoToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.fileToolStripMenuItem.Text = "Edit";
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
			this.deleteToolStripMenuItem.Text = "Delete";
			this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItemClick);
			// 
			// generarToolStripMenuItem
			// 
			this.generarToolStripMenuItem.Name = "generarToolStripMenuItem";
			this.generarToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
			this.generarToolStripMenuItem.Text = "Generar";
			this.generarToolStripMenuItem.Click += new System.EventHandler(this.GenerarToolStripMenuItemClick);
			// 
			// verContenidoToolStripMenuItem
			// 
			this.verContenidoToolStripMenuItem.Name = "verContenidoToolStripMenuItem";
			this.verContenidoToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
			this.verContenidoToolStripMenuItem.Text = "Ver Contenido";
			this.verContenidoToolStripMenuItem.Click += new System.EventHandler(this.VerContenidoToolStripMenuItemClick);
			// 
			// onTopToolStripMenuItem
			// 
			this.onTopToolStripMenuItem.Name = "onTopToolStripMenuItem";
			this.onTopToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
			this.onTopToolStripMenuItem.Text = "On Top";
			this.onTopToolStripMenuItem.Click += new System.EventHandler(this.OnTopToolStripMenuItemClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(280, 414);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "ClipBoardStorer";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem onTopToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem verContenidoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem lToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem generarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ListBox listBox1;
		
		void TextBox1TextChanged(object sender, System.EventArgs e)
		{
		
		}
		
		void LToolStripMenuItemClick(object sender, System.EventArgs e)
		{
			Datos = new ArrayList();
			Nombres = new ArrayList();
			OpenFileDialog openFileDialog1 = new OpenFileDialog();
			int size = -1;
			openFileDialog1.Filter = "Clp File|*.clp";
			openFileDialog1.Title = "Open a CLP File";
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            string text="";
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    text = File.ReadAllText(file);
                    size = text.Length;
                    string[] lineas = text.Split('\n');
                    if (lineas.Length>0){
                    	string nombreInside = "";
                    	string contenido = "";
                    	//bool toAdd = false;
                    	for(int i = 0; i<lineas.Length; i++){
                    		if(lineas[i].Length>0){
                    			if(lineas[i][0] != '\t' && nombreInside == "" ){
                    				//asignar nombre de elemento
                    				nombreInside = lineas[i];
                    			}else if(lineas[i][0] != '\t' && nombreInside != ""){
                    				//agregar al listbox y despues asignar nombre de elemento nuevo
                    				//listBox1.
                    				Nombres.Add(nombreInside);
                    				Datos.Add(contenido);
                    				//AgregarElemento(nombreInside,Datos,Nombres)
                    				nombreInside = lineas[i];
                    				contenido = "";
                    			}else{
                    				//agregar al contenido del elemento la linea esta pero si a partir de linea[i][1]
                    				contenido = contenido + lineas[i].Substring(1);
                    			}
                    		}
                    		/*string nombre=textBox1.Text.ToString();
							if (AgregarElemento(nombre,Datos,Nombres))
							{*/
								
                    	}
                    	Nombres.Add(nombreInside);
                    	Datos.Add(contenido);
                    	ArrayListToListBox(Nombres,listBox1);
                    }
                }
                catch (IOException)
                {
                }
            }
            
		}
		
		void VerContenidoToolStripMenuItemClick(object sender, EventArgs e)
		{
			/*if(!this.viendoContenido){
				this.Size = new System.Drawing.Size(400, 600);	
				this.viendoContenido=true;
			}else{
				this.viendoContenido=false;
				this.Size = new System.Drawing.Size(392, 557);			
			}*/
		}
		
		void SaveToolStripMenuItemClick(object sender, EventArgs e)
		{
			   SaveFileDialog saveFileDialog1 = new SaveFileDialog();
			   saveFileDialog1.Filter = "Clp File|*.clp";
			   saveFileDialog1.Title = "Save a CLP File";
			   saveFileDialog1.ShowDialog();
			
			   // If the file name is not an empty string open it for saving.
			   if(saveFileDialog1.FileName != "")
			   {
			       System.IO.File.WriteAllText(@saveFileDialog1.FileName, generarClipboardGeneral());
			   }
		}
	}
}
