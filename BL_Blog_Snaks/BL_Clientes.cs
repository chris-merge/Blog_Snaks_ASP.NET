using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//refencia a dal
using DAL_Blog_Snaks;
//referencias a EN
using En_Blog_Snaks;
namespace BL_Blog_Snaks
{
   public  class BL_Clientes
    {
        //agregar Clientes
        DAL_Clientes DAL_Client = new DAL_Clientes();
        public int Agregar_Cliente(EN_Clientes pCliente)
        {
            return DAL_Client.Agregar_Clientes(pCliente);
        }
        //lista de clientes 
        public List<EN_Clientes>Lista_Cliente()
        {
            return DAL_Client.Lista_Clientes();
        }
        //modificar clientes
        public int Modificar_Clientes(EN_Clientes pCliente)
        {
            return DAL_Client.Modificar_Clientes(pCliente);
        }
        //eliminar cliente
        public int Eliminar_Cliente(EN_Clientes pCliente)
        {
            return DAL_Client.Eliminar_Clientes(pCliente);
        }
    }
}
