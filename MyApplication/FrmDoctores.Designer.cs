namespace MyApplication
{
    partial class FrmDoctores
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
            txtApellido = new TextBox();
            label5 = new Label();
            txtEdad = new TextBox();
            label4 = new Label();
            txtCedula = new TextBox();
            label3 = new Label();
            txtTelefono = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(332, 134);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(213, 27);
            txtApellido.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(256, 141);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 20;
            label5.Text = "Apellido";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(332, 280);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(213, 27);
            txtEdad.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(256, 287);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 18;
            label4.Text = "Edad";
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(332, 227);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(213, 27);
            txtCedula.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(256, 234);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 16;
            label3.Text = "Cedula";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(332, 176);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(213, 27);
            txtTelefono.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(256, 183);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 14;
            label2.Text = "Telefono";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(332, 87);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(213, 27);
            txtNombre.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(256, 94);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 12;
            label1.Text = "Nombre";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(256, 335);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FrmDoctores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtApellido);
            Controls.Add(label5);
            Controls.Add(txtEdad);
            Controls.Add(label4);
            Controls.Add(txtCedula);
            Controls.Add(label3);
            Controls.Add(txtTelefono);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(btnGuardar);
            Name = "FrmDoctores";
            Text = "FrmDoctores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtApellido;
        private Label label5;
        private TextBox txtEdad;
        private Label label4;
        private TextBox txtCedula;
        private Label label3;
        private TextBox txtTelefono;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
        private Button btnGuardar;
    }
}