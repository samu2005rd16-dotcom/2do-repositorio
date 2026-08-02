namespace _4ta_tarea
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNombre = new TextBox();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            btnRegistrar = new Button();
            lstClientes = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(53, 108);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(194, 23);
            txtNombre.TabIndex = 0;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(275, 108);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(196, 23);
            txtTelefono.TabIndex = 1;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(502, 108);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(191, 23);
            txtCorreo.TabIndex = 2;
            txtCorreo.TextChanged += txtCorreo_TextChanged;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(53, 199);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 3;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click_1;
            // 
            // lstClientes
            // 
            lstClientes.FormattingEnabled = true;
            lstClientes.Location = new Point(225, 199);
            lstClientes.Name = "lstClientes";
            lstClientes.Size = new Size(446, 109);
            lstClientes.TabIndex = 4;
            lstClientes.SelectedIndexChanged += lstClientes_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 90);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 5;
            label1.Text = "Ingrese el nombre";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(275, 90);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 6;
            label2.Text = "Ingrese el telefono";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(502, 90);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 7;
            label3.Text = "Ingrese el correo";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstClientes);
            Controls.Add(btnRegistrar);
            Controls.Add(txtCorreo);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private Button btnRegistrar;
        private ListBox lstClientes;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
