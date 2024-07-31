namespace SegundoParcial.Windows
{
    partial class FrmAsistenciaAE
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
            this.label2 = new System.Windows.Forms.Label();
            this.ImageniconPictureBox = new FontAwesome.Sharp.IconPictureBox();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.EmpleadocomboBox = new System.Windows.Forms.ComboBox();
            this.Cancelarbutton = new System.Windows.Forms.Button();
            this.Registrarbutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.HoraEntradadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.HoraSalidadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.FechahoydateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.ImageniconPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 0;
            // 
            // ImageniconPictureBox
            // 
            this.ImageniconPictureBox.BackColor = System.Drawing.Color.RosyBrown;
            this.ImageniconPictureBox.ForeColor = System.Drawing.Color.Black;
            this.ImageniconPictureBox.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.ImageniconPictureBox.IconColor = System.Drawing.Color.Black;
            this.ImageniconPictureBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ImageniconPictureBox.IconSize = 198;
            this.ImageniconPictureBox.Location = new System.Drawing.Point(-1, 2);
            this.ImageniconPictureBox.Name = "ImageniconPictureBox";
            this.ImageniconPictureBox.Size = new System.Drawing.Size(198, 251);
            this.ImageniconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageniconPictureBox.TabIndex = 5;
            this.ImageniconPictureBox.TabStop = false;
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechadateTimePicker.Location = new System.Drawing.Point(213, 12);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(457, 31);
            this.FechadateTimePicker.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkGray;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(362, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Empleado:";
            // 
            // EmpleadocomboBox
            // 
            this.EmpleadocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EmpleadocomboBox.FormattingEnabled = true;
            this.EmpleadocomboBox.Location = new System.Drawing.Point(425, 66);
            this.EmpleadocomboBox.Name = "EmpleadocomboBox";
            this.EmpleadocomboBox.Size = new System.Drawing.Size(245, 21);
            this.EmpleadocomboBox.TabIndex = 3;
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.BackColor = System.Drawing.Color.LightGray;
            this.Cancelarbutton.ForeColor = System.Drawing.Color.Black;
            this.Cancelarbutton.Location = new System.Drawing.Point(540, 239);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(131, 65);
            this.Cancelarbutton.TabIndex = 11;
            this.Cancelarbutton.Text = "Cancelar";
            this.Cancelarbutton.UseVisualStyleBackColor = false;
            this.Cancelarbutton.Click += new System.EventHandler(this.Cancelarbutton_Click);
            // 
            // Registrarbutton
            // 
            this.Registrarbutton.BackColor = System.Drawing.Color.LightGray;
            this.Registrarbutton.ForeColor = System.Drawing.Color.Black;
            this.Registrarbutton.Location = new System.Drawing.Point(260, 239);
            this.Registrarbutton.Name = "Registrarbutton";
            this.Registrarbutton.Size = new System.Drawing.Size(131, 65);
            this.Registrarbutton.TabIndex = 10;
            this.Registrarbutton.Text = "Registrar";
            this.Registrarbutton.UseVisualStyleBackColor = false;
            this.Registrarbutton.Click += new System.EventHandler(this.Registrarbutton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkGray;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(362, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "H Salida";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkGray;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(362, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "H Entrada:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // HoraEntradadateTimePicker
            // 
            this.HoraEntradadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.HoraEntradadateTimePicker.Location = new System.Drawing.Point(426, 148);
            this.HoraEntradadateTimePicker.Name = "HoraEntradadateTimePicker";
            this.HoraEntradadateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HoraEntradadateTimePicker.ShowUpDown = true;
            this.HoraEntradadateTimePicker.Size = new System.Drawing.Size(245, 20);
            this.HoraEntradadateTimePicker.TabIndex = 7;
            // 
            // HoraSalidadateTimePicker
            // 
            this.HoraSalidadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.HoraSalidadateTimePicker.Location = new System.Drawing.Point(426, 188);
            this.HoraSalidadateTimePicker.Name = "HoraSalidadateTimePicker";
            this.HoraSalidadateTimePicker.ShowUpDown = true;
            this.HoraSalidadateTimePicker.Size = new System.Drawing.Size(245, 20);
            this.HoraSalidadateTimePicker.TabIndex = 9;
            this.HoraSalidadateTimePicker.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkGray;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(362, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Fecha:";
            // 
            // FechahoydateTimePicker
            // 
            this.FechahoydateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechahoydateTimePicker.Location = new System.Drawing.Point(425, 107);
            this.FechahoydateTimePicker.Name = "FechahoydateTimePicker";
            this.FechahoydateTimePicker.ShowUpDown = true;
            this.FechahoydateTimePicker.Size = new System.Drawing.Size(245, 20);
            this.FechahoydateTimePicker.TabIndex = 16;
            // 
            // FrmAsistenciaAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(682, 315);
            this.ControlBox = false;
            this.Controls.Add(this.FechahoydateTimePicker);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.HoraSalidadateTimePicker);
            this.Controls.Add(this.HoraEntradadateTimePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Registrarbutton);
            this.Controls.Add(this.Cancelarbutton);
            this.Controls.Add(this.EmpleadocomboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.ImageniconPictureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.RosyBrown;
            this.Name = "FrmAsistenciaAE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.FrmAsistenciaAE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImageniconPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox ImageniconPictureBox;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox EmpleadocomboBox;
        private System.Windows.Forms.Button Cancelarbutton;
        private System.Windows.Forms.Button Registrarbutton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DateTimePicker HoraEntradadateTimePicker;
        public System.Windows.Forms.DateTimePicker HoraSalidadateTimePicker;
        private System.Windows.Forms.DateTimePicker FechahoydateTimePicker;
        private System.Windows.Forms.Label label8;
    }
}