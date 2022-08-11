namespace ControlMultasTransito
{
    public partial class frmMultas : Form
    {
        public frmMultas()
        {
            InitializeComponent();
        }

        private void frmMultas_Load(object sender, EventArgs e)
        {
            lblfecha.Text = DateTime.Today.Date.ToShortDateString();
            lblhora.Text = DateTime.Now.ToShortTimeString();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            //Capturando los Datos
            string placa = txtplaca.Text;
            double velocidad = double.Parse(txtvelocidad.Text);
            DateTime fecha = DateTime.Parse(lblhora.Text);
            DateTime hora = DateTime.Parse(lblhora.Text);

            // Procesando
            double multa = 0;
            if (velocidad <= 70)
                multa = 0;
            else if (velocidad > 70 && velocidad <= 90)
                multa = 120;
            else if (velocidad > 90 && velocidad >= 100)
                multa = 240;
            else if (velocidad > 100)
                multa = 350;

            //Imprimiendo los Resultados
            ListViewItem fila = new ListViewItem(placa);
            fila.SubItems.Add(lblfecha.Text);
            fila.SubItems.Add(lblhora.Text);
            fila.SubItems.Add(velocidad.ToString("0.00");
            fila.SubItems.Add(multa.ToString("C"));
            lvmultas.Items.Add(fila);
        }

        ListViewItem item;

        private void lvmultas_MouseClick(object sender, MouseEventArgs e)
        {
            item = lvmultas.GetItemAt(e.X, e.Y);
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if(item != null)
            {
                lvmultas.Items.Remove(item);
                MessageBox.Show("Debe seleccionar una multa de la lista");
            }
        }

    }
}