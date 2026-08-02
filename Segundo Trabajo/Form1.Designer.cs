namespace _2da_tarea
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
            txtValor = new TextBox();
            cboTipoConversion = new ComboBox();
            btnConvertir = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // txtValor
            // 
            txtValor.Location = new Point(32, 94);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(100, 23);
            txtValor.TabIndex = 0;
            txtValor.Text = "Valor";
            txtValor.TextChanged += txtValor_TextChanged;
            // 
            // cboTipoConversion
            // 
            cboTipoConversion.FormattingEnabled = true;
            cboTipoConversion.Items.AddRange(new object[] { "Kilómetros a Millas", "Millas a Kilómetros", "Celsius a Fahrenheit", "Fahrenheit a Celsius" });
            cboTipoConversion.Location = new Point(147, 94);
            cboTipoConversion.Name = "cboTipoConversion";
            cboTipoConversion.Size = new Size(121, 23);
            cboTipoConversion.TabIndex = 1;
            cboTipoConversion.Text = "Conversion";
            cboTipoConversion.SelectedIndexChanged += cboTipoConversion_SelectedIndexChanged;
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(32, 168);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(75, 23);
            btnConvertir.TabIndex = 2;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click_1;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(298, 102);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(64, 15);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "Resultados";
            lblResultado.Click += lblResultado_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(btnConvertir);
            Controls.Add(cboTipoConversion);
            Controls.Add(txtValor);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtValor;
        private ComboBox cboTipoConversion;
        private Button btnConvertir;
        private Label lblResultado;
    }
}
