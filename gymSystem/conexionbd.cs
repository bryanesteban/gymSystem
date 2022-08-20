using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
//using MySql.Data.MySqlClient;
using System.Data.Sql;
using System.Windows.Forms;

namespace gymSystem
{
    class conexionbd
    {
        SqlConnection cn;

        //private MySqlConnection conn;

        string server = "localhost";
        string database = "GymSystem";
        string user = "root";
        string password = "";
        string port = "3306";
        string sslM = "none";

        public SqlConnection sqlNewConect()
        {
            try
            {
                //cadena de conexion MySQL
                String connString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; SslMode={5}", server, port, user, password, database, sslM);
                //cadena de conexion juancarlos
                //cn = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=GymSystem;Integrated Security=false;User ID=usuarioGym;Password=Arcanjel.1722; MultipleActiveResultSets=True");
                //cadena de conexion mi compu
                cn = new SqlConnection("Server=localhost;Database=GymSystem;Integrated Security=false;User ID=usuarioGym;Password=Arcanjel.1722; MultipleActiveResultSets=True");
                //Cadena de conexion  defualt
                //cn = new SqlConnection("Data Source=localhost;Initial Catalog=master;Integrated Security=True, database=GymSystem ");
                //conversion a sqlConnection
                //cn =new SqlConnection(connString);
                //cn = new MySqlConnection(connString);

                cn.Open();
                Console.WriteLine("Conexion Valida");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conecto con la base de datos:" + ex.ToString());
            }

            return cn;
        }

        public void sqlCloseconection(SqlConnection conexionClose)
        {
            try
            {
                cn.Close();
                Console.WriteLine("Conexion Cerrada");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido cerrar la conexion:" + ex.ToString());
            }
        }

    }
}
