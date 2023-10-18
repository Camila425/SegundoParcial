namespace SegundoParcial.Windows
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BarramenuStrip = new System.Windows.Forms.MenuStrip();
            this.EmpleadosiconMenuItem = new FontAwesome.Sharp.IconMenuItem();
            this.PuestosiconMenuItem = new FontAwesome.Sharp.IconMenuItem();
            this.SectoresiconMenuItem = new FontAwesome.Sharp.IconMenuItem();
            this.AsistenciasiconMenuItem = new FontAwesome.Sharp.IconMenuItem();
            this.HorariosiconMenuItem = new FontAwesome.Sharp.IconMenuItem();
            this.CiudadesiconMenuItem = new FontAwesome.Sharp.IconMenuItem();
            this.PagosiconMenuItem = new FontAwesome.Sharp.IconMenuItem();
            this.TitulomenuStrip = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.Contenedorpanel = new System.Windows.Forms.Panel();
            this.BarramenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarramenuStrip
            // 
            this.BarramenuStrip.BackColor = System.Drawing.Color.Transparent;
            this.BarramenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EmpleadosiconMenuItem,
            this.PuestosiconMenuItem,
            this.SectoresiconMenuItem,
            this.AsistenciasiconMenuItem,
            this.HorariosiconMenuItem,
            this.CiudadesiconMenuItem,
            this.PagosiconMenuItem});
            this.BarramenuStrip.Location = new System.Drawing.Point(0, 57);
            this.BarramenuStrip.Name = "BarramenuStrip";
            this.BarramenuStrip.Size = new System.Drawing.Size(1224, 73);
            this.BarramenuStrip.TabIndex = 8;
            this.BarramenuStrip.Text = "menuStrip1";
            // 
            // EmpleadosiconMenuItem
            // 
            this.EmpleadosiconMenuItem.AutoSize = false;
            this.EmpleadosiconMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.EmpleadosiconMenuItem.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.EmpleadosiconMenuItem.IconColor = System.Drawing.Color.Black;
            this.EmpleadosiconMenuItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EmpleadosiconMenuItem.IconSize = 50;
            this.EmpleadosiconMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EmpleadosiconMenuItem.Name = "EmpleadosiconMenuItem";
            this.EmpleadosiconMenuItem.Size = new System.Drawing.Size(190, 69);
            this.EmpleadosiconMenuItem.Text = "Empleados";
            this.EmpleadosiconMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EmpleadosiconMenuItem.Click += new System.EventHandler(this.EmpleadosiconMenuItem_Click);
            // 
            // PuestosiconMenuItem
            // 
            this.PuestosiconMenuItem.AutoSize = false;
            this.PuestosiconMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.PuestosiconMenuItem.IconChar = FontAwesome.Sharp.IconChar.ProductHunt;
            this.PuestosiconMenuItem.IconColor = System.Drawing.Color.Black;
            this.PuestosiconMenuItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PuestosiconMenuItem.IconSize = 50;
            this.PuestosiconMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.PuestosiconMenuItem.Name = "PuestosiconMenuItem";
            this.PuestosiconMenuItem.Size = new System.Drawing.Size(190, 69);
            this.PuestosiconMenuItem.Text = "Puestos";
            this.PuestosiconMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.PuestosiconMenuItem.Click += new System.EventHandler(this.PuestosiconMenuItem_Click);
            // 
            // SectoresiconMenuItem
            // 
            this.SectoresiconMenuItem.AutoSize = false;
            this.SectoresiconMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.SectoresiconMenuItem.IconChar = FontAwesome.Sharp.IconChar.Python;
            this.SectoresiconMenuItem.IconColor = System.Drawing.Color.Black;
            this.SectoresiconMenuItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SectoresiconMenuItem.IconSize = 50;
            this.SectoresiconMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SectoresiconMenuItem.Name = "SectoresiconMenuItem";
            this.SectoresiconMenuItem.Size = new System.Drawing.Size(190, 69);
            this.SectoresiconMenuItem.Text = "Sectores";
            this.SectoresiconMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SectoresiconMenuItem.Click += new System.EventHandler(this.SectoresiconMenuItem_Click);
            // 
            // AsistenciasiconMenuItem
            // 
            this.AsistenciasiconMenuItem.AutoSize = false;
            this.AsistenciasiconMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.AsistenciasiconMenuItem.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            this.AsistenciasiconMenuItem.IconColor = System.Drawing.Color.Black;
            this.AsistenciasiconMenuItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AsistenciasiconMenuItem.IconSize = 50;
            this.AsistenciasiconMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AsistenciasiconMenuItem.Name = "AsistenciasiconMenuItem";
            this.AsistenciasiconMenuItem.Size = new System.Drawing.Size(200, 69);
            this.AsistenciasiconMenuItem.Text = "Asistencias";
            this.AsistenciasiconMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AsistenciasiconMenuItem.Click += new System.EventHandler(this.AsistenciasiconMenuItem_Click);
            // 
            // HorariosiconMenuItem
            // 
            this.HorariosiconMenuItem.AutoSize = false;
            this.HorariosiconMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.HorariosiconMenuItem.IconChar = FontAwesome.Sharp.IconChar.Wallet;
            this.HorariosiconMenuItem.IconColor = System.Drawing.Color.Black;
            this.HorariosiconMenuItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.HorariosiconMenuItem.IconSize = 50;
            this.HorariosiconMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.HorariosiconMenuItem.Name = "HorariosiconMenuItem";
            this.HorariosiconMenuItem.Size = new System.Drawing.Size(200, 69);
            this.HorariosiconMenuItem.Text = "Horarios";
            this.HorariosiconMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.HorariosiconMenuItem.Click += new System.EventHandler(this.HorariosiconMenuItem_Click);
            // 
            // CiudadesiconMenuItem
            // 
            this.CiudadesiconMenuItem.AutoSize = false;
            this.CiudadesiconMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.CiudadesiconMenuItem.IconChar = FontAwesome.Sharp.IconChar.City;
            this.CiudadesiconMenuItem.IconColor = System.Drawing.Color.Black;
            this.CiudadesiconMenuItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CiudadesiconMenuItem.IconSize = 50;
            this.CiudadesiconMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CiudadesiconMenuItem.Name = "CiudadesiconMenuItem";
            this.CiudadesiconMenuItem.Size = new System.Drawing.Size(190, 69);
            this.CiudadesiconMenuItem.Text = "Ciudades";
            this.CiudadesiconMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CiudadesiconMenuItem.Click += new System.EventHandler(this.CiudadesiconMenuItem_Click);
            // 
            // PagosiconMenuItem
            // 
            this.PagosiconMenuItem.AutoSize = false;
            this.PagosiconMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.PagosiconMenuItem.IconChar = FontAwesome.Sharp.IconChar.Paragraph;
            this.PagosiconMenuItem.IconColor = System.Drawing.Color.Black;
            this.PagosiconMenuItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PagosiconMenuItem.IconSize = 50;
            this.PagosiconMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.PagosiconMenuItem.Name = "PagosiconMenuItem";
            this.PagosiconMenuItem.Size = new System.Drawing.Size(190, 69);
            this.PagosiconMenuItem.Text = "Pagos";
            this.PagosiconMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.PagosiconMenuItem.Click += new System.EventHandler(this.PagosiconMenuItem_Click);
            // 
            // TitulomenuStrip
            // 
            this.TitulomenuStrip.AutoSize = false;
            this.TitulomenuStrip.BackColor = System.Drawing.Color.RosyBrown;
            this.TitulomenuStrip.Location = new System.Drawing.Point(0, 0);
            this.TitulomenuStrip.Name = "TitulomenuStrip";
            this.TitulomenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TitulomenuStrip.Size = new System.Drawing.Size(1224, 57);
            this.TitulomenuStrip.TabIndex = 9;
            this.TitulomenuStrip.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RosyBrown;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(565, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 36);
            this.label1.TabIndex = 10;
            this.label1.Text = "Control de Sueldos";
            // 
            // Contenedorpanel
            // 
            this.Contenedorpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedorpanel.Location = new System.Drawing.Point(0, 130);
            this.Contenedorpanel.Name = "Contenedorpanel";
            this.Contenedorpanel.Size = new System.Drawing.Size(1224, 402);
            this.Contenedorpanel.TabIndex = 11;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 532);
            this.Controls.Add(this.Contenedorpanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BarramenuStrip);
            this.Controls.Add(this.TitulomenuStrip);
            this.MainMenuStrip = this.BarramenuStrip;
            this.Name = "FrmPrincipal";
            this.Text = " ";
            this.BarramenuStrip.ResumeLayout(false);
            this.BarramenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip BarramenuStrip;
        private System.Windows.Forms.MenuStrip TitulomenuStrip;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem EmpleadosiconMenuItem;
        private FontAwesome.Sharp.IconMenuItem PuestosiconMenuItem;
        private FontAwesome.Sharp.IconMenuItem SectoresiconMenuItem;
        private FontAwesome.Sharp.IconMenuItem AsistenciasiconMenuItem;
        private FontAwesome.Sharp.IconMenuItem HorariosiconMenuItem;
        private FontAwesome.Sharp.IconMenuItem CiudadesiconMenuItem;
        private FontAwesome.Sharp.IconMenuItem PagosiconMenuItem;
        private System.Windows.Forms.Panel Contenedorpanel;
    }
}

