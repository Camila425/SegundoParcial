namespace SegundoParcial.Windows
{
    partial class FrmDetallesDelPago
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DetallePanel = new System.Windows.Forms.Panel();
            this.DatosdataGridView = new System.Windows.Forms.DataGridView();
            this.colsueldoporhora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colhorastrabajadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcanthorasextras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColhorasExtras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldescuentos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colimporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colimporteAPagarConDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalesPanel = new System.Windows.Forms.Panel();
            this.EncabezadoPanel = new System.Windows.Forms.Panel();
            this.SueldotextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.puestoTextBox = new System.Windows.Forms.TextBox();
            this.puestolabel = new System.Windows.Forms.Label();
            this.empleadoTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fechaTextBox = new System.Windows.Forms.TextBox();
            this.Fechalabel = new System.Windows.Forms.Label();
            this.DetallePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosdataGridView)).BeginInit();
            this.EncabezadoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DetallePanel
            // 
            this.DetallePanel.Controls.Add(this.DatosdataGridView);
            this.DetallePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetallePanel.Location = new System.Drawing.Point(0, 107);
            this.DetallePanel.Name = "DetallePanel";
            this.DetallePanel.Size = new System.Drawing.Size(845, 248);
            this.DetallePanel.TabIndex = 8;
            // 
            // DatosdataGridView
            // 
            this.DatosdataGridView.AllowUserToAddRows = false;
            this.DatosdataGridView.AllowUserToDeleteRows = false;
            this.DatosdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colsueldoporhora,
            this.colhorastrabajadas,
            this.colcanthorasextras,
            this.ColhorasExtras,
            this.coldescuentos,
            this.Colimporte,
            this.colimporteAPagarConDescuento});
            this.DatosdataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatosdataGridView.Location = new System.Drawing.Point(0, 0);
            this.DatosdataGridView.Name = "DatosdataGridView";
            this.DatosdataGridView.ReadOnly = true;
            this.DatosdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatosdataGridView.Size = new System.Drawing.Size(845, 248);
            this.DatosdataGridView.TabIndex = 0;
            // 
            // colsueldoporhora
            // 
            this.colsueldoporhora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colsueldoporhora.HeaderText = "Sueldo X H.";
            this.colsueldoporhora.Name = "colsueldoporhora";
            this.colsueldoporhora.ReadOnly = true;
            // 
            // colhorastrabajadas
            // 
            this.colhorastrabajadas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colhorastrabajadas.HeaderText = "H.Trabajadas";
            this.colhorastrabajadas.Name = "colhorastrabajadas";
            this.colhorastrabajadas.ReadOnly = true;
            this.colhorastrabajadas.Width = 96;
            // 
            // colcanthorasextras
            // 
            this.colcanthorasextras.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colcanthorasextras.HeaderText = "Cant.H.Extras";
            this.colcanthorasextras.Name = "colcanthorasextras";
            this.colcanthorasextras.ReadOnly = true;
            this.colcanthorasextras.Width = 97;
            // 
            // ColhorasExtras
            // 
            this.ColhorasExtras.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColhorasExtras.HeaderText = "Precio  X H.E";
            this.ColhorasExtras.Name = "ColhorasExtras";
            this.ColhorasExtras.ReadOnly = true;
            // 
            // coldescuentos
            // 
            this.coldescuentos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.coldescuentos.HeaderText = "Descuentos X Dia";
            this.coldescuentos.Name = "coldescuentos";
            this.coldescuentos.ReadOnly = true;
            // 
            // Colimporte
            // 
            this.Colimporte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Colimporte.HeaderText = "Sueldo";
            this.Colimporte.Name = "Colimporte";
            this.Colimporte.ReadOnly = true;
            // 
            // colimporteAPagarConDescuento
            // 
            this.colimporteAPagarConDescuento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colimporteAPagarConDescuento.HeaderText = "Importe Total";
            this.colimporteAPagarConDescuento.Name = "colimporteAPagarConDescuento";
            this.colimporteAPagarConDescuento.ReadOnly = true;
            // 
            // TotalesPanel
            // 
            this.TotalesPanel.BackColor = System.Drawing.Color.RosyBrown;
            this.TotalesPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TotalesPanel.Location = new System.Drawing.Point(0, 355);
            this.TotalesPanel.Name = "TotalesPanel";
            this.TotalesPanel.Size = new System.Drawing.Size(845, 28);
            this.TotalesPanel.TabIndex = 7;
            // 
            // EncabezadoPanel
            // 
            this.EncabezadoPanel.BackColor = System.Drawing.Color.RosyBrown;
            this.EncabezadoPanel.Controls.Add(this.SueldotextBox);
            this.EncabezadoPanel.Controls.Add(this.label1);
            this.EncabezadoPanel.Controls.Add(this.puestoTextBox);
            this.EncabezadoPanel.Controls.Add(this.puestolabel);
            this.EncabezadoPanel.Controls.Add(this.empleadoTextBox);
            this.EncabezadoPanel.Controls.Add(this.label2);
            this.EncabezadoPanel.Controls.Add(this.fechaTextBox);
            this.EncabezadoPanel.Controls.Add(this.Fechalabel);
            this.EncabezadoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.EncabezadoPanel.Location = new System.Drawing.Point(0, 0);
            this.EncabezadoPanel.Name = "EncabezadoPanel";
            this.EncabezadoPanel.Size = new System.Drawing.Size(845, 107);
            this.EncabezadoPanel.TabIndex = 6;
            // 
            // SueldotextBox
            // 
            this.SueldotextBox.Enabled = false;
            this.SueldotextBox.Location = new System.Drawing.Point(397, 67);
            this.SueldotextBox.Name = "SueldotextBox";
            this.SueldotextBox.Size = new System.Drawing.Size(210, 20);
            this.SueldotextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sueldo";
            // 
            // puestoTextBox
            // 
            this.puestoTextBox.Enabled = false;
            this.puestoTextBox.Location = new System.Drawing.Point(71, 67);
            this.puestoTextBox.Name = "puestoTextBox";
            this.puestoTextBox.Size = new System.Drawing.Size(237, 20);
            this.puestoTextBox.TabIndex = 1;
            // 
            // puestolabel
            // 
            this.puestolabel.AutoSize = true;
            this.puestolabel.Location = new System.Drawing.Point(25, 70);
            this.puestolabel.Name = "puestolabel";
            this.puestolabel.Size = new System.Drawing.Size(40, 13);
            this.puestolabel.TabIndex = 0;
            this.puestolabel.Text = "Puesto";
            // 
            // empleadoTextBox
            // 
            this.empleadoTextBox.Enabled = false;
            this.empleadoTextBox.Location = new System.Drawing.Point(142, 36);
            this.empleadoTextBox.Name = "empleadoTextBox";
            this.empleadoTextBox.Size = new System.Drawing.Size(335, 20);
            this.empleadoTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre de empleado:";
            // 
            // fechaTextBox
            // 
            this.fechaTextBox.Enabled = false;
            this.fechaTextBox.Location = new System.Drawing.Point(90, 11);
            this.fechaTextBox.Name = "fechaTextBox";
            this.fechaTextBox.Size = new System.Drawing.Size(156, 20);
            this.fechaTextBox.TabIndex = 1;
            // 
            // Fechalabel
            // 
            this.Fechalabel.AutoSize = true;
            this.Fechalabel.Location = new System.Drawing.Point(25, 13);
            this.Fechalabel.Name = "Fechalabel";
            this.Fechalabel.Size = new System.Drawing.Size(40, 13);
            this.Fechalabel.TabIndex = 0;
            this.Fechalabel.Text = "Fecha ";
            // 
            // FrmDetallesDelPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 383);
            this.Controls.Add(this.DetallePanel);
            this.Controls.Add(this.TotalesPanel);
            this.Controls.Add(this.EncabezadoPanel);
            this.Name = "FrmDetallesDelPago";
            this.Text = "FrmDetallesDelPago";
            this.DetallePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatosdataGridView)).EndInit();
            this.EncabezadoPanel.ResumeLayout(false);
            this.EncabezadoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DetallePanel;
        private System.Windows.Forms.DataGridView DatosdataGridView;
        private System.Windows.Forms.Panel TotalesPanel;
        private System.Windows.Forms.Panel EncabezadoPanel;
        private System.Windows.Forms.TextBox puestoTextBox;
        private System.Windows.Forms.Label puestolabel;
        private System.Windows.Forms.TextBox empleadoTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fechaTextBox;
        private System.Windows.Forms.Label Fechalabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SueldotextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn colsueldoporhora;
        private System.Windows.Forms.DataGridViewTextBoxColumn colhorastrabajadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcanthorasextras;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColhorasExtras;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldescuentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colimporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn colimporteAPagarConDescuento;
    }
}