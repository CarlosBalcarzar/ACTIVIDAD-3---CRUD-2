using SistemasVentas.DAL;
using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.BSS
{
    public class ClienteBss
    {
        ClienteDal dal = new ClienteDal();
        public DataTable ListarClientesBss()
        {
            return dal.ListarClientesDal();
        }
        public void InsertarClientesBss(Clientes clientes)
        {
            dal.InsertarClientesDal(clientes);
        }
        public Clientes ObtenerIdBss(int id)
        {
            return dal.ObtenerClienteId(id);
        }
        public void EditarClienteBss(Clientes c)
        {
            dal.EditarClienteDal(c);
        }

        public void EliminarClienteBss(int id)
        {
            dal.EliminarClienteDal(id);
        }
    }
}
