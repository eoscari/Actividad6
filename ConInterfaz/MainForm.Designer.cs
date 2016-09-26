/*
 * Created by SharpDevelop.
 * User: oscar
 * Date: 19/9/2016
 * Time: 14:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ConInterfaz
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem bajasToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem modificaionesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem verTodosLosRegistrosToolStripMenuItem;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton toolStripAltas;
		private System.Windows.Forms.ToolStripButton toolStripBajas;
		private System.Windows.Forms.ToolStripButton toolStripConsultas;
		private System.Windows.Forms.ToolStripButton toolStripModificaciones;
		private System.Windows.Forms.ToolStripButton toolStripVertodos;
		
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.bajasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.modificaionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.verTodosLosRegistrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripAltas = new System.Windows.Forms.ToolStripButton();
			this.toolStripBajas = new System.Windows.Forms.ToolStripButton();
			this.toolStripConsultas = new System.Windows.Forms.ToolStripButton();
			this.toolStripModificaciones = new System.Windows.Forms.ToolStripButton();
			this.toolStripVertodos = new System.Windows.Forms.ToolStripButton();
			this.menuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.archivoToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(284, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// archivoToolStripMenuItem
			// 
			this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripMenuItem1,
			this.bajasToolStripMenuItem1,
			this.consultasToolStripMenuItem,
			this.modificaionesToolStripMenuItem,
			this.verTodosLosRegistrosToolStripMenuItem});
			this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
			this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
			this.archivoToolStripMenuItem.Text = "Archivo";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(189, 22);
			this.toolStripMenuItem1.Text = "Altas";
			this.toolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem1Click);
			// 
			// bajasToolStripMenuItem1
			// 
			this.bajasToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("bajasToolStripMenuItem1.Image")));
			this.bajasToolStripMenuItem1.Name = "bajasToolStripMenuItem1";
			this.bajasToolStripMenuItem1.Size = new System.Drawing.Size(189, 22);
			this.bajasToolStripMenuItem1.Text = "Bajas";
			this.bajasToolStripMenuItem1.Click += new System.EventHandler(this.BajasToolStripMenuItem1Click);
			// 
			// consultasToolStripMenuItem
			// 
			this.consultasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consultasToolStripMenuItem.Image")));
			this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
			this.consultasToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
			this.consultasToolStripMenuItem.Text = "Consultas";
			// 
			// modificaionesToolStripMenuItem
			// 
			this.modificaionesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("modificaionesToolStripMenuItem.Image")));
			this.modificaionesToolStripMenuItem.Name = "modificaionesToolStripMenuItem";
			this.modificaionesToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
			this.modificaionesToolStripMenuItem.Text = "Modificaiones";
			this.modificaionesToolStripMenuItem.Click += new System.EventHandler(this.ModificaionesToolStripMenuItemClick);
			// 
			// verTodosLosRegistrosToolStripMenuItem
			// 
			this.verTodosLosRegistrosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("verTodosLosRegistrosToolStripMenuItem.Image")));
			this.verTodosLosRegistrosToolStripMenuItem.Name = "verTodosLosRegistrosToolStripMenuItem";
			this.verTodosLosRegistrosToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
			this.verTodosLosRegistrosToolStripMenuItem.Text = "Ver todos los registros";
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripAltas,
			this.toolStripBajas,
			this.toolStripConsultas,
			this.toolStripModificaciones,
			this.toolStripVertodos});
			this.toolStrip1.Location = new System.Drawing.Point(0, 24);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(284, 25);
			this.toolStrip1.TabIndex = 3;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripAltas
			// 
			this.toolStripAltas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripAltas.Image = ((System.Drawing.Image)(resources.GetObject("toolStripAltas.Image")));
			this.toolStripAltas.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripAltas.Name = "toolStripAltas";
			this.toolStripAltas.Size = new System.Drawing.Size(23, 22);
			this.toolStripAltas.Text = "Alta de artículos";
			this.toolStripAltas.Click += new System.EventHandler(this.ToolStripAltasClick);
			// 
			// toolStripBajas
			// 
			this.toolStripBajas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripBajas.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBajas.Image")));
			this.toolStripBajas.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripBajas.Name = "toolStripBajas";
			this.toolStripBajas.Size = new System.Drawing.Size(23, 22);
			this.toolStripBajas.Text = "Baja de artículos";
			this.toolStripBajas.Click += new System.EventHandler(this.ToolStripBajasClick);
			// 
			// toolStripConsultas
			// 
			this.toolStripConsultas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripConsultas.Image = ((System.Drawing.Image)(resources.GetObject("toolStripConsultas.Image")));
			this.toolStripConsultas.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripConsultas.Name = "toolStripConsultas";
			this.toolStripConsultas.Size = new System.Drawing.Size(23, 22);
			this.toolStripConsultas.Text = "Consulta de artículos";
			// 
			// toolStripModificaciones
			// 
			this.toolStripModificaciones.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripModificaciones.Image = ((System.Drawing.Image)(resources.GetObject("toolStripModificaciones.Image")));
			this.toolStripModificaciones.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripModificaciones.Name = "toolStripModificaciones";
			this.toolStripModificaciones.Size = new System.Drawing.Size(23, 22);
			this.toolStripModificaciones.Text = "Modificaciones de artículos";
			this.toolStripModificaciones.Click += new System.EventHandler(this.ToolStripModificacionesClick);
			// 
			// toolStripVertodos
			// 
			this.toolStripVertodos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripVertodos.Image = ((System.Drawing.Image)(resources.GetObject("toolStripVertodos.Image")));
			this.toolStripVertodos.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripVertodos.Name = "toolStripVertodos";
			this.toolStripVertodos.Size = new System.Drawing.Size(23, 22);
			this.toolStripVertodos.Text = "Ver todos los registros";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "Formulario MDI";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
