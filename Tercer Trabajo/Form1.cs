namespace _3ra_tarea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            if (txtCantidad.Text == "Cantidad del producto")
            {
                txtCantidad.Text = "";
            }

         
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);

            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
        }

 
        private void btnCalcular_Click(object sender, EventArgs e)
        {
         
            if (cboProductos.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona un producto del menú.", "Atención",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboProductos.Focus();
                return;
            }

        
            bool esCantidadValida = int.TryParse(txtCantidad.Text, out int cantidad);

            if (!esCantidadValida || cantidad <= 0)
            {
                MessageBox.Show("Ingresa una cantidad entera válida mayor a 0.", "Atención",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCantidad.Focus();
                return;
            }

          
            if (!rdbEfectivo.Checked && !rdbTarjeta.Checked)
            {
                MessageBox.Show("Por favor, selecciona un método de pago (Efectivo o Tarjeta).", "Atención",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

         
            string seleccion = cboProductos.SelectedItem.ToString();
            decimal precioUnitario = 0;

            if (seleccion.Contains("45.00")) precioUnitario = 45.00m;
            else if (seleccion.Contains("60.00")) precioUnitario = 60.00m;
            else if (seleccion.Contains("180.00")) precioUnitario = 180.00m;
            else if (seleccion.Contains("150.00")) precioUnitario = 150.00m;

            decimal subtotal = precioUnitario * cantidad;
            string metodoPago = rdbEfectivo.Checked ? "Efectivo" : "Tarjeta";


            decimal recargo = rdbTarjeta.Checked ? subtotal * 0.05m : 0m;
            decimal totalFinal = subtotal + recargo;

  
            if (recargo > 0)
            {
                lblTotal.Text = $"Total: RD$ {totalFinal:N2} (Incluye 5% recargo tarjeta - Pago: {metodoPago})";
            }
            else
            {
                lblTotal.Text = $"Total: RD$ {totalFinal:N2} (Pago: {metodoPago})";
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {

        }

        private void rdbEfectivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbTarjeta_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
