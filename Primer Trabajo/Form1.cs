namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
       
        private Dictionary<string, bool> controlAsistencia = new Dictionary<string, bool>();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNuevoEstudiante.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre)) return;

            if (!controlAsistencia.ContainsKey(nombre))
            {
                lstEstudiantes.Items.Add(nombre);
                controlAsistencia[nombre] = false;
                txtNuevoEstudiante.Clear();
                txtNuevoEstudiante.Focus();
            }
        }

        public Form1()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form1_Load);
            this.btnMarcar.Click += new System.EventHandler(this.btnMarcar_Click);
            this.btnResumen.Click += new System.EventHandler(this.btnResumen_Click);
            this.lstEstudiantes.SelectedIndexChanged += new System.EventHandler(this.lstEstudiantes_SelectedIndexChanged);
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            

            
            this.btnResumen.Click += new System.EventHandler(this.btnResumen_Click);

            this.lstEstudiantes.SelectedIndexChanged += new System.EventHandler(this.lstEstudiantes_SelectedIndexChanged);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
          
            string[] estudiantes = { };

            lstEstudiantes.Items.Clear();

            
            foreach (string alumno in estudiantes)
            {
                lstEstudiantes.Items.Add(alumno);
                controlAsistencia[alumno] = false;
            }

            
            if (lstEstudiantes.Items.Count > 0)
            {
                lstEstudiantes.SelectedIndex = 0;
            }
        }

        
        private void lstEstudiantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstEstudiantes.SelectedItem != null)
            {
                string alumnoSeleccionado = lstEstudiantes.SelectedItem.ToString();
                chkPresente.Checked = controlAsistencia[alumnoSeleccionado];
            }
        }

        
        private void btnMarcar_Click(object sender, EventArgs e)
        {
            if (lstEstudiantes.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona un estudiante de la lista.", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string alumnoSeleccionado = lstEstudiantes.SelectedItem.ToString();
            controlAsistencia[alumnoSeleccionado] = chkPresente.Checked;

            string estadoText = chkPresente.Checked ? "Presente" : "Ausente";
            MessageBox.Show($"Se registró a {alumnoSeleccionado} como: {estadoText}", "Asistencia Registrada",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnResumen_Click(object sender, EventArgs e)
        {
            int totalPresentes = 0;
            int totalAusentes = 0;

           

            foreach (KeyValuePair<string, bool> registro in controlAsistencia)
            {
             
                if (registro.Value)
                    totalPresentes++;
                else
                    totalAusentes++;
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {


        }

        private void btnMarcar_Click_1(object sender, EventArgs e)
        {

        }

        private void lstEstudiantes_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            if (controlAsistencia.Count == 0) return;

            dgvResumen.Columns.Clear();
            dgvResumen.Rows.Clear();

            dgvResumen.Columns.Add("colEstudiante", "Estudiante");
            dgvResumen.Columns.Add("colEstado", "Estado");
            dgvResumen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



        }

        private void chkPresente_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtResumen_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnResumen_Click_1(object sender, EventArgs e)
        {
            {
                if (controlAsistencia.Count == 0) return;

           
                dgvResumen.Columns.Clear();
                dgvResumen.Rows.Clear();

                
                dgvResumen.Columns.Add("colEstudiante", "Estudiante");
                dgvResumen.Columns.Add("colEstado", "Estado");

               
                dgvResumen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


                foreach (KeyValuePair<string, bool> registro in controlAsistencia)
                {
                    {
                        string estado = registro.Value ? "PRESENTE" : "AUSENTE";


                        dgvResumen.Rows.Add(registro.Key, estado);
                    }
                }
                
            }

        }

        private void txtNuevoEstudiante_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {


        }


        private void dgvResumen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }

}