namespace SegundoParcial.Windows
{
    partial class FrmEmpleadosAE
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
            this.EmpleadotextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DnitextBox = new System.Windows.Forms.TextBox();
            this.PuestocomboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SectorcomboBox = new System.Windows.Forms.ComboBox();
            this.Cancelarbutton = new System.Windows.Forms.Button();
            this.Okbutton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.FechaNacimientodateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DirecciontextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CiudadcomboBox = new System.Windows.Forms.ComboBox();
            this.HorariocomboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // EmpleadotextBox
            // 
            this.EmpleadotextBox.Location = new System.Drawing.Point(88, 18);
            this.EmpleadotextBox.Name = "EmpleadotextBox";
            this.EmpleadotextBox.Size = new System.Drawing.Size(370, 20);
            this.EmpleadotextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dni";
            // 
            // DnitextBox
            // 
            this.DnitextBox.Location = new System.Drawing.Point(88, 92);
            this.DnitextBox.Name = "DnitextBox";
            this.DnitextBox.Size = new System.Drawing.Size(370, 20);
            this.DnitextBox.TabIndex = 3;
            // 
            // PuestocomboBox
            // 
            this.PuestocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PuestocomboBox.FormattingEnabled = true;
            this.PuestocomboBox.Location = new System.Drawing.Point(88, 277);
            this.PuestocomboBox.Name = "PuestocomboBox";
            this.PuestocomboBox.Size = new System.Drawing.Size(370, 21);
            this.PuestocomboBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Puesto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sector";
            // 
            // SectorcomboBox
            // 
            this.SectorcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SectorcomboBox.FormattingEnabled = true;
            this.SectorcomboBox.Location = new System.Drawing.Point(89, 320);
            this.SectorcomboBox.Name = "SectorcomboBox";
            this.SectorcomboBox.Size = new System.Drawing.Size(370, 21);
            this.SectorcomboBox.TabIndex = 9;
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.Image = global::SegundoParcial.Windows.Properties.Resources.cancel_64px3;
            this.Cancelarbutton.Location = new System.Drawing.Point(337, 391);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(121, 57);
            this.Cancelarbutton.TabIndex = 11;
            this.Cancelarbutton.Text = "Cancelar";
            this.Cancelarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Cancelarbutton.UseVisualStyleBackColor = true;
            this.Cancelarbutton.Click += new System.EventHandler(this.Cancelarbutton_Click);
            // 
            // Okbutton
            // 
            this.Okbutton.Image = global::SegundoParcial.Windows.Properties.Resources.ok_36px2;
            this.Okbutton.Location = new System.Drawing.Point(73, 391);
            this.Okbutton.Name = "Okbutton";
            this.Okbutton.Size = new System.Drawing.Size(121, 57);
            this.Okbutton.TabIndex = 10;
            this.Okbutton.Text = "Ok";
            this.Okbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Okbutton.UseVisualStyleBackColor = true;
            this.Okbutton.Click += new System.EventHandler(this.Okbutton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Fecha N:";
            // 
            // FechaNacimientodateTimePicker
            // 
            this.FechaNacimientodateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaNacimientodateTimePicker.Location = new System.Drawing.Point(88, 60);
            this.FechaNacimientodateTimePicker.Name = "FechaNacimientodateTimePicker";
            this.FechaNacimientodateTimePicker.Size = new System.Drawing.Size(171, 20);
            this.FechaNacimientodateTimePicker.TabIndex = 13;
            // 
            // DirecciontextBox
            // 
            this.DirecciontextBox.Location = new System.Drawing.Point(89, 137);
            this.DirecciontextBox.Name = "DirecciontextBox";
            this.DirecciontextBox.Size = new System.Drawing.Size(370, 20);
            this.DirecciontextBox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Direccion:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Ciudad:";
            // 
            // CiudadcomboBox
            // 
            this.CiudadcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CiudadcomboBox.FormattingEnabled = true;
            this.CiudadcomboBox.Location = new System.Drawing.Point(89, 233);
            this.CiudadcomboBox.Name = "CiudadcomboBox";
            this.CiudadcomboBox.Size = new System.Drawing.Size(370, 21);
            this.CiudadcomboBox.TabIndex = 18;
            // 
            // HorariocomboBox
            // 
            this.HorariocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HorariocomboBox.FormattingEnabled = true;
            this.HorariocomboBox.Location = new System.Drawing.Point(89, 184);
            this.HorariocomboBox.Name = "HorariocomboBox";
            this.HorariocomboBox.Size = new System.Drawing.Size(370, 21);
            this.HorariocomboBox.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Horario:";
            // 
            // FrmEmpleadosAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 460);
            this.ControlBox = false;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CiudadcomboBox);
            this.Controls.Add(this.HorariocomboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DirecciontextBox);
            this.Controls.Add(this.FechaNacimientodateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cancelarbutton);
            this.Controls.Add(this.Okbutton);
            this.Controls.Add(this.SectorcomboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PuestocomboBox);
            this.Controls.Add(this.DnitextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EmpleadotextBox);
            this.Controls.Add(this.label1);
            this.Name = "FrmEmpleadosAE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEmpleadosAE";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmpleadotextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DnitextBox;
        private System.Windows.Forms.ComboBox PuestocomboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox SectorcomboBox;
        private System.Windows.Forms.Button Okbutton;
        private System.Windows.Forms.Button Cancelarbutton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DateTimePicker FechaNacimientodateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DirecciontextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CiudadcomboBox;
        private System.Windows.Forms.ComboBox HorariocomboBox;
        private System.Windows.Forms.Label label7;
    }
}