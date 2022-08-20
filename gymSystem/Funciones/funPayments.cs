using gymSystem.Clases;
using gymSystem.DTO;
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
    class funPayments
    {
        conexionbd conexionDataBasse = new conexionbd();
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader sqlDR;
        DataTable dt;
        SqlDataAdapter da;
        SqlDataReader dr;

        //registra todos los pagos que se realicen por usuario en la base de datos
        public Boolean toRegisterPayment(String idClient,String Concept,String idService, float amountOfMoney)
        {
            Boolean resultPayment= false;

            DateTime dayPaymentAdvance = DateTime.Now;
            String dateAdvance = dayPaymentAdvance.ToString("yyyy/MM/dd");
            cn = conexionDataBasse.sqlNewConect();
            try
            {
                cmd = new SqlCommand("insert into PAGOS(IDCLIENTE,PAGOCONCEPTO,IDSERVICIO,PAGOVALOR,PAGOFECHA,PAGOENABLE) values ('" + idClient + "', '"+Concept+"','"+idService + "','" + amountOfMoney + "','" + dateAdvance + "','1')", cn);
                cmd.ExecuteNonQuery();
                resultPayment = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar el pago, Error :" + ex.ToString());
                resultPayment = false;
            }

            return resultPayment;
        }

        public Boolean ModifyPayment(String idPayment,float amountOfMoney)
        {
            Boolean resultPayment = false;
            cn = conexionDataBasse.sqlNewConect();
            try
            {
                cmd = new SqlCommand("UPDATE PAGOS SET PAGOVALOR ='"+amountOfMoney+"' WHERE IDPAGO LIKE '"+idPayment+"'AND PAGOENABLE LIKE '1'",cn);
                cmd.ExecuteNonQuery();
                resultPayment = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo modificar el Pago, Error :" + ex.ToString());
                resultPayment = false;
            }
            return resultPayment;

        }

        public csPayments foundPayments(String idService, String conceptPayment)
        {
            csPayments objFoundPayment = new csPayments();
            
            try
            {
                cn = conexionDataBasse.sqlNewConect();
                cmd = new SqlCommand("SELECT * FROM PAGOS WHERE PAGOCONCEPTO = '" + conceptPayment + "' AND IDSERVICIO = '" + idService + "' AND PAGOENABLE LIKE '1' ", cn);
                sqlDR = cmd.ExecuteReader();

                while (sqlDR.Read())
                {
                    objFoundPayment.IDPAGO = int.Parse(sqlDR["IDPAGO"].ToString());
                    objFoundPayment.IDCLIENTE = int.Parse(sqlDR["IDCLIENTE"].ToString());
                    objFoundPayment.PAGOCONCEPTO = sqlDR.GetString(2);
                    objFoundPayment.IDSERVICIO = sqlDR.GetString(3);
                    objFoundPayment.PAGOVALOR = float.Parse(sqlDR["PAGOVALOR"].ToString());
                    objFoundPayment.PAGOFECHA = sqlDR.GetDateTime(5);
                    break;
                }
                sqlDR.Close();
                cn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo obtener el pago de: "+conceptPayment+"con id :"+idService+", Error:" + ex.ToString());
            }
            return objFoundPayment;

        }

        public Boolean InactivityPayment(String idPayment)
        {
            Boolean resultPayment = false;
            cn = conexionDataBasse.sqlNewConect();
            try
            {
                cmd = new SqlCommand("UPDATE PAGOS SET PAGOENABLE ='" + 0 + "' WHERE IDPAGO LIKE '" + idPayment + "'AND PAGOENABLE LIKE '1'", cn);
                cmd.ExecuteNonQuery();
                resultPayment = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo pasar a Inactivo el Pago, Error :" + ex.ToString());
                resultPayment = false;
            }
            return resultPayment;

        }


        public void chargePayments(DataGridView dgvPayment)
        {

            ArrayList listPaymentClient = getPayments();
            dgvPayment.Rows.Clear();
            try
            {

                dgvPayment.Columns.Add("IDENTIFICATION", "Cedula");
                dgvPayment.Columns.Add("NAME", "Nombre");
                dgvPayment.Columns.Add("LASTNAME", "Apellido");
                dgvPayment.Columns.Add("PAYMENT", "Pago");
                dgvPayment.Columns.Add("DATEPAYMENT", "Fecha Pago");
                dgvPayment.Columns.Add("CONCEPTPAYMENT", "Concepto");
                foreach (dtoClientPayment clientPayment in listPaymentClient)
                {
                    dgvPayment.Rows.Add(clientPayment.IDENTIFICATION, clientPayment.NAME, clientPayment.LASTNAME,
                                        clientPayment.PAYMENT, clientPayment.DATEPAYMENT.ToString("dd/MM/yyyy"), clientPayment.CONCEPTPAYMENT.ToLower());

                }

                dgvPayment.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgvPayment.AutoResizeColumns();
                dgvPayment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvPayment.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo Cargar los pagos, Error:" + ex.Message);
            }
        }

        public void rechargePayments(DataGridView dgvPayment)
        {

            ArrayList listPaymentClient = getPayments();
            dgvPayment.Rows.Clear();
            try
            {

                foreach (dtoClientPayment clientPayment in listPaymentClient)
                {
                    dgvPayment.Rows.Add(clientPayment.IDENTIFICATION, clientPayment.NAME, clientPayment.LASTNAME,
                                        clientPayment.PAYMENT, clientPayment.DATEPAYMENT.ToString("dd/MM/yyyy"), clientPayment.CONCEPTPAYMENT.ToLower());

                }

                dgvPayment.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgvPayment.AutoResizeColumns();
                dgvPayment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvPayment.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo Cargar los pagos, Error:" + ex.Message);
            }
        }


        public ArrayList getPayments()
        {
            cn = conexionDataBasse.sqlNewConect();
            ArrayList listPayments = new ArrayList();
            try
            {
                cn = conexionDataBasse.sqlNewConect();
                cmd = new SqlCommand("SELECT CLI.CLIIDENTIFICACION, CLI.CLINOMBRE, CLI.CLIAPELLIDOPATERNO, PAY.PAGOVALOR, PAY.PAGOFECHA, PAY.PAGOCONCEPTO "
                                      + "FROM CLIENTE CLI, PAGOS PAY "
                                      + "WHERE PAY.PAGOENABLE LIKE '1' AND CLI.IDCLIENTE LIKE PAY.IDCLIENTE", cn);
                sqlDR = cmd.ExecuteReader();
                while (sqlDR.Read())
                {
                    dtoClientPayment individualPayment = new dtoClientPayment();
                    individualPayment.IDENTIFICATION = sqlDR.GetString(0);
                    individualPayment.NAME = sqlDR.GetString(1);
                    individualPayment.LASTNAME = sqlDR.GetString(2);
                    individualPayment.PAYMENT = sqlDR["PAGOVALOR"].ToString();
                    individualPayment.DATEPAYMENT = sqlDR.GetDateTime(4);
                    individualPayment.CONCEPTPAYMENT = sqlDR.GetString(5);
                    listPayments.Add(individualPayment);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo Obtener los Pagos, Error:" +ex.Message);
            }
            return listPayments;
        }


        public void searchPayment(String word, DataGridView dgvPayment)
        {
            try
            {
                dgvPayment.Rows.Clear();
                cn = conexionDataBasse.sqlNewConect();
                cmd = new SqlCommand("SELECT CLI.CLIIDENTIFICACION, CLI.CLINOMBRE, CLI.CLIAPELLIDOPATERNO, PAY.PAGOVALOR, PAY.PAGOFECHA, PAY.PAGOCONCEPTO "
                                      + "FROM CLIENTE CLI, PAGOS PAY "
                                      + "WHERE PAY.PAGOENABLE LIKE '1' AND CLI.IDCLIENTE LIKE PAY.IDCLIENTE AND (" 
                                      + "CLI.CLIIDENTIFICACION LIKE '"+word.ToString()
                                      + "' OR CLI.CLINOMBRE LIKE '" + word.ToString()
                                      + "' OR CLI.CLIAPELLIDOPATERNO LIKE '" + word.ToString()+"')", cn); sqlDR = cmd.ExecuteReader();

                while (sqlDR.Read())
                {
                    dgvPayment.Rows.Add(sqlDR.GetString(0), sqlDR.GetString(1), sqlDR.GetString(2),
                                        sqlDR["PAGOVALOR"].ToString(), sqlDR.GetDateTime(4).ToString("dd/MM/yyyy"), sqlDR.GetString(5).ToLower());
                }

                dgvPayment.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgvPayment.AutoResizeColumns();
                dgvPayment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvPayment.ClearSelection();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo Boscar los pagos, Error:"+ex.Message);
            }
        }

    }
}
