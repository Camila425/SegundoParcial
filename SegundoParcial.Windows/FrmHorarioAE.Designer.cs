namespace SegundoParcial.Windows
{
    partial class FrmHorarioAE
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
            this.HoraIniciodateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.HoraSalidadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Cancelarbutton = new System.Windows.Forms.Button();
            this.OKbutton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.HorariocomboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Turno:";
            // 
            // HoraIniciodateTimePicker
            // 
            this.HoraIniciodateTimePicker.CustomFormat = "";
            this.HoraIniciodateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.HoraIniciodateTimePicker.Location = new System.Drawing.Point(79, 85);
            this.HoraIniciodateTimePicker.Name = "HoraIniciodateTimePicker";
            this.HoraIniciodateTimePicker.ShowUpDown = true;
            this.HoraIniciodateTimePicker.Size = new System.Drawing.Size(225, 20);
            this.HoraIniciodateTimePicker.TabIndex = 2;
            // 
            // HoraSalidadateTimePicker
            // 
            this.HoraSalidadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.HoraSalidadateTimePicker.Location = new System.Drawing.Point(79, 128);
            this.HoraSalidadateTimePicker.Name = "HoraSalidadateTimePicker";
            this.HoraSalidadateTimePicker.ShowUpDown = true;
            this.HoraSalidadateTimePicker.Size = new System.Drawing.Size(225, 20);
            this.HoraSalidadateTimePicker.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hora Inicio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hora Salida:";
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.Image = global::SegundoParcial.Windows.Properties.Resources.cancel_64px2;
            this.Cancelarbutton.Location = new System.Drawing.Point(257, 199);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(145, 56);
            this.Cancelarbutton.TabIndex = 7;
            this.Cancelarbutton.Text = "Cancelar";
            this.Cancelarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Cancelarbutton.UseVisualStyleBackColor = true;
            this.Cancelarbutton.Click += new System.EventHandler(this.Cancelarbutton_Click);
            // 
            // OKbutton
            // 
            this.OKbutton.Image = global::SegundoParcial.Windows.Properties.Resources.ok_36px1;
            this.OKbutton.Location = new System.Drawing.Point(95, 199);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(129, 56);
            this.OKbutton.TabIndex = 6;
            this.OKbutton.Text = "OK";
            this.OKbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // HorariocomboBox
            // 
            this.HorariocomboBox.BackColor = System.Drawing.SystemColors.Control;
            this.HorariocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HorariocomboBox.FormattingEnabled = true;
            this.HorariocomboBox.Location = new System.Drawing.Point(79, 38);
            this.HorariocomboBox.Name = "HorariocomboBox";
            this.HorariocomboBox.Size = new System.Drawing.Size(399, 21);
            this.HorariocomboBox.TabIndex = 10;
            // 
            // FrmHorarioAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(500, 275);
            this.ControlBox = false;
            this.Controls.Add(this.HorariocomboBox);
            this.Controls.Add(this.Cancelarbutton);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HoraSalidadateTimePicker);
            this.Controls.Add(this.HoraIniciodateTimePicker);
            this.Controls.Add(this.label1);
            this.Name = "FrmHorarioAE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Horarios";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker HoraIniciodateTimePicker;
        private System.Windows.Forms.DateTimePicker HoraSalidadateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.Button Cancelarbutton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox HorariocomboBox;
    }
}