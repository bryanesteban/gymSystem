using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Windows.Forms;
using System.Data;
namespace gymSystem
{
    
    class cSTypeMemberShip
    {
        conexionbd conexionDataBase = new conexionbd();
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;
        
        //inicio de la conexion con la base de datos
        public cSTypeMemberShip()
        {

        }

        //funcion que carga toda la lista de tipos de Memebresias
        public void ChargeTypeMembership(DataGridView dgvClient)
        {
            cn = conexionDataBase.sqlNewConect();
            try
            {

                da = new SqlDataAdapter("Select * from membresiaTipo WHERE TIPMEMBERSHIPENABLE = '1' ", cn);
                dgvClient = fillAndConfigurationDataAdapter(da, dgvClient);

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo Cargar los Usuarios ,Error:" + ex.ToString());
            }

        }

        //funcion que configura la lista de usuarios en el datagridview
        public DataGridView fillAndConfigurationDataAdapter(SqlDataAdapter da, DataGridView dgvClient)
        {
            da.TableMappings.Add("membresiaTipo", "DataTypeMembership");
            da.TableMappings["membresiaTipo"].ColumnMappings.Add("IDTIPOMEM", "ID");
            da.TableMappings["membresiaTipo"].ColumnMappings.Add("TIPNOMBRE", "Nombre");
            da.TableMappings["membresiaTipo"].ColumnMappings.Add("TIPDIAS", "Dias");
            da.TableMappings["membresiaTipo"].ColumnMappings.Add("TIPCOSTO", "Precio(Dolares)");
            dt = new DataTable("DataTypeMembership");

            da.Fill(dt);
            dgvClient.DataSource = dt;
            dgvClient.Columns["ID"].Visible = false;
            dgvClient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClient.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


            return dgvClient;
        }


        //Insertar nuevo tipo de membresia en la base de datos, que consta de el nombre de la membresia, la cantidad de dias y su precio
        public string insertTypeMembership(string nameTypeMembership, string typeDays, string typePrize, DataGridView dgvTypeMembership)
        {
            cn = conexionDataBase.sqlNewConect();
            string salida = "Se inserto Correctamnete";

            try
            {
                cmd = new SqlCommand("Insert into MEMBRESIATIPO(tipNombre,tipDias,tipCosto,tipMembershipEnable) values" +
                    "('" + nameTypeMembership + "','" + typeDays + "','" + typePrize +"', '1')", cn);
                cmd.ExecuteNonQuery();
                ChargeTypeMembership(dgvTypeMembership);
            }
            catch (Exception ex)
            {
                salida = "No se ingreseo : " + ex.ToString();
            }
            return salida;

        }

        // LLenar Ventana de modificar desde el dataGrid

        public void FillTextBoxModifyTypeMembership(String id, TextBox txtNameMembership, TextBox txtTipDays, TextBox txtTypCost)
        {
            cn = conexionDataBase.sqlNewConect();
            try
            {
                cmd = new SqlCommand("Select * from MEMBRESIATIPO where idTipoMem = '" + id + "' AND TIPMEMBERSHIPENABLE = '1'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    txtNameMembership.Text = dr["tipNombre"].ToString();
                    txtTipDays.Text = dr["tipDias"].ToString();
                    txtTypCost.Text = dr["tipCosto"].ToString();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo insertar los cambios :" + ex.ToString());
            }

        }

        //Funcion para modificar Un tipo de membresia

        public string ModifyTypeMembeshipInDataBase(string idTypeMembership, string nameMembership, String quantityOfDays, String prizeMembership, DataGridView dgvTypeMembership )
        {
            string salida = "Se Modifico Correctamente el campo ";
            cn = conexionDataBase.sqlNewConect();
            try
            {
                cmd = new SqlCommand("UPDATE MEMBRESIATIPO SET tipNombre = '" + nameMembership + "',tipDias ='" + quantityOfDays + "', tipCosto ='" + prizeMembership + "' WHERE idTipoMem = '" + idTypeMembership + "'", cn);
                cmd.ExecuteNonQuery();
                ChargeTypeMembership(dgvTypeMembership);
            }
            catch (Exception ex)
            {
                salida = "No se pudo actualizar : " + ex.ToString();
            }
            return salida;

        }

        //funcion para elimina alguna membresia

        public String DeleteTypeMembership(String idTypeMembership, DataGridView dgvTypeMembership)
        {

            string salida = "Se Elimino Correctamente el tipo de membresia ";
            cn = conexionDataBase.sqlNewConect();
            try
            {
                cmd = new SqlCommand("UPDATE MEMBRESIATIPO SET TIPMEMBERSHIPENABLE = '0' WHERE IDTIPOMEM  = '" + idTypeMembership + "'", cn);
                cmd.ExecuteNonQuery();
                ChargeTypeMembership(dgvTypeMembership);
            }
            catch (Exception ex)
            {
                salida = "No se pudo actualizar : " + ex.ToString();
            }
            return salida;
        }






    }
}
