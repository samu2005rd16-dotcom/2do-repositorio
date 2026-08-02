namespace _3ra_tarea
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
            cboProductos = new ComboBox();
            txtCantidad = new TextBox();
            rdbEfectivo = new RadioButton();
            rdbTarjeta = new RadioButton();
            btnCalcular = new Button();
            lblTotal = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // cboProductos
            // 
            cboProductos.FormattingEnabled = true;
            cboProductos.Items.AddRange(new object[] { "Arroz selecto (lb) - 45.00", "Habichuelas rojas (lb) - 60.00", "Aceite vegetal (1L) - 180.00", "Salami induveca (lb) - 150.00" });
            cboProductos.Location = new Point(12, 85);
            cboProductos.Name = "cboProductos";
            cboProductos.Size = new Size(187, 23);
            cboProductos.TabIndex = 0;
            cboProductos.Text = "Ingrese el producto a comprar";
            cboProductos.SelectedIndexChanged += cboProductos_SelectedIndexChanged;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(226, 88);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(152, 23);
            txtCantidad.TabIndex = 1;
            txtCantidad.Text = "Cantidad del producto";
            txtCantidad.TextChanged += txtCantidad_TextChanged;
            // 
            // rdbEfectivo
            // 
            rdbEfectivo.AutoSize = true;
            rdbEfectivo.Location = new Point(256, 123);
            rdbEfectivo.Name = "rdbEfectivo";
            rdbEfectivo.Size = new Size(113, 19);
            rdbEfectivo.TabIndex = 2;
            rdbEfectivo.TabStop = true;
            rdbEfectivo.Text = "Pago en efectivo";
            rdbEfectivo.UseVisualStyleBackColor = true;
            rdbEfectivo.CheckedChanged += rdbEfectivo_CheckedChanged;
            // 
            // rdbTarjeta
            // 
            rdbTarjeta.AutoSize = true;
            rdbTarjeta.Location = new Point(256, 159);
            rdbTarjeta.Name = "rdbTarjeta";
            rdbTarjeta.Size = new Size(104, 19);
            rdbTarjeta.TabIndex = 3;
            rdbTarjeta.TabStop = true;
            rdbTarjeta.Text = "Pago en tarjeta";
            rdbTarjeta.UseVisualStyleBackColor = true;
            rdbTarjeta.CheckedChanged += rdbTarjeta_CheckedChanged;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(12, 123);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click_1;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(405, 88);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(75, 15);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Total a pagar";
            lblTotal.Click += lblTotal_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(226, 70);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 7;
            label2.Text = "Ingrese la cantidad ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTotal);
            Controls.Add(btnCalcular);
            Controls.Add(rdbTarjeta);
            Controls.Add(rdbEfectivo);
            Controls.Add(txtCantidad);
            Controls.Add(cboProductos);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboProductos;
        private TextBox txtCantidad;
        private RadioButton rdbEfectivo;
        private RadioButton rdbTarjeta;
        private Button btnCalcular;
        private Label lblTotal;
        private Label label2;
    }
}
