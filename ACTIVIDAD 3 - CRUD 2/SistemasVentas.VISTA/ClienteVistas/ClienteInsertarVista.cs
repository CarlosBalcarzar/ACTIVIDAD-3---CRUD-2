using SistemasVentas.BSS;
using SistemasVentas.Modelos;

namespace SistemasVentas.VISTA.ClienteVistas
{
    public partial class ClienteInsertarVista : Form
    {
        public ClienteInsertarVista()
        {
            InitializeComponent();
        }
        ClienteBss bss = new ClienteBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Clientes c = new Clientes();
            c.Nombre = textBox1.Text;
            c.Apellido = textBox2.Text;
            c.Correo = textBox3.Text;
            c.Telefono = textBox4.Text;
            c.Direccion = textBox5.Text;

            bss.InsertarClientesBss(c);
            MessageBox.Show("Se guardo correctamente la persona");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
