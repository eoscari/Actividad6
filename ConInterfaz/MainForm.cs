/*
 * Created by SharpDevelop.
 * User: oscar
 * Date: 19/9/2016
 * Time: 14:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace ConInterfaz
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		static StreamWriter escritura;
		frmAltas altas;
		frmBajas bajas;
		frmModifica modifica;
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
				
		void altas_FormClosed(object sender, EventArgs e){
			altas = null;
		}
		
		
		void bajas_FormClosed(object sender, EventArgs e){
			bajas = null;
		}
		
		public void crearArchivo(){
			try{
				escritura = File.AppendText("articulos.txt");
			}catch(Exception er){
				MessageBox.Show("Error " + er.Message," WARNING");
			}
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			crearArchivo();
		}
		void BajasToolStripMenuItem1Click(object sender, EventArgs e)
		{
			if(bajas == null){
				bajas =new frmBajas();
				bajas.MdiParent = this;
				bajas.FormClosed+= new FormClosedEventHandler(bajas_FormClosed);
				bajas.Show();
			}else{
				bajas.Activate();
			}
		}
		void ToolStripMenuItem1Click(object sender, EventArgs e)
		{
			if(altas == null){
				altas =new frmAltas();
				altas.MdiParent = this;
				altas.FormClosed+= new FormClosedEventHandler(altas_FormClosed);
				altas.Show();
			}else{
				altas.Activate();
			}
		}
		void ToolStripAltasClick(object sender, EventArgs e)
		{
			if(altas == null){
				altas =new frmAltas();
				altas.MdiParent = this;
				altas.FormClosed+= new FormClosedEventHandler(altas_FormClosed);
				altas.Show();
			}else{
				altas.Activate();
			}
		}
		void ToolStripBajasClick(object sender, EventArgs e)
		{
			if(bajas == null){
				bajas =new frmBajas();
				bajas.MdiParent = this;
				bajas.FormClosed+= new FormClosedEventHandler(bajas_FormClosed);
				bajas.Show();
			}else{
				bajas.Activate();
			}
		}
		void ModificaionesToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(modifica == null){
				modifica =new frmModifica();
				modifica.MdiParent = this;
				modifica.FormClosed+= new FormClosedEventHandler(modifica_FormClosed);
				modifica.Show();
			}else{
				altas.Activate();
			}
		}
		
		void modifica_FormClosed(object sender, EventArgs e){
			modifica = null;
		}
		void ToolStripModificacionesClick(object sender, EventArgs e)
		{
			if(modifica == null){
				modifica =new frmModifica();
				modifica.MdiParent = this;
				modifica.FormClosed+= new FormClosedEventHandler(modifica_FormClosed);
				modifica.Show();
			}else{
				altas.Activate();
			}
		}
	}
}
