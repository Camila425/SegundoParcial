namespace SegundoParcial.Windows
{
    partial class FrmPagos
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DatosdataGridView = new System.Windows.Forms.DataGridView();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.Paginaslabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PaginaActuallabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Registroslabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NuevotoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.BorrartoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.EditartoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BuscartoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.ActualizartoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.DetalletoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.colempleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosdataGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 58);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DatosdataGridView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnUltimo);
            this.splitContainer1.Panel2.Controls.Add(this.btnSiguiente);
            this.splitContainer1.Panel2.Controls.Add(this.btnAnterior);
            this.splitContainer1.Panel2.Controls.Add(this.btnPrimero);
            this.splitContainer1.Panel2.Controls.Add(this.Paginaslabel);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.PaginaActuallabel);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.Registroslabel);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Size = new System.Drawing.Size(800, 392);
            this.splitContainer1.SplitterDistance = 324;
            this.splitContainer1.TabIndex = 25;
            // 
            // DatosdataGridView
            // 
            this.DatosdataGridView.AllowUserToAddRows = false;
            this.DatosdataGridView.AllowUserToDeleteRows = false;
            this.DatosdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colempleado,
            this.colfecha,
            this.colImporte,
            this.colEstado});
            this.DatosdataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatosdataGridView.Location = new System.Drawing.Point(0, 0);
            this.DatosdataGridView.Name = "DatosdataGridView";
            this.DatosdataGridView.ReadOnly = true;
            this.DatosdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatosdataGridView.Size = new System.Drawing.Size(800, 324);
            this.DatosdataGridView.TabIndex = 0;
            // 
            // btnUltimo
            // 
            this.btnUltimo.Image = global::SegundoParcial.Windows.Properties.Resources.last_48px;
            this.btnUltimo.Location = new System.Drawing.Point(524, 11);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(75, 32);
            this.btnUltimo.TabIndex = 59;
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Image = global::SegundoParcial.Windows.Properties.Resources.next_48px;
            this.btnSiguiente.Location = new System.Drawing.Point(443, 11);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 32);
            this.btnSiguiente.TabIndex = 60;
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Image = global::SegundoParcial.Windows.Properties.Resources.previous_48px;
            this.btnAnterior.Location = new System.Drawing.Point(362, 11);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 32);
            this.btnAnterior.TabIndex = 61;
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnPrimero
            // 
            this.btnPrimero.Image = global::SegundoParcial.Windows.Properties.Resources.first_48px;
            this.btnPrimero.Location = new System.Drawing.Point(281, 11);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(75, 32);
            this.btnPrimero.TabIndex = 62;
            this.btnPrimero.UseVisualStyleBackColor = true;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // Paginaslabel
            // 
            this.Paginaslabel.AutoSize = true;
            this.Paginaslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Paginaslabel.Location = new System.Drawing.Point(223, 36);
            this.Paginaslabel.Name = "Paginaslabel";
            this.Paginaslabel.Size = new System.Drawing.Size(14, 13);
            this.Paginaslabel.TabIndex = 56;
            this.Paginaslabel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "de";
            // 
            // PaginaActuallabel
            // 
            this.PaginaActuallabel.AutoSize = true;
            this.PaginaActuallabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaginaActuallabel.Location = new System.Drawing.Point(163, 36);
            this.PaginaActuallabel.Name = "PaginaActuallabel";
            this.PaginaActuallabel.Size = new System.Drawing.Size(14, 13);
            this.PaginaActuallabel.TabIndex = 57;
            this.PaginaActuallabel.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Página:";
            // 
            // Registroslabel
            // 
            this.Registroslabel.AutoSize = true;
            this.Registroslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registroslabel.Location = new System.Drawing.Point(163, 11);
            this.Registroslabel.Name = "Registroslabel";
            this.Registroslabel.Size = new System.Drawing.Size(14, 13);
            this.Registroslabel.TabIndex = 58;
            this.Registroslabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Cantidad de Registros:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.RosyBrown;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NuevotoolStripButton,
            this.BorrartoolStripButton,
            this.EditartoolStripButton,
            this.toolStripSeparator2,
            this.BuscartoolStripButton,
            this.toolStripButton1,
            this.ActualizartoolStripButton,
            this.toolStripSeparator1,
            this.DetalletoolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 58);
            this.toolStrip1.TabIndex = 24;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // NuevotoolStripButton
            // 
            this.NuevotoolStripButton.Image = global::SegundoParcial.Windows.Properties.Resources.create_36px;
            this.NuevotoolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.NuevotoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NuevotoolStripButton.Name = "NuevotoolStripButton";
            this.NuevotoolStripButton.Size = new System.Drawing.Size(46, 55);
            this.NuevotoolStripButton.Text = "Nuevo";
            this.NuevotoolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NuevotoolStripButton.Click += new System.EventHandler(this.NuevotoolStripButton_Click);
            // 
            // BorrartoolStripButton
            // 
            this.BorrartoolStripButton.Image = global::SegundoParcial.Windows.Properties.Resources.delete_36px;
            this.BorrartoolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BorrartoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BorrartoolStripButton.Name = "BorrartoolStripButton";
            this.BorrartoolStripButton.Size = new System.Drawing.Size(43, 55);
            this.BorrartoolStripButton.Text = "Borrar";
            this.BorrartoolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BorrartoolStripButton.Click += new System.EventHandler(this.BorrartoolStripButton_Click);
            // 
            // EditartoolStripButton
            // 
            this.EditartoolStripButton.Image = global::SegundoParcial.Windows.Properties.Resources.edit_36px;
            this.EditartoolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditartoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditartoolStripButton.Name = "EditartoolStripButton";
            this.EditartoolStripButton.Size = new System.Drawing.Size(41, 55);
            this.EditartoolStripButton.Text = "Editar";
            this.EditartoolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EditartoolStripButton.Click += new System.EventHandler(this.EditartoolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 58);
            // 
            // BuscartoolStripButton
            // 
            this.BuscartoolStripButton.Image = global::SegundoParcial.Windows.Properties.Resources.filter_36px;
            this.BuscartoolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BuscartoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BuscartoolStripButton.Name = "BuscartoolStripButton";
            this.BuscartoolStripButton.Size = new System.Drawing.Size(102, 55);
            this.BuscartoolStripButton.Text = "Buscar Empleado";
            this.BuscartoolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::SegundoParcial.Windows.Properties.Resources.filter_36px;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(80, 55);
            this.toolStripButton1.Text = "Buscar Fecha";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ActualizartoolStripButton
            // 
            this.ActualizartoolStripButton.Image = global::SegundoParcial.Windows.Properties.Resources.update_36px;
            this.ActualizartoolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ActualizartoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ActualizartoolStripButton.Name = "ActualizartoolStripButton";
            this.ActualizartoolStripButton.Size = new System.Drawing.Size(63, 55);
            this.ActualizartoolStripButton.Text = "Actualizar";
            this.ActualizartoolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 58);
            // 
            // DetalletoolStripButton
            // 
            this.DetalletoolStripButton.Image = global::SegundoParcial.Windows.Properties.Resources.todo_list_36px;
            this.DetalletoolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DetalletoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DetalletoolStripButton.Name = "DetalletoolStripButton";
            this.DetalletoolStripButton.Size = new System.Drawing.Size(83, 55);
            this.DetalletoolStripButton.Text = "Detalle Pago  ";
            this.DetalletoolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.DetalletoolStripButton.Click += new System.EventHandler(this.DetalletoolStripButton_Click);
            // 
            // colempleado
            // 
            this.colempleado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colempleado.HeaderText = "Empleado";
            this.colempleado.Name = "colempleado";
            this.colempleado.ReadOnly = true;
            // 
            // colfecha
            // 
            this.colfecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colfecha.HeaderText = "Fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.ReadOnly = true;
            // 
            // colImporte
            // 
            this.colImporte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colImporte.HeaderText = "Sueldo";
            this.colImporte.Name = "colImporte";
            this.colImporte.ReadOnly = true;
            // 
            // colEstado
            // 
            this.colEstado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            this.colEstado.Width = 65;
            // 
            // FrmPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmPagos";
            this.Text = "FrmPagos";
            this.Load += new System.EventHandler(this.FrmPagos_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatosdataGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView DatosdataGridView;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Label Paginaslabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label PaginaActuallabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Registroslabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton NuevotoolStripButton;
        private System.Windows.Forms.ToolStripButton BorrartoolStripButton;
        private System.Windows.Forms.ToolStripButton EditartoolStripButton;
        private System.Windows.Forms.ToolStripButton BuscartoolStripButton;
        private System.Windows.Forms.ToolStripButton ActualizartoolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton DetalletoolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn colempleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
    }
}