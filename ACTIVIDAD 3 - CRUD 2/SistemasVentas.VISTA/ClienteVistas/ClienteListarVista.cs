using SistemasVentas.BSS;

namespace SistemasVentas.VISTA.ClienteVistas
{
    public partial class ClienteListarVista : Form
    {
        public ClienteListarVista()
        {
            InitializeComponent();
        }
        ClienteBss bss = new ClienteBss();
        private void ClienteListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarClientesBss();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClienteInsertarVista fr = new ClienteInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarClientesBss();
            }
            dataGridView1.DataSource = bss.ListarClientesBss();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int IdClienteSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ClienteEditarVista fr = new ClienteEditarVista(IdClienteSeleccionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarClientesBss();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdClienteSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            CLienteEliminarVistas fr = new CLienteEliminarVistas(IdClienteSeleccionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarClientesBss();
            }
        }
    }
}
