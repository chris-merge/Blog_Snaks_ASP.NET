using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//refencias a la libreria de mysql
using System.Data;
using MySql.Data.MySqlClient;
//referencia a la capa de Entidades de negocios 
using En_Blog_Snaks;

namespace DAL_Blog_Snaks
{
   public  class DAL_Clientes
    {
        //metodo para crear  clientes
        public int Agregar_Clientes(EN_Clientes pClientes)
        {
            int resul = 0;
            using(MySqlConnection con = Conexion_DB.Conexion_Mysql())
            {
                con.Open();
                string sentencia = @"INSERT INTO CLIENTE (NOMBRE,DIRECCION,ID_PRODUCTO,TOTAL_PAGAR) VALUES ('{0}','{1}','{2}')";
                string mysqls = string.Format(sentencia, pClientes.Nombre_cliente, pClientes.Direccion_cliente, pClientes.Id_producto, pClientes.total_pagar);
                MySqlCommand comando = Conexion_DB.Get_Comando(mysqls, con) as MySqlCommand;
                comando.CommandType = CommandType.Text;
                resul = comando.ExecuteNonQuery();
                con.Close();
            }
            return resul;
        }
        //metodo par leer clinetes
        public List<EN_Clientes> Lista_Clientes()
        {
            List<EN_Clientes> List_clientes = new List<EN_Clientes>();
            using(MySqlConnection con = Conexion_DB.Conexion_Mysql())
            {
                string sentencia = "SELCT * FROM CLIENTE";
                MySqlCommand comando = Conexion_DB.Get_Comando(sentencia, con) as MySqlCommand;
                comando.CommandType = CommandType.Text;
                IDataReader read = comando.ExecuteReader();
                while(read.Read())
                {
                    List_clientes.Add(new EN_Clientes(read.GetInt32(0),read.GetString(1),read.GetString(2),read.GetInt32(3),read.GetFloat(4)));
                }
            }
            return List_clientes;
        }
        //metodo para modificar clientes
        public int Modificar_Clientes(EN_Clientes pClientes)
        {
            int resul = 0;
            using(MySqlConnection con = Conexion_DB.Conexion_Mysql())
            {
                con.Open();
                string sentencia = "UPDATE CLIENTE SET NOMBRE='{0}',DIRECCION='{1}',ID='{2}'_PRODUCTO='{3}',TOTAL_PAGAR='{4}'";
                string mysqls = string.Format(sentencia, pClientes.Nombre_cliente, pClientes.Direccion_cliente, pClientes.Id_producto, pClientes.total_pagar);
                MySqlCommand comando = Conexion_DB.Get_Comando(mysqls,con) as MySqlCommand;
                comando.CommandType = CommandType.Text;
                resul = comando.ExecuteNonQuery();
                con.Close();
            }
            return resul;
        }
        //metodo de borrar clientes
        public int Eliminar_Clientes(EN_Clientes pClientes)
        {
            int resul = 0;
            using (MySqlConnection con =Conexion_DB.Conexion_Mysql())
            {
                string sentencia = "DELETE FROM CLIENTE WHERE='{0}'";
                string mysqls = string.Format(sentencia,pClientes.ID_Cliente);
                MySqlCommand comando = Conexion_DB.Get_Comando(mysqls, con) as MySqlCommand;
                comando.CommandType = CommandType.Text;
                resul = comando.ExecuteNonQuery();
            }
            return resul;
        }
        
    }
}
