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
   public  class BL_Tipo_Productos
    {
        DAL_Tipo_Producto DAL_tipo = new DAL_Tipo_Producto();
        //agregar tipo de  producto
        public int Agregar_Tipo_Producto(EN_Tipo_Producto pTipo)
        {
            return DAL_tipo.Agregar_Tipo(pTipo);
        }
        //lista de tipo de producto
        public List<EN_Tipo_Producto> Lista_Tipo_Producto()
        {
            return DAL_tipo.Lista_Tipo_Productos();
        }
        //modificar Tipo de producto
        public int Modificar_Tipo_Producto(EN_Tipo_Producto pTipo)
        {
            return DAL_tipo.Eliminar_Tipo(pTipo);
        }
        public int Eliminar_Tipo_Producto(EN_Tipo_Producto pId)
        {
            return DAL_tipo.Eliminar_Tipo(pId);
        }
    }
}
