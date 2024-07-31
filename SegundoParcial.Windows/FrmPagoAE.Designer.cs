namespace SegundoParcial.Windows
{
    partial class FrmPagoAE
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.EmpleadocomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Cancelarbutton = new System.Windows.Forms.Button();
            this.Okbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ImporteTotaltextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = " Empleado:";
            // 
            // EmpleadocomboBox
            // 
            this.EmpleadocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EmpleadocomboBox.FormattingEnabled = true;
            this.EmpleadocomboBox.Location = new System.Drawing.Point(96, 19);
            this.EmpleadocomboBox.Name = "EmpleadocomboBox";
            this.EmpleadocomboBox.Size = new System.Drawing.Size(336, 21);
            this.EmpleadocomboBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha:";
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechadateTimePicker.Location = new System.Drawing.Point(96, 71);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(336, 20);
            this.FechadateTimePicker.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.Image = global::SegundoParcial.Windows.Properties.Resources.cancel_64px6;
            this.Cancelarbutton.Location = new System.Drawing.Point(276, 202);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(142, 59);
            this.Cancelarbutton.TabIndex = 5;
            this.Cancelarbutton.UseVisualStyleBackColor = true;
            this.Cancelarbutton.Click += new System.EventHandler(this.Cancelarbutton_Click);
            // 
            // Okbutton
            // 
            this.Okbutton.Image = global::SegundoParcial.Windows.Properties.Resources.ok_36px4;
            this.Okbutton.Location = new System.Drawing.Point(47, 202);
            this.Okbutton.Name = "Okbutton";
            this.Okbutton.Size = new System.Drawing.Size(149, 59);
            this.Okbutton.TabIndex = 4;
            this.Okbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Okbutton.UseVisualStyleBackColor = true;
            this.Okbutton.Click += new System.EventHandler(this.Okbutton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Importe Total";
            // 
            // ImporteTotaltextBox
            // 
            this.ImporteTotaltextBox.Location = new System.Drawing.Point(96, 132);
            this.ImporteTotaltextBox.Name = "ImporteTotaltextBox";
            this.ImporteTotaltextBox.Size = new System.Drawing.Size(336, 20);
            this.ImporteTotaltextBox.TabIndex = 9;
            // 
            // FrmPagoAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(451, 283);
            this.ControlBox = false;
            this.Controls.Add(this.ImporteTotaltextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cancelarbutton);
            this.Controls.Add(this.Okbutton);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EmpleadocomboBox);
            this.Controls.Add(this.label1);
            this.Name = "FrmPagoAE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPagoAE";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox EmpleadocomboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.Button Okbutton;
        private System.Windows.Forms.Button Cancelarbutton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox ImporteTotaltextBox;
        private System.Windows.Forms.Label label4;
    }
}