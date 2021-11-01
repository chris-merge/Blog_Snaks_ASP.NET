using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace En_Blog_Snaks
{
    public class EN_Tipo_Producto
    {
        public int Id_Tipo { get; set; }
        public string Nombre { get; set; }
        public EN_Tipo_Producto() { }
        public EN_Tipo_Producto(int pId_Tipo, string pNombre)
        {
            Id_Tipo = pId_Tipo;
            Nombre = pNombre;
        }
    }
}
