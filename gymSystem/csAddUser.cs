using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace gymSystem
{
    class csAddUser
    {
        conexionbd conexionDataBasse = new conexionbd();
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader sqlDR;
        DataTable dt;
        SqlDataAdapter da;
        String Cedula, Nombres, Apellidos, Telefono, Direccion;
        String ID;
       

        public void searchClient(String word, DataGridView dgvSearchClient)
        {
            
            try
            {
                dgvSearchClient.Rows.Clear();
                cn = conexionDataBasse.sqlNewConect();
                cmd =new SqlCommand( "SELECT * FROM CLIENTE WHERE (CLIIDENTIFICACION LIKE '" + word.ToString() + "' or CLINOMBRE LIKE '" + word.ToString() + "' or CLISEGUNDONOMBRE LIKE '" + word.ToString() + "' or CLIAPELLIDOPATERNO LIKE '" + word.ToString() + "' or CLIAPELLIDOMATERNO LIKE '" + word.ToString() + "') AND CLIENABLE LIKE 1 ", cn);
                sqlDR = cmd.ExecuteReader();
                
                while (sqlDR.Read())
                {
                    ID = sqlDR.GetDecimal(0).ToString();
                    Cedula = sqlDR.GetString(1);
                    Nombres = sqlDR.GetString(2)+" "+sqlDR.GetString(3);
                    Apellidos = sqlDR.GetString(4) + " " + sqlDR.GetString(5);
                    Telefono = sqlDR.GetString(8);
                    Direccion = sqlDR.GetString(9);
                    dgvSearchClient.Rows.Add(ID, Cedula, Nombres, Apellidos, Telefono, Direccion);
                }
                dgvSearchClient.Columns["IDCLIENTE"].Visible = false;
                dgvSearchClient.ClearSelection();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void fillClient(DataGridView dgvSearchClient)
        {

            try
            {
                dgvSearchClient.Rows.Clear();
                cn = conexionDataBasse.sqlNewConect();
                cmd = new SqlCommand("SELECT * FROM CLIENTE WHERE  CLIENABLE = 1 ", cn);
                sqlDR = cmd.ExecuteReader();
                dgvSearchClient.Columns.Add("IDCLIENTE", "ID");
                dgvSearchClient.Columns.Add("CLIIDENTIFICACION","Cedula");
                dgvSearchClient.Columns.Add("ClINOMBRES","Nombres");
                dgvSearchClient.Columns.Add("CLIAPELLIDOS","Apellidos");
                dgvSearchClient.Columns.Add("CLITELEFONO","Telefono");
                dgvSearchClient.Columns.Add("CLIDIRECCION","Direccion");
                while (sqlDR.Read())
                {
                    ID = sqlDR.GetDecimal(0).ToString();
                    Cedula = sqlDR.GetString(1);
                    Nombres = sqlDR.GetString(2)+ " " +sqlDR.GetString(3);
                    Apellidos = sqlDR.GetString(4)+ " " +sqlDR.GetString(5);
                    Telefono = sqlDR.GetString(8);
                    Direccion = sqlDR.GetString(9);
                    dgvSearchClient.Rows.Add(ID, Cedula, Nombres, Apellidos, Telefono, Direccion);
                }
                dgvSearchClient.Columns["IDCLIENTE"].Visible = false;
                dgvSearchClient.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




    }
}
