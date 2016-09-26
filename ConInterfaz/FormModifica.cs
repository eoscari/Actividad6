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
		
		//Creación de métodos
		public void limpiarDatos(){
			txtNombre.Clear();
			txtApellido.Clear();
			txtDni.Clear();
			txtDomicilio.Clear();
			txtPrestamo.Clear();
			txtNombre.Focus();
		}
		
		public bool validar_anio(TextBox anio){
			try{
				int an = Convert.ToInt32(anio.Text);
				return true;
			}catch(Exception er){
				anio.Text = "0";
				anio.Select(0,anio.Text.Length);
				return false;
			}
		}
		
		public bool validar_prestamo(TextBox prestamo){
			try{
				double pre = Convert.ToDouble(prestamo.Text);
				return true;
			}catch(Exception er){
				prestamo.Text = "0.0";
				prestamo.Select(0,prestamo.Text.Length);
				return false;
			}
		}
		void TxtPrestamoKeyUp(object sender, KeyEventArgs e)
		{
			validar_prestamo((TextBox) sender);
		}
		void BtnLimpiarClick(object sender, EventArgs e)
		{
			limpiarDatos();
		}
		void BtnGuardarClick(object sender, EventArgs e)
		{
			encontrado = false;
			try{
				if(txtApellido.Text != "" && txtDomicilio.Text!="" && txtDni.Text!="" && txtNombre.Text!="" && txtPrestamo!=""){
					lectura = File.OpenText("articulos.txt");
					txtNombre.Text = txtNombre.Text.ToUpper();
					cadena = lectura.ReadLine();
					while(cadena!=null){
						campos = cadena.Split('-');
						if(campos[0].Trim().Equals(txtNombre.Text)){
							encontrado = true;
							break;
						}
						cadena = lectura.ReadLine();
					}
					lectura.Close();
					escritura = File.AppendText("articulos.txt");
					if(encontrado == false){
						txtApellido.Text = txtApellido.Text.ToUpper();
						txtDni.Text = txtDni.Text.ToUpper();
						txtDomicilio.Text = txtDomicilio.Text.ToUpper();
						txtPrestamo.Text = txtPrestamo.Text.ToUpper();
						escritura.WriteLine(txtNombre.Text+"- "+txtApellido.Text+"- "+txtDni+"- "+txtDomicilio+"- "+txtPrestamo);
					}
				}
			}catch(Exception er){
				MessageBox.Show("Error "+er.Message,"WARNING");
			}
		}
		
	}
}
