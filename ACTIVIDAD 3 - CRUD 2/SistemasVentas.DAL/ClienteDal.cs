using SistemasVentas.Modelos;
using System.Data;

namespace SistemasVentas.DAL
{
    public class ClienteDal
    {
        public DataTable ListarClientesDal()
        {
            string consulta = "select * from Clientes";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarClientesDal(Clientes Clientes)
        {
            string consulta = $"INSERT INTO Clientes VALUES('{Clientes.Nombre}', '{Clientes.Apellido}', '{Clientes.Correo}', '{Clientes.Telefono}', '{Clientes.Direccion}')";

            conexion.Ejecutar(consulta);
        }
        public Clientes ObtenerClienteId(int id)
        {
            string consulta = "select * from Clientes where idCliente=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Clientes c = new Clientes();
            if (tabla.Rows.Count > 0)
            {
                c.IdCliente = Convert.ToInt32(tabla.Rows[0]["IdCliente"]);
                c.Nombre = tabla.Rows[0]["nombre"].ToString();
                c.Apellido = tabla.Rows[0]["apellido"].ToString();
                c.Correo = tabla.Rows[0]["CorreoElectronico"].ToString();
                c.Telefono = tabla.Rows[0]["Telefono"].ToString();
                c.Direccion = tabla.Rows[0]["Direccion"].ToString();
            }
            return c;
        }
        public void EditarClienteDal(Clientes c)
        {
            string consulta = "update Clientes set nombre='" + c.Nombre + "'," +
                                                 "apellido='" + c.Apellido + "'," +
                                                 "CorreoElectronico='" + c.Correo + "'," +
                                                 "Telefono='" + c.Telefono + "'," +
                                                 "Direccion='" + c.Direccion + "' " +
                               "where IdCliente=" + c.IdCliente;
            conexion.Ejecutar(consulta);
        }

        public void EliminarClienteDal(int id)
        {
            string consulta = "delete from Clientes where IdCliente=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
