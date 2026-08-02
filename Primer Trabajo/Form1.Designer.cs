namespace WinFormsApp1
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
            lstEstudiantes = new ListBox();
            chkPresente = new CheckBox();
            btnMarcar = new Button();
            btnResumen = new Button();
            txtNuevoEstudiante = new TextBox();
            btnAgregar = new Button();
            dgvResumen = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvResumen).BeginInit();
            SuspendLayout();
            // 
            // lstEstudiantes
            // 
            lstEstudiantes.FormattingEnabled = true;
            lstEstudiantes.Location = new Point(12, 59);
            lstEstudiantes.Name = "lstEstudiantes";
            lstEstudiantes.Size = new Size(190, 34);
            lstEstudiantes.TabIndex = 0;
            lstEstudiantes.SelectedIndexChanged += lstEstudiantes_SelectedIndexChanged_1;
            // 
            // chkPresente
            // 
            chkPresente.AutoSize = true;
            chkPresente.Location = new Point(208, 59);
            chkPresente.Name = "chkPresente";
            chkPresente.Size = new Size(71, 19);
            chkPresente.TabIndex = 1;
            chkPresente.Text = "Presente";
            chkPresente.UseVisualStyleBackColor = true;
            chkPresente.CheckedChanged += chkPresente_CheckedChanged;
            // 
            // btnMarcar
            // 
            btnMarcar.Location = new Point(12, 127);
            btnMarcar.Name = "btnMarcar";
            btnMarcar.Size = new Size(75, 23);
            btnMarcar.TabIndex = 2;
            btnMarcar.Text = "Registrar Estado_Click";
            btnMarcar.UseVisualStyleBackColor = true;
            btnMarcar.Click += btnMarcar_Click_1;
            // 
            // btnResumen
            // 
            btnResumen.Location = new Point(93, 127);
            btnResumen.Name = "btnResumen";
            btnResumen.Size = new Size(75, 23);
            btnResumen.TabIndex = 3;
            btnResumen.Text = "Generar Resumen";
            btnResumen.UseVisualStyleBackColor = true;
            btnResumen.Click += btnResumen_Click_1;
            // 
            // txtNuevoEstudiante
            // 
            txtNuevoEstudiante.Location = new Point(93, 186);
            txtNuevoEstudiante.Name = "txtNuevoEstudiante";
            txtNuevoEstudiante.Size = new Size(150, 23);
            txtNuevoEstudiante.TabIndex = 5;
            txtNuevoEstudiante.TextChanged += txtNuevoEstudiante_TextChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 185);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar Estudiante";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // dgvResumen
            // 
            dgvResumen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResumen.Location = new Point(263, 84);
            dgvResumen.Name = "dgvResumen";
            dgvResumen.Size = new Size(240, 150);
            dgvResumen.TabIndex = 7;
            dgvResumen.CellContentClick += dgvResumen_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvResumen);
            Controls.Add(btnAgregar);
            Controls.Add(txtNuevoEstudiante);
            Controls.Add(btnResumen);
            Controls.Add(btnMarcar);
            Controls.Add(chkPresente);
            Controls.Add(lstEstudiantes);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvResumen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstEstudiantes;
        private CheckBox chkPresente;
        private Button btnMarcar;
        private Button btnResumen;
        private TextBox txtNuevoEstudiante;
        private Button btnAgregar;
        private DataGridView dgvResumen;
    }
}
