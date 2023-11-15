namespace SegundoParcial.Windows
{
    partial class FrmBuscarEmpleado
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
            this.EmpleadocomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cancelarbutton = new System.Windows.Forms.Button();
            this.OKbutton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // EmpleadocomboBox
            // 
            this.EmpleadocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EmpleadocomboBox.FormattingEnabled = true;
            this.EmpleadocomboBox.Location = new System.Drawing.Point(88, 32);
            this.EmpleadocomboBox.Name = "EmpleadocomboBox";
            this.EmpleadocomboBox.Size = new System.Drawing.Size(329, 21);
            this.EmpleadocomboBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Empleado:";
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.Image = global::SegundoParcial.Windows.Properties.Resources.cancel_64px5;
            this.Cancelarbutton.Location = new System.Drawing.Point(243, 127);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(139, 63);
            this.Cancelarbutton.TabIndex = 7;
            this.Cancelarbutton.Text = "Cancelar";
            this.Cancelarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Cancelarbutton.UseVisualStyleBackColor = true;
            this.Cancelarbutton.Click += new System.EventHandler(this.Cancelarbutton_Click);
            // 
            // OKbutton
            // 
            this.OKbutton.Image = global::SegundoParcial.Windows.Properties.Resources.ok_36px3;
            this.OKbutton.Location = new System.Drawing.Point(58, 127);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(139, 63);
            this.OKbutton.TabIndex = 6;
            this.OKbutton.Text = "Ok";
            this.OKbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmBuscarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 226);
            this.ControlBox = false;
            this.Controls.Add(this.EmpleadocomboBox);
            this.Controls.Add(this.Cancelarbutton);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.label1);
            this.Name = "FrmBuscarEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBuscarEmpleado";
            this.Load += new System.EventHandler(this.FrmBuscarEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox EmpleadocomboBox;
        private System.Windows.Forms.Button Cancelarbutton;
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}