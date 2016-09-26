/*
 * Creado por SharpDevelop.
 * Usuario: oscar
 * Fecha: 26/9/2016
 * Hora: 00:10
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace ConInterfaz
{
	/// <summary>
	/// Description of FormModifica.
	/// </summary>
	public partial class frmModifica : Form
	{
		static StreamReader lectura;
		static StreamWriter escritura;
		static bool encontrado;
		static string cadena;
		static string[] campos = new string[5];
		public frmModifica()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void FrmModificaLoad(object sender, EventArgs e)
		{
	
		}
		//Creación de métodos
//		public void limpiarDatos(){
//			
//		}
	}
}
