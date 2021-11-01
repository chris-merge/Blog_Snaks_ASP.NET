using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace En_Blog_Snaks
{
    public class EN_Clientes
    {
        public int ID_Cliente { get; set; }
        public string Nombre_cliente { get; set; }
        public string Direccion_cliente { get; set; }
        public int Id_producto { get; set; }
        public float total_pagar { get; set; }
        //constructor vacio
        public EN_Clientes() { }
        //Constructor con parametros
        public EN_Clientes(int pCliente, string pNombre_cliente,string pDireccion_cliente,int pId_Producto,float pTotal_pagar)
        {
            ID_Cliente = pCliente;
            Nombre_cliente = pNombre_cliente;
            Direccion_cliente = pDireccion_cliente;
            Id_producto = pId_Producto;
            total_pagar = pTotal_pagar;
        }
    }
}
