namespace SegundoParcial.Windows
{
    partial class FrmAsistencias
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
            this.buttonUltimo = new System.Windows.Forms.Button();
            this.buttonSiguiente = new System.Windows.Forms.Button();
            this.buttonAnterior = new System.Windows.Forms.Button();
            this.buttonPrimero = new System.Windows.Forms.Button();
            this.Paginaslabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PaginaActuallabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Registroslabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NuevotoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.EditartoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.BorrartoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.BuscartoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ActualizartoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.colEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoraEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colhorasalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colhorastrabajadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.splitContainer1.Panel2.Controls.Add(this.buttonUltimo);
            this.splitContainer1.Panel2.Controls.Add(this.buttonSiguiente);
            this.splitContainer1.Panel2.Controls.Add(this.buttonAnterior);
            this.splitContainer1.Panel2.Controls.Add(this.buttonPrimero);
            this.splitContainer1.Panel2.Controls.Add(this.Paginaslabel);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.PaginaActuallabel);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.Registroslabel);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Size = new System.Drawing.Size(800, 322);
            this.splitContainer1.SplitterDistance = 227;
            this.splitContainer1.TabIndex = 25;
            // 
            // DatosdataGridView
            // 
            this.DatosdataGridView.AllowUserToAddRows = false;
            this.DatosdataGridView.AllowUserToDeleteRows = false;
            this.DatosdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEmpleado,
            this.coldni,
            this.colfecha,
            this.colHoraEntrada,
            this.colhorasalida,
            this.colhorastrabajadas});
            this.DatosdataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatosdataGridView.Location = new System.Drawing.Point(0, 0);
            this.DatosdataGridView.Name = "DatosdataGridView";
            this.DatosdataGridView.ReadOnly = true;
            this.DatosdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatosdataGridView.Size = new System.Drawing.Size(800, 227);
            this.DatosdataGridView.TabIndex = 0;
            // 
            // buttonUltimo
            // 
            this.buttonUltimo.Image = global::SegundoParcial.Windows.Properties.Resources.last_48px;
            this.buttonUltimo.Location = new System.Drawing.Point(494, 18);
            this.buttonUltimo.Name = "buttonUltimo";
            this.buttonUltimo.Size = new System.Drawing.Size(75, 32);
            this.buttonUltimo.TabIndex = 69;
            this.buttonUltimo.UseVisualStyleBackColor = true;
            this.buttonUltimo.Click += new System.EventHandler(this.buttonUltimo_Click);
            // 
            // buttonSiguiente
            // 
            this.buttonSiguiente.Image = global::SegundoParcial.Windows.Properties.Resources.next_48px;
            this.buttonSiguiente.Location = new System.Drawing.Point(413, 18);
            this.buttonSiguiente.Name = "buttonSiguiente";
            this.buttonSiguiente.Size = new System.Drawing.Size(75, 32);
            this.buttonSiguiente.TabIndex = 70;
            this.buttonSiguiente.UseVisualStyleBackColor = true;
            this.buttonSiguiente.Click += new System.EventHandler(this.buttonSiguiente_Click);
            // 
            // buttonAnterior
            // 
            this.buttonAnterior.Image = global::SegundoParcial.Windows.Properties.Resources.previous_48px;
            this.buttonAnterior.Location = new System.Drawing.Point(332, 18);
            this.buttonAnterior.Name = "buttonAnterior";
            this.buttonAnterior.Size = new System.Drawing.Size(75, 32);
            this.buttonAnterior.TabIndex = 71;
            this.buttonAnterior.UseVisualStyleBackColor = true;
            this.buttonAnterior.Click += new System.EventHandler(this.buttonAnterior_Click);
            // 
            // buttonPrimero
            // 
            this.buttonPrimero.Image = global::SegundoParcial.Windows.Properties.Resources.first_48px;
            this.buttonPrimero.Location = new System.Drawing.Point(251, 18);
            this.buttonPrimero.Name = "buttonPrimero";
            this.buttonPrimero.Size = new System.Drawing.Size(75, 32);
            this.buttonPrimero.TabIndex = 72;
            this.buttonPrimero.Text = " ";
            this.buttonPrimero.UseVisualStyleBackColor = true;
            this.buttonPrimero.Click += new System.EventHandler(this.buttonPrimero_Click);
            // 
            // Paginaslabel
            // 
            this.Paginaslabel.AutoSize = true;
            this.Paginaslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Paginaslabel.Location = new System.Drawing.Point(193, 43);
            this.Paginaslabel.Name = "Paginaslabel";
            this.Paginaslabel.Size = new System.Drawing.Size(14, 13);
            this.Paginaslabel.TabIndex = 66;
            this.Paginaslabel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "de";
            // 
            // PaginaActuallabel
            // 
            this.PaginaActuallabel.AutoSize = true;
            this.PaginaActuallabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaginaActuallabel.Location = new System.Drawing.Point(133, 43);
            this.PaginaActuallabel.Name = "PaginaActuallabel";
            this.PaginaActuallabel.Size = new System.Drawing.Size(14, 13);
            this.PaginaActuallabel.TabIndex = 67;
            this.PaginaActuallabel.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "Página:";
            // 
            // Registroslabel
            // 
            this.Registroslabel.AutoSize = true;
            this.Registroslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registroslabel.Location = new System.Drawing.Point(133, 18);
            this.Registroslabel.Name = "Registroslabel";
            this.Registroslabel.Size = new System.Drawing.Size(14, 13);
            this.Registroslabel.TabIndex = 68;
            this.Registroslabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "Cantidad de Registros:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.RosyBrown;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NuevotoolStripButton,
            this.EditartoolStripButton,
            this.toolStripSeparator3,
            this.BorrartoolStripButton,
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.BuscartoolStripButton,
            this.toolStripSeparator4,
            this.ActualizartoolStripButton,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 58);
            this.toolStrip1.TabIndex = 24;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // NuevotoolStripButton
            // 
            this.NuevotoolStripButton.Image = global::SegundoParcial.Windows.Properties.Resources.open_garage_door_36px;
            this.NuevotoolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.NuevotoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NuevotoolStripButton.Name = "NuevotoolStripButton";
            this.NuevotoolStripButton.Size = new System.Drawing.Size(116, 55);
            this.NuevotoolStripButton.Text = "Registrar  Asistencia";
            this.NuevotoolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NuevotoolStripButton.Click += new System.EventHandler(this.NuevotoolStripButton_Click);
            // 
            // EditartoolStripButton
            // 
            this.EditartoolStripButton.Image = global::SegundoParcial.Windows.Properties.Resources.exit_36px;
            this.EditartoolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditartoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditartoolStripButton.Name = "EditartoolStripButton";
            this.EditartoolStripButton.Size = new System.Drawing.Size(94, 55);
            this.EditartoolStripButton.Text = "Registrar  Salida";
            this.EditartoolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EditartoolStripButton.Click += new System.EventHandler(this.EditartoolStripButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 58);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 58);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::SegundoParcial.Windows.Properties.Resources.filter_36px;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(85, 55);
            this.toolStripButton1.Text = "Buscar Fechas";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
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
            this.BuscartoolStripButton.Click += new System.EventHandler(this.BuscartoolStripButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 58);
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
            this.ActualizartoolStripButton.Click += new System.EventHandler(this.ActualizartoolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 58);
            // 
            // colEmpleado
            // 
            this.colEmpleado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEmpleado.HeaderText = "Empleado";
            this.colEmpleado.Name = "colEmpleado";
            this.colEmpleado.ReadOnly = true;
            // 
            // coldni
            // 
            this.coldni.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.coldni.HeaderText = "Dni";
            this.coldni.Name = "coldni";
            this.coldni.ReadOnly = true;
            // 
            // colfecha
            // 
            this.colfecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colfecha.HeaderText = "Fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.ReadOnly = true;
            // 
            // colHoraEntrada
            // 
            this.colHoraEntrada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colHoraEntrada.HeaderText = "Hora Entrada";
            this.colHoraEntrada.Name = "colHoraEntrada";
            this.colHoraEntrada.ReadOnly = true;
            // 
            // colhorasalida
            // 
            this.colhorasalida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colhorasalida.HeaderText = "Hora Salida";
            this.colhorasalida.Name = "colhorasalida";
            this.colhorasalida.ReadOnly = true;
            // 
            // colhorastrabajadas
            // 
            this.colhorastrabajadas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colhorastrabajadas.HeaderText = "H.Trabajadas";
            this.colhorastrabajadas.Name = "colhorastrabajadas";
            this.colhorastrabajadas.ReadOnly = true;
            // 
            // FrmAsistencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 380);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmAsistencias";
            this.Text = "FrmAsistencias";
            this.Load += new System.EventHandler(this.FrmAsistencias_Load);
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
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton NuevotoolStripButton;
        private System.Windows.Forms.ToolStripButton BorrartoolStripButton;
        private System.Windows.Forms.ToolStripButton EditartoolStripButton;
        private System.Windows.Forms.ToolStripButton BuscartoolStripButton;
        private System.Windows.Forms.ToolStripButton ActualizartoolStripButton;
        private System.Windows.Forms.Button buttonUltimo;
        private System.Windows.Forms.Button buttonSiguiente;
        private System.Windows.Forms.Button buttonAnterior;
        private System.Windows.Forms.Button buttonPrimero;
        private System.Windows.Forms.Label Paginaslabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label PaginaActuallabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Registroslabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldni;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoraEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn colhorasalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn colhorastrabajadas;
    }
}