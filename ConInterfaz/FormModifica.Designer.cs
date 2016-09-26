/*
 * Creado por SharpDevelop.
 * Usuario: oscar
 * Fecha: 26/9/2016
 * Hora: 00:10
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ConInterfaz
{
	partial class frmModifica
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label nombre;
		private System.Windows.Forms.Label apellido;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label dni;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtApellido;
		private System.Windows.Forms.TextBox txtDomicilio;
		private System.Windows.Forms.TextBox txtPrestamo;
		private System.Windows.Forms.TextBox txtDni;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnSalir;
		
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
			this.nombre = new System.Windows.Forms.Label();
			this.apellido = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dni = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtApellido = new System.Windows.Forms.TextBox();
			this.txtDomicilio = new System.Windows.Forms.TextBox();
			this.txtPrestamo = new System.Windows.Forms.TextBox();
			this.txtDni = new System.Windows.Forms.TextBox();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// nombre
			// 
			this.nombre.Location = new System.Drawing.Point(13, 13);
			this.nombre.Name = "nombre";
			this.nombre.Size = new System.Drawing.Size(100, 23);
			this.nombre.TabIndex = 0;
			this.nombre.Text = "Nombre: ";
			// 
			// apellido
			// 
			this.apellido.Location = new System.Drawing.Point(13, 45);
			this.apellido.Name = "apellido";
			this.apellido.Size = new System.Drawing.Size(100, 23);
			this.apellido.TabIndex = 0;
			this.apellido.Text = "Apellido: ";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 81);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Domicilio: ";
			// 
			// dni
			// 
			this.dni.Location = new System.Drawing.Point(13, 113);
			this.dni.Name = "dni";
			this.dni.Size = new System.Drawing.Size(100, 23);
			this.dni.TabIndex = 0;
			this.dni.Text = "DNI: ";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 145);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "Préstamo: ";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(64, 13);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(119, 20);
			this.txtNombre.TabIndex = 0;
			// 
			// txtApellido
			// 
			this.txtApellido.Location = new System.Drawing.Point(64, 42);
			this.txtApellido.Name = "txtApellido";
			this.txtApellido.Size = new System.Drawing.Size(119, 20);
			this.txtApellido.TabIndex = 1;
			// 
			// txtDomicilio
			// 
			this.txtDomicilio.Location = new System.Drawing.Point(64, 78);
			this.txtDomicilio.Name = "txtDomicilio";
			this.txtDomicilio.Size = new System.Drawing.Size(119, 20);
			this.txtDomicilio.TabIndex = 2;
			// 
			// txtPrestamo
			// 
			this.txtPrestamo.Location = new System.Drawing.Point(64, 142);
			this.txtPrestamo.Name = "txtPrestamo";
			this.txtPrestamo.Size = new System.Drawing.Size(119, 20);
			this.txtPrestamo.TabIndex = 4;
			this.txtPrestamo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtPrestamoKeyUp);
			// 
			// txtDni
			// 
			this.txtDni.Location = new System.Drawing.Point(64, 110);
			this.txtDni.Name = "txtDni";
			this.txtDni.Size = new System.Drawing.Size(119, 20);
			this.txtDni.TabIndex = 3;
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(13, 186);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(80, 40);
			this.btnGuardar.TabIndex = 5;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Location = new System.Drawing.Point(105, 186);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(78, 40);
			this.btnLimpiar.TabIndex = 6;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiarClick);
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(197, 186);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(75, 40);
			this.btnSalir.TabIndex = 7;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			// 
			// frmModifica
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.txtDni);
			this.Controls.Add(this.txtPrestamo);
			this.Controls.Add(this.txtDomicilio);
			this.Controls.Add(this.txtApellido);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dni);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.apellido);
			this.Controls.Add(this.nombre);
			this.Name = "frmModifica";
			this.Text = "Modificar datos";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
