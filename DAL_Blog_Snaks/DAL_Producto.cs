using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
//referencia a la entidad de negocio
using  En_Blog_Snaks;
//referencia a la conexion de la DB

namespace DAL_Blog_Snaks
{
    public class DAL_Producto
    {
        //metodo de agregar producto
        public int Agregar_Producto(EN_Productos pProducto)
        {
            int result = 0;
            using (MySqlConnection con = Conexion_DB.Conexion_Mysql())
            {
                con.Open();
                string sentencia = @"INSERT INTO PRODUCTO(NOMBRE,DESCRIPCION,PRECIO,ID_TIPO) VALUES ('{0}','{1}','{2}','{3}','{4}')";
                string mysqls = string.Format(sentencia, pProducto.Nombre_Producto, pProducto.Descripcion, pProducto.Precio, pProducto.ID_producto);
                MySqlCommand comando = Conexion_DB.Get_Comando(mysqls, con) as MySqlCommand;
                comando.CommandType = CommandType.Text;
                result = comando.ExecuteNonQuery();
                con.Close();
            }
            return result;
        }
        //metodo para leer los datos
        public List<EN_Productos> Lista_Producto( )
        {
            List<EN_Productos> List_Produc = new List<EN_Productos>();
            using (MySqlConnection con = Conexion_DB.Conexion_Mysql())
            {
                con.Open();
                string mysqls = "SELECT * FROM PRODUCTO";
                MySqlCommand comando = Conexion_DB.Get_Comando(mysqls, con) as MySqlCommand;
                comando.CommandType = CommandType.Text;
                IDataReader read = comando.ExecuteReader();
                while(read.Read())
                {
                    List_Produc.Add(new EN_Productos(read.GetInt32(0), read.GetString(1), read.GetString(2), read.GetDecimal(3), read.GetInt32(4)));

                }
                con.Close();
            }
            return List_Produc;
        }
        //metodo para modificar
        public int Modificar_Producto(EN_Productos pProducto)
        {
            int result = 0;
            using (MySqlConnection con = Conexion_DB.Conexion_Mysql())
            {
                con.Open();
                string sentencia = @"UPDATE PRODUCTO SET NOMBRE='{0}',DESCRIPCION='{1}',PRECIO='{2}',ID_TIPO='{3}' ";
                string mysqls = string.Format(sentencia, pProducto.Nombre_Producto, pProducto.Descripcion, pProducto.Precio, pProducto.Id_Tipo);
                MySqlCommand comando = Conexion_DB.Get_Comando(mysqls, con) as MySqlCommand;
                comando.CommandType = CommandType.Text;
                result = comando.ExecuteNonQuery();
                con.Close();
            }
            return result;
        }
        //metodo de eliminar producto
        public int Eliminar(EN_Productos pProducto)
        {
            int result = 0;
            using(MySqlConnection con = Conexion_DB.Conexion_Mysql())
            {
                con.Open();
                string sentencia = @"DELETE FROM PRODUCTO WHERE={0}";
                string mysqls = string.Format(sentencia, pProducto.ID_producto);
                MySqlCommand comando = Conexion_DB.Get_Comando(mysqls, con) as MySqlCommand;
                comando.CommandType = CommandType.Text;
                result = comando.ExecuteNonQuery();
                con.Close();
            }
            return result;
        }
    }
}
