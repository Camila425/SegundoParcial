namespace SegundoParcial.Windows
{
    partial class FrmRealizarPago
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ImporteAPagarLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.EmpleadotextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PuestotextBox = new System.Windows.Forms.TextBox();
            this.SueldotextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ImporteAPagartextBox = new System.Windows.Forms.TextBox();
            this.DescuentotextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GuardarPagobutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ImporteAPagarLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(604, 48);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Importe a Pagar";
            // 
            // ImporteAPagarLabel
            // 
            this.ImporteAPagarLabel.BackColor = System.Drawing.Color.RosyBrown;
            this.ImporteAPagarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImporteAPagarLabel.Location = new System.Drawing.Point(2, 15);
            this.ImporteAPagarLabel.Name = "ImporteAPagarLabel";
            this.ImporteAPagarLabel.Size = new System.Drawing.Size(596, 30);
            this.ImporteAPagarLabel.TabIndex = 0;
            this.ImporteAPagarLabel.Text = "0.00";
            this.ImporteAPagarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(401, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 58);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Empleado:";
            // 
            // EmpleadotextBox
            // 
            this.EmpleadotextBox.Enabled = false;
            this.EmpleadotextBox.Location = new System.Drawing.Point(110, 29);
            this.EmpleadotextBox.Name = "EmpleadotextBox";
            this.EmpleadotextBox.ReadOnly = true;
            this.EmpleadotextBox.Size = new System.Drawing.Size(191, 23);
            this.EmpleadotextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Puesto:";
            // 
            // PuestotextBox
            // 
            this.PuestotextBox.Enabled = false;
            this.PuestotextBox.Location = new System.Drawing.Point(110, 71);
            this.PuestotextBox.Name = "PuestotextBox";
            this.PuestotextBox.ReadOnly = true;
            this.PuestotextBox.Size = new System.Drawing.Size(191, 23);
            this.PuestotextBox.TabIndex = 5;
            // 
            // SueldotextBox
            // 
            this.SueldotextBox.Enabled = false;
            this.SueldotextBox.Location = new System.Drawing.Point(423, 64);
            this.SueldotextBox.Name = "SueldotextBox";
            this.SueldotextBox.ReadOnly = true;
            this.SueldotextBox.Size = new System.Drawing.Size(128, 23);
            this.SueldotextBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(333, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha:";
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Enabled = false;
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechadateTimePicker.Location = new System.Drawing.Point(423, 25);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(128, 23);
            this.FechadateTimePicker.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(333, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sueldo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(333, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Importe A Pagar:";
            // 
            // ImporteAPagartextBox
            // 
            this.ImporteAPagartextBox.Enabled = false;
            this.ImporteAPagartextBox.Location = new System.Drawing.Point(446, 116);
            this.ImporteAPagartextBox.Name = "ImporteAPagartextBox";
            this.ImporteAPagartextBox.ReadOnly = true;
            this.ImporteAPagartextBox.Size = new System.Drawing.Size(105, 23);
            this.ImporteAPagartextBox.TabIndex = 17;
            // 
            // DescuentotextBox
            // 
            this.DescuentotextBox.Enabled = false;
            this.DescuentotextBox.Location = new System.Drawing.Point(110, 116);
            this.DescuentotextBox.Name = "DescuentotextBox";
            this.DescuentotextBox.ReadOnly = true;
            this.DescuentotextBox.Size = new System.Drawing.Size(191, 23);
            this.DescuentotextBox.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Descuento:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.DescuentotextBox);
            this.groupBox2.Controls.Add(this.ImporteAPagartextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.FechadateTimePicker);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.SueldotextBox);
            this.groupBox2.Controls.Add(this.PuestotextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.EmpleadotextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(10, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(601, 154);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle Del Pago";
            // 
            // GuardarPagobutton
            // 
            this.GuardarPagobutton.BackColor = System.Drawing.Color.RoyalBlue;
            this.GuardarPagobutton.Location = new System.Drawing.Point(151, 266);
            this.GuardarPagobutton.Name = "GuardarPagobutton";
            this.GuardarPagobutton.Size = new System.Drawing.Size(160, 58);
            this.GuardarPagobutton.TabIndex = 3;
            this.GuardarPagobutton.Text = "Registrar Pago";
            this.GuardarPagobutton.UseVisualStyleBackColor = false;
            this.GuardarPagobutton.Click += new System.EventHandler(this.GuardarPagobutton_Click);
            // 
            // FrmRealizarPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(619, 345);
            this.ControlBox = false;
            this.Controls.Add(this.GuardarPagobutton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FrmRealizarPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRealizarPago";
            this.Load += new System.EventHandler(this.FrmRealizarPago_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ImporteAPagarLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EmpleadotextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PuestotextBox;
        private System.Windows.Forms.TextBox SueldotextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ImporteAPagartextBox;
        private System.Windows.Forms.TextBox DescuentotextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button GuardarPagobutton;
    }
}