namespace SegundoParcial.Windows
{
    partial class FrmPuestos
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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BorrartoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.EditartoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.CerrartoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.colnombrePuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colsueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.splitContainer1.Size = new System.Drawing.Size(800, 392);
            this.splitContainer1.SplitterDistance = 326;
            this.splitContainer1.TabIndex = 25;
            // 
            // DatosdataGridView
            // 
            this.DatosdataGridView.AllowUserToAddRows = false;
            this.DatosdataGridView.AllowUserToDeleteRows = false;
            this.DatosdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colnombrePuesto,
            this.colsueldo});
            this.DatosdataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatosdataGridView.Location = new System.Drawing.Point(0, 0);
            this.DatosdataGridView.Name = "DatosdataGridView";
            this.DatosdataGridView.ReadOnly = true;
            this.DatosdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatosdataGridView.Size = new System.Drawing.Size(800, 326);
            this.DatosdataGridView.TabIndex = 0;
            // 
            // buttonUltimo
            // 
            this.buttonUltimo.Image = global::SegundoParcial.Windows.Properties.Resources.last_48px;
            this.buttonUltimo.Location = new System.Drawing.Point(494, 12);
            this.buttonUltimo.Name = "buttonUltimo";
            this.buttonUltimo.Size = new System.Drawing.Size(75, 32);
            this.buttonUltimo.TabIndex = 69;
            this.buttonUltimo.UseVisualStyleBackColor = true;
            this.buttonUltimo.Click += new System.EventHandler(this.buttonUltimo_Click);
            // 
            // buttonSiguiente
            // 
            this.buttonSiguiente.Image = global::SegundoParcial.Windows.Properties.Resources.next_48px;
            this.buttonSiguiente.Location = new System.Drawing.Point(413, 12);
            this.buttonSiguiente.Name = "buttonSiguiente";
            this.buttonSiguiente.Size = new System.Drawing.Size(75, 32);
            this.buttonSiguiente.TabIndex = 70;
            this.buttonSiguiente.UseVisualStyleBackColor = true;
            this.buttonSiguiente.Click += new System.EventHandler(this.buttonSiguiente_Click);
            // 
            // buttonAnterior
            // 
            this.buttonAnterior.Image = global::SegundoParcial.Windows.Properties.Resources.previous_48px;
            this.buttonAnterior.Location = new System.Drawing.Point(332, 12);
            this.buttonAnterior.Name = "buttonAnterior";
            this.buttonAnterior.Size = new System.Drawing.Size(75, 32);
            this.buttonAnterior.TabIndex = 71;
            this.buttonAnterior.UseVisualStyleBackColor = true;
            this.buttonAnterior.Click += new System.EventHandler(this.buttonAnterior_Click);
            // 
            // buttonPrimero
            // 
            this.buttonPrimero.Image = global::SegundoParcial.Windows.Properties.Resources.first_48px1;
            this.buttonPrimero.Location = new System.Drawing.Point(251, 12);
            this.buttonPrimero.Name = "buttonPrimero";
            this.buttonPrimero.Size = new System.Drawing.Size(75, 32);
            this.buttonPrimero.TabIndex = 72;
            this.buttonPrimero.UseVisualStyleBackColor = true;
            this.buttonPrimero.Click += new System.EventHandler(this.buttonPrimero_Click);
            // 
            // Paginaslabel
            // 
            this.Paginaslabel.AutoSize = true;
            this.Paginaslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Paginaslabel.Location = new System.Drawing.Point(193, 37);
            this.Paginaslabel.Name = "Paginaslabel";
            this.Paginaslabel.Size = new System.Drawing.Size(14, 13);
            this.Paginaslabel.TabIndex = 66;
            this.Paginaslabel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "de";
            // 
            // PaginaActuallabel
            // 
            this.PaginaActuallabel.AutoSize = true;
            this.PaginaActuallabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaginaActuallabel.Location = new System.Drawing.Point(133, 37);
            this.PaginaActuallabel.Name = "PaginaActuallabel";
            this.PaginaActuallabel.Size = new System.Drawing.Size(14, 13);
            this.PaginaActuallabel.TabIndex = 67;
            this.PaginaActuallabel.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "Página:";
            // 
            // Registroslabel
            // 
            this.Registroslabel.AutoSize = true;
            this.Registroslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registroslabel.Location = new System.Drawing.Point(133, 12);
            this.Registroslabel.Name = "Registroslabel";
            this.Registroslabel.Size = new System.Drawing.Size(14, 13);
            this.Registroslabel.TabIndex = 68;
            this.Registroslabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 12);
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
            this.toolStripSeparator1,
            this.BorrartoolStripButton,
            this.EditartoolStripButton,
            this.CerrartoolStripButton});
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 58);
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
            // CerrartoolStripButton
            // 
            this.CerrartoolStripButton.Image = global::SegundoParcial.Windows.Properties.Resources.cancel_64px;
            this.CerrartoolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CerrartoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CerrartoolStripButton.Name = "CerrartoolStripButton";
            this.CerrartoolStripButton.Size = new System.Drawing.Size(43, 55);
            this.CerrartoolStripButton.Text = "Cerrar";
            this.CerrartoolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CerrartoolStripButton.Click += new System.EventHandler(this.CerrartoolStripButton_Click);
            // 
            // colnombrePuesto
            // 
            this.colnombrePuesto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colnombrePuesto.HeaderText = "Nombre Puesto";
            this.colnombrePuesto.Name = "colnombrePuesto";
            this.colnombrePuesto.ReadOnly = true;
            // 
            // colsueldo
            // 
            this.colsueldo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colsueldo.HeaderText = "Sueldo Por Hora";
            this.colsueldo.Name = "colsueldo";
            this.colsueldo.ReadOnly = true;
            // 
            // FrmPuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmPuestos";
            this.Text = "FrmPuestos";
            this.Load += new System.EventHandler(this.FrmPuestos_Load);
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BorrartoolStripButton;
        private System.Windows.Forms.ToolStripButton EditartoolStripButton;
        private System.Windows.Forms.ToolStripButton CerrartoolStripButton;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colnombrePuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colsueldo;
    }
}