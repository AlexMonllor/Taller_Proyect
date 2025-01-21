namespace ExamenInterfaces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Eixir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registrarCotxeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_afegir_cotxe cotxe = new Form_afegir_cotxe();
            cotxe.ShowDialog();
        }

        private void registrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_afegir_client client = new Form_afegir_client();
            client.ShowDialog();
        }

        private void Mostar_dades_Click(object sender, EventArgs e)
        {
            Mostrar_dades mostrar = new Mostrar_dades();
            mostrar.ShowDialog();
        }
    }
}
