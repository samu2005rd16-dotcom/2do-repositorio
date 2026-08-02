namespace _4ta_tarea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string correo = txtCorreo.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Por favor, ingresa el nombre del cliente.", "Campo Obligatorio",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(telefono))
            {
                MessageBox.Show("Por favor, ingresa el número de teléfono.", "Campo Obligatorio",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono.Focus();
                return;
            }

            if (!long.TryParse(telefono, out _))
            {
                MessageBox.Show("El teléfono debe contener únicamente números.", "Formato Incorrecto",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(correo))
            {
                MessageBox.Show("Por favor, ingresa el correo o dato adicional del cliente.", "Campo Obligatorio",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.Focus();
                return;
            }

            if (!correo.Contains("@") || !correo.Contains("."))
            {
                MessageBox.Show("Asegúrate de ingresar una dirección de correo válida (ejemplo@´dominio´.com).", "Formato Incorrecto",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.Focus();
                return;
            }

 
            string registroCliente = $"Cliente: {nombre} | Tel: {telefono} | Correo: {correo}";
            lstClientes.Items.Add(registroCliente);

            LimpiarFormulario();

            MessageBox.Show("Cliente registrado exitosamente.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtNombre.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
