using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//referencia a mysql
using System.Data;
using MySql.Data.MySqlClient;
//referencia de EN de tipo de producto
using En_Blog_Snaks;
namespace DAL_Blog_Snaks
{
  public   class DAL_Tipo_Producto
    {
        //metodo para crear  clientes
        public int Agregar_Tipo(EN_Tipo_Producto pTipo)
        {
            int resul = 0;
            using (MySqlConnection con = Conexion_DB.Conexion_Mysql())
            {
                con.Open();
                string sentencia = @"INSERT INTO TIPO (ID_TIPO,NOMBRE) VALUES ('{0}','{1}')";
                string mysqls = string.Format(sentencia, pTipo.Id_Tipo,pTipo.Nombre);
                MySqlCommand comando = Conexion_DB.Get_Comando(mysqls, con) as MySqlCommand;
                comando.CommandType = CommandType.Text;
                resul = comando.ExecuteNonQuery();
                con.Close();
            }
            return resul;
        }
        //metodo par leer clinetes
        public List<EN_Tipo_Producto> Lista_Tipo_Productos()
        {
            List<EN_Tipo_Producto> List_Tipo = new List<EN_Tipo_Producto>();
            using (MySqlConnection con = Conexion_DB.Conexion_Mysql())
            {
                string sentencia = "SELCT * FROM TIPO";
                MySqlCommand comando = Conexion_DB.Get_Comando(sentencia, con) as MySqlCommand;
                comando.CommandType = CommandType.Text;
                IDataReader read = comando.ExecuteReader();
                while (read.Read())
                {
                    List_Tipo.Add(new EN_Tipo_Producto(read.GetInt32(0), read.GetString(1)));
                }
            }
            return List_Tipo;
        }
        //metodo para modificar clientes
        public int Modificar_Tipo(EN_Tipo_Producto pTipo)
        {
            int resul = 0;
            using (MySqlConnection con = Conexion_DB.Conexion_Mysql())
            {
                con.Open();
                string sentencia = "UPDATE CLIENTE SET NOMBRE='{0}'";
                string mysqls = string.Format(sentencia, pTipo.Nombre);
                MySqlCommand comando = Conexion_DB.Get_Comando(mysqls, con) as MySqlCommand;
                comando.CommandType = CommandType.Text;
                resul = comando.ExecuteNonQuery();
                con.Close();
            }
            return resul;
        }
        //metodo de borrar clientes
        public int Eliminar_Tipo(EN_Tipo_Producto pTipo)
        {
            int resul = 0;
            using (MySqlConnection con = Conexion_DB.Conexion_Mysql())
            {
                string sentencia = "DELETE FROM CLIENTE WHERE='{0}'";
                string mysqls = string.Format(sentencia, pTipo.Id_Tipo);
                MySqlCommand comando = Conexion_DB.Get_Comando(mysqls, con) as MySqlCommand;
                comando.CommandType = CommandType.Text;
                resul = comando.ExecuteNonQuery();
            }
            return resul;
        }
    }
}
