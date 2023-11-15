namespace SegundoParcial.Windows
{
    partial class FrmDetallePago
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
            this.EmpleadogroupBox = new System.Windows.Forms.GroupBox();
            this.FechatextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DnitextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EmpleadotextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cancelarbutton = new System.Windows.Forms.Button();
            this.OKbutton = new System.Windows.Forms.Button();
            this.DatosdataGridView = new System.Windows.Forms.DataGridView();
            this.colpagoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colimporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.EmpleadogroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.EmpleadogroupBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Cancelarbutton);
            this.splitContainer1.Panel2.Controls.Add(this.OKbutton);
            this.splitContainer1.Panel2.Controls.Add(this.DatosdataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(909, 497);
            this.splitContainer1.SplitterDistance = 165;
            this.splitContainer1.TabIndex = 0;
            // 
            // EmpleadogroupBox
            // 
            this.EmpleadogroupBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EmpleadogroupBox.Controls.Add(this.FechatextBox);
            this.EmpleadogroupBox.Controls.Add(this.label4);
            this.EmpleadogroupBox.Controls.Add(this.DnitextBox);
            this.EmpleadogroupBox.Controls.Add(this.label2);
            this.EmpleadogroupBox.Controls.Add(this.EmpleadotextBox);
            this.EmpleadogroupBox.Controls.Add(this.label1);
            this.EmpleadogroupBox.ForeColor = System.Drawing.Color.Black;
            this.EmpleadogroupBox.Location = new System.Drawing.Point(12, 3);
            this.EmpleadogroupBox.Name = "EmpleadogroupBox";
            this.EmpleadogroupBox.Size = new System.Drawing.Size(885, 142);
            this.EmpleadogroupBox.TabIndex = 0;
            this.EmpleadogroupBox.TabStop = false;
            this.EmpleadogroupBox.Text = "Datos Empleado";
            // 
            // FechatextBox
            // 
            this.FechatextBox.Enabled = false;
            this.FechatextBox.Location = new System.Drawing.Point(69, 116);
            this.FechatextBox.Name = "FechatextBox";
            this.FechatextBox.Size = new System.Drawing.Size(189, 20);
            this.FechatextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha";
            // 
            // DnitextBox
            // 
            this.DnitextBox.Enabled = false;
            this.DnitextBox.Location = new System.Drawing.Point(69, 75);
            this.DnitextBox.Name = "DnitextBox";
            this.DnitextBox.Size = new System.Drawing.Size(189, 20);
            this.DnitextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dni:";
            // 
            // EmpleadotextBox
            // 
            this.EmpleadotextBox.Enabled = false;
            this.EmpleadotextBox.Location = new System.Drawing.Point(69, 27);
            this.EmpleadotextBox.Name = "EmpleadotextBox";
            this.EmpleadotextBox.Size = new System.Drawing.Size(189, 20);
            this.EmpleadotextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empleado:";
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.Image = global::SegundoParcial.Windows.Properties.Resources.cancel_64px7;
            this.Cancelarbutton.Location = new System.Drawing.Point(512, 256);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(139, 64);
            this.Cancelarbutton.TabIndex = 2;
            this.Cancelarbutton.Text = "Cancelar";
            this.Cancelarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Cancelarbutton.UseVisualStyleBackColor = true;
            this.Cancelarbutton.Click += new System.EventHandler(this.Cancelarbutton_Click);
            // 
            // OKbutton
            // 
            this.OKbutton.Image = global::SegundoParcial.Windows.Properties.Resources.money_40px3;
            this.OKbutton.Location = new System.Drawing.Point(248, 256);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(139, 64);
            this.OKbutton.TabIndex = 1;
            this.OKbutton.Text = "Realizar Pago";
            this.OKbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // DatosdataGridView
            // 
            this.DatosdataGridView.AllowUserToAddRows = false;
            this.DatosdataGridView.AllowUserToDeleteRows = false;
            this.DatosdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colpagoId,
            this.colimporte});
            this.DatosdataGridView.Location = new System.Drawing.Point(3, 3);
            this.DatosdataGridView.Name = "DatosdataGridView";
            this.DatosdataGridView.ReadOnly = true;
            this.DatosdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatosdataGridView.Size = new System.Drawing.Size(903, 234);
            this.DatosdataGridView.TabIndex = 0;
            // 
            // colpagoId
            // 
            this.colpagoId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colpagoId.HeaderText = "PagoId";
            this.colpagoId.Name = "colpagoId";
            this.colpagoId.ReadOnly = true;
            // 
            // colimporte
            // 
            this.colimporte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colimporte.HeaderText = "Importe A Cobrar";
            this.colimporte.Name = "colimporte";
            this.colimporte.ReadOnly = true;
            // 
            // FrmDetallePago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 497);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmDetallePago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetallePago";
            this.Load += new System.EventHandler(this.DetallePago_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.EmpleadogroupBox.ResumeLayout(false);
            this.EmpleadogroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox EmpleadogroupBox;
        private System.Windows.Forms.TextBox DnitextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EmpleadotextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FechatextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DatosdataGridView;
        private System.Windows.Forms.Button Cancelarbutton;
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpagoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colimporte;
    }
}