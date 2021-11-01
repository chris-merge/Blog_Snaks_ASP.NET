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
    public class BL_Producto
    {
        //metodo para agregar de producto
        DAL_Producto DAL_Produc = new DAL_Producto();
        public int Agregar_Productos(EN_Productos pProductos)
        {
            return DAL_Produc.Agregar_Producto(pProductos);
        }
        //metodo para ver el listado de producto
        public List<EN_Productos> Lista_Producto()
        {
            return DAL_Produc.Lista_Producto();
        }
        //borrar un producto
        public int Eliminar_Producto(EN_Productos pId)
        {
            return DAL_Produc.Eliminar(pId);
        }

    }
}
