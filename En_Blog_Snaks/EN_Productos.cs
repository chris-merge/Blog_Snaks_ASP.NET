using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace En_Blog_Snaks
{
  public   class EN_Productos
    {
        public int ID_producto { get; set; }
        public string Nombre_Producto { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        //foreingkey
        public int Id_Tipo   { get; set; }
        //contructor vascio
        public EN_Productos() { }
        //construcor con parametros
        public EN_Productos (int pId_producto, string pNomnre_producto, string pDescripcion, decimal pPrecio, int pId_Tipo)
        {
            ID_producto = pId_producto;
            Nombre_Producto = pNomnre_producto;
            Descripcion = pDescripcion;
            Precio = pPrecio;
            Id_Tipo = pId_Tipo;
        }
    }
}
