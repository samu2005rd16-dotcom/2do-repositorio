namespace _2da_tarea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
           
            bool esNumero = decimal.TryParse(txtValor.Text, out decimal valor);

            if (!esNumero)
            {
                MessageBox.Show("Por favor, ingresa un valor numérico válido.", "Error de entrada",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValor.Focus();
                return;
            }

           
            if (cboTipoConversion.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona un tipo de conversión de la lista.", "Atención",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboTipoConversion.Focus();
                return;
            }

          
            string opcion = cboTipoConversion.SelectedItem.ToString();
            decimal resultado = 0;
            string unidad = "";

            switch (opcion)
            {
                case "Kilómetros a Millas":
                    resultado = valor * 0.621371m;
                    unidad = "millas";
                    break;

                case "Millas a Kilómetros":
                    resultado = valor / 0.621371m;
                    unidad = "km";
                    break;

                case "Celsius a Fahrenheit":
                    resultado = (valor * 9 / 5) + 32;
                    unidad = "°F";
                    break;

                case "Fahrenheit a Celsius":
                    resultado = (valor - 32) * 5 / 9;
                    unidad = "°C";
                    break;
            }

            
            lblResultado.Text = $"Resultado: {resultado:N2} {unidad}";
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboTipoConversion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void btnConvertir_Click_1(object sender, EventArgs e)
        {

        }
    }
}
