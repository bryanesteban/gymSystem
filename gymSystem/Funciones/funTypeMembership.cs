using gymSystem.Clases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gymSystem.Funciones
{
    class funTypeMembership
    {

        conexionbd conexionDataBasse = new conexionbd();
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader sqlDR;
        DataTable dt;
        SqlDataAdapter da;
        SqlDataReader dr;

        //Insertar nuevo tipo de membresia en la base de datos, que consta de el nombre de la membresia, la cantidad de dias y su precio
        public string insertTypeMembership(string nameTypeMembership, string typeDays, string typePrize, DataGridView dgvTypeMembership)
        {
            cn = conexionDataBasse.sqlNewConect();
            string salida = "Se inserto Correctamnete";

            try
            {
                cmd = new SqlCommand("Insert into MEMBRESIATIPO(tipNombre,tipDias,tipCosto,tipMembershipEnable) values" +
                    "('" + nameTypeMembership + "','" + typeDays + "','" + typePrize + "', '1')", cn);
                cmd.ExecuteNonQuery();
                rechargeTypeMembership(dgvTypeMembership);
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
            cn = conexionDataBasse.sqlNewConect();
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

        public string ModifyTypeMembeshipInDataBase(string idTypeMembership, string nameMembership, String quantityOfDays, String prizeMembership, DataGridView dgvTypeMembership)
        {
            string salida = "Se Modifico Correctamente el campo ";
            cn = conexionDataBasse.sqlNewConect();
            try
            {
                cmd = new SqlCommand("UPDATE MEMBRESIATIPO SET tipNombre = '" + nameMembership + "',tipDias ='" + quantityOfDays + "', tipCosto ='" + prizeMembership + "' WHERE idTipoMem = '" + idTypeMembership + "'", cn);
                cmd.ExecuteNonQuery();
                rechargeTypeMembership(dgvTypeMembership);
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
            cn = conexionDataBasse.sqlNewConect();
            try
            {
                cmd = new SqlCommand("UPDATE MEMBRESIATIPO SET TIPMEMBERSHIPENABLE = '0' WHERE IDTIPOMEM  = '" + idTypeMembership + "'", cn);
                cmd.ExecuteNonQuery();
                rechargeTypeMembership(dgvTypeMembership);
            }
            catch (Exception ex)
            {
                salida = "No se pudo actualizar : " + ex.ToString();
            }
            return salida;
        }

        //carga la lista de membresias en un datagrid
        public void chargeTypeMembership(DataGridView dgvTypeMembership)
        {
            try
            {
                dgvTypeMembership.Rows.Clear();
                dgvTypeMembership.Columns.Add("IDTIPOMEM", "ID");
                dgvTypeMembership.Columns.Add("TIPNOMBRE", "Nombre");
                dgvTypeMembership.Columns.Add("TIPDIAS", "Dias");
                dgvTypeMembership.Columns.Add("TIPCOSTO", "Precio(Dolares)");



                cn = conexionDataBasse.sqlNewConect();
                cmd = new SqlCommand("SELECT * FROM MEMBRESIATIPO WHERE TIPMEMBERSHIPENABLE = '1'", cn);
                sqlDR = cmd.ExecuteReader();

                while (sqlDR.Read())
                {
                    csTypeMembership objTypeMembership = new csTypeMembership();
                    objTypeMembership.IDTIPOMEM1 = int.Parse(sqlDR["IDTIPOMEM"].ToString());
                    objTypeMembership.TIPNOMBRE1 = sqlDR["TIPNOMBRE"].ToString();
                    objTypeMembership.TIPDIAS1 = int.Parse(sqlDR["TIPDIAS"].ToString());
                    objTypeMembership.TIPCOSTO1 = float.Parse(sqlDR["TIPCOSTO"].ToString());
                    dgvTypeMembership.Rows.Add(objTypeMembership.IDTIPOMEM1, objTypeMembership.TIPNOMBRE1, objTypeMembership.TIPDIAS1, objTypeMembership.TIPCOSTO1);
                }
                dgvTypeMembership.Columns["IDTIPOMEM"].Visible = false;
                dgvTypeMembership.ClearSelection();
                dgvTypeMembership.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgvTypeMembership.AutoResizeColumns();
                dgvTypeMembership.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo Cargar los tipos de memebresia, Error:" + ex.Message);
            }
        }

        //recarga la lista de tipos de memebresias
        public void rechargeTypeMembership(DataGridView dgvTypeMembership)
        {
            try
            {
                dgvTypeMembership.Rows.Clear();
                cn = conexionDataBasse.sqlNewConect();
                cmd = new SqlCommand("SELECT * FROM MEMBRESIATIPO WHERE TIPMEMBERSHIPENABLE = '1'", cn);
                sqlDR = cmd.ExecuteReader();

                while (sqlDR.Read())
                {
                    csTypeMembership objTypeMembership = new csTypeMembership();
                    objTypeMembership.IDTIPOMEM1 = int.Parse(sqlDR["IDTIPOMEM"].ToString());
                    objTypeMembership.TIPNOMBRE1 = sqlDR["TIPNOMBRE"].ToString();
                    objTypeMembership.TIPDIAS1 = int.Parse(sqlDR["TIPCOSTO"].ToString());
                    objTypeMembership.TIPCOSTO1 = float.Parse(sqlDR["TIPCOSTO"].ToString());
                    dgvTypeMembership.Rows.Add(objTypeMembership.IDTIPOMEM1, objTypeMembership.TIPNOMBRE1, objTypeMembership.TIPDIAS1, objTypeMembership.TIPCOSTO1);
                }
                dgvTypeMembership.Columns["IDTIPOMEM"].Visible = false;
                dgvTypeMembership.ClearSelection();
                dgvTypeMembership.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgvTypeMembership.AutoResizeColumns();
                dgvTypeMembership.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo Cargar los tipos de memebresia, Error:" + ex.Message);
            }
        }



        //devuelve una lista con todos los tipos de memebresias
        public ArrayList getTypeMembership()
        {
            ArrayList arrayTypeMembership = new ArrayList();
            

            cn = conexionDataBasse.sqlNewConect();
            cmd = new SqlCommand("SELECT * FROM MEMBRESIATIPO WHERE TIPMEMBERSHIPENABLE = '1' ", cn);
            sqlDR = cmd.ExecuteReader();

            while (sqlDR.Read())
            {
                csTypeMembership objTypeMembership = new csTypeMembership();
                objTypeMembership.IDTIPOMEM1 = int.Parse(sqlDR["IDTIPOMEM"].ToString());
                objTypeMembership.TIPNOMBRE1 = sqlDR["TIPNOMBRE"].ToString();
                objTypeMembership.TIPDIAS1 = int.Parse(sqlDR["TIPCOSTO"].ToString());
                objTypeMembership.TIPCOSTO1 = float.Parse(sqlDR["TIPCOSTO"].ToString());
                arrayTypeMembership.Add(objTypeMembership);
            }
            sqlDR.Close();
            return arrayTypeMembership;
        }

        //devuelve una memebresia buscada por codigo
        public csTypeMembership findTypeMembership(String codeTypeMembership)
        {
            csTypeMembership objTypeMembership = new csTypeMembership();
            try { 
            cn = conexionDataBasse.sqlNewConect();
            cmd = new SqlCommand("SELECT * FROM MEMBRESIATIPO WHERE IDTIPOMEM = '" + codeTypeMembership + "'", cn);
            sqlDR = cmd.ExecuteReader();

            while (sqlDR.Read())
            {
                objTypeMembership.IDTIPOMEM1 = int.Parse(sqlDR["IDTIPOMEM"].ToString());
                objTypeMembership.TIPNOMBRE1 = sqlDR["TIPNOMBRE"].ToString();
                objTypeMembership.TIPDIAS1 = int.Parse(sqlDR["TIPCOSTO"].ToString());
                objTypeMembership.TIPCOSTO1 = float.Parse(sqlDR["TIPCOSTO"].ToString());
                break;
            }
        }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo buscar el tipo de Membresia, Error : "+ex.Message);
            }
    sqlDR.Close();
            return objTypeMembership;
        }


    }
}
