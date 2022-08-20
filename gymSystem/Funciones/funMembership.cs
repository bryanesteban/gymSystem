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
    class funMembership
    {
        conexionbd conexionDataBasse = new conexionbd();
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader sqlDR;
        DataTable dt;
        SqlDataAdapter da;
        csMembership foundMembership;
        csTypeMembership objTypeMembership;
        funClient objClient = new funClient();
        funPayments objPayment = new funPayments();
        funTypeMembership functionTypeMembership = new funTypeMembership();
        
        //buscar todas las memebresias activas y retornarlas en una lista
        public ArrayList getMembership ()
        {
            ArrayList arrayMembership = new ArrayList();
            
            try
            {

                cn = conexionDataBasse.sqlNewConect();
                cmd = new SqlCommand("SELECT * FROM MEMBRESIA WHERE MEMENABLE = '1' AND (MEMFECHAFIN >= GETDATE()) ", cn);
                sqlDR = cmd.ExecuteReader();
                while (sqlDR.Read())
                {
                    csMembership objMembership = new csMembership();
                    objMembership.IDMEMBRESIA1 = Int32.Parse(sqlDR["IDMEMBRESIA"].ToString());
                    objMembership.IDCLIENTE1 = Int32.Parse(sqlDR["IDCLIENTE"].ToString());
                    objMembership.IDTIPOMEM1 = Int32.Parse(sqlDR["IDTIPOMEM"].ToString()) ;
                    objMembership.MEMFECHAINICIO1 = sqlDR.GetDateTime(3);
                    objMembership.MEMFECHAFIN1 = sqlDR.GetDateTime(4);
                    objMembership.MEMCOSTO1 = float.Parse(sqlDR["MEMCOSTO"].ToString());
                    arrayMembership.Add(objMembership);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo obtener membresias, Error:"+ex.Message) ;
            }
            cn.Close();
            return arrayMembership;
        }

        //cargar todas las membresias acticas en una datagrid
        public void chargeMembership(DataGridView dgvMembership)
        {
            ArrayList arrayMembership;
            ArrayList arrayDtoMembership = new ArrayList();
            funClient objFindClient = new funClient();
            funTypeMembership objFindTypeMebership = new funTypeMembership();
            dgvMembership.Rows.Clear();
            try
            {
                arrayMembership = getMembership();
                foreach (csMembership objMembership in arrayMembership)
                {
                    dtoMembership objDtoMembership = new dtoMembership();
                    csClient objClient;
                    csTypeMembership objTypeMembership;
                    objDtoMembership.IDMEMBRESIA = objMembership.IDMEMBRESIA1;
                    objClient = objFindClient.findClient(objMembership.IDCLIENTE1.ToString());
                    objDtoMembership.CLIIDENTIFICACION = objClient.CLIIDENTIFICACION1;
                    objDtoMembership.MEMCLIENT = objClient.CLINOMBRE1 + " " + objClient.CLIAPELLIDOPATERNO1;
                    objTypeMembership = objFindTypeMebership.findTypeMembership(objMembership.IDTIPOMEM1.ToString());
                    objDtoMembership.MEMTIPO = objTypeMembership.TIPNOMBRE1;
                    objDtoMembership.MEMFECHAINICIO = objMembership.MEMFECHAINICIO1;
                    objDtoMembership.MEMFECHAFIN = objMembership.MEMFECHAFIN1;
                    objDtoMembership.MEMCOSTO = objMembership.MEMCOSTO1;
                    arrayDtoMembership.Add(objDtoMembership);
                }
                dgvMembership.Columns.Add("IDMEMBRESIA", "ID");
                dgvMembership.Columns.Add("CLIIDENTIFICACION1", "Cedula");
                dgvMembership.Columns.Add("MEMCLIENT", "Cliente");
                dgvMembership.Columns.Add("MEMTIPO", "Tipo Membresia");
                dgvMembership.Columns.Add("MEMFECHAINICIO", "Fecha Inicio");
                dgvMembership.Columns.Add("MEMFECHAFIN", "Fecha Fin");
                dgvMembership.Columns.Add("MEMCOSTO", "Costo");
                foreach(dtoMembership objDtoMembership in arrayDtoMembership)
                {
                  dgvMembership.Rows.Add(objDtoMembership.IDMEMBRESIA.ToString(),objDtoMembership.CLIIDENTIFICACION, objDtoMembership.MEMCLIENT,objDtoMembership.MEMTIPO,objDtoMembership.MEMFECHAINICIO.ToString("dd/MM/yyyy"),objDtoMembership.MEMFECHAFIN.ToString("dd/MM/yyyy"),objDtoMembership.MEMCOSTO.ToString());
                    
                }


               
                dgvMembership.Columns["IDMEMBRESIA"].Visible = false;
                dgvMembership.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo Cargar las Membresia, Error:"+ex.Message);
            }
        }


        //recargar ventana de Membresias
        public void rechargeMembership(DataGridView dgvMembership)
        {
            ArrayList arrayMembership;
            ArrayList arrayDtoMembership = new ArrayList();
            funClient objFindClient = new funClient();
            funTypeMembership objFindTypeMebership = new funTypeMembership();
            dgvMembership.Rows.Clear();
            try
            {
                
                arrayMembership = getMembership();
                foreach (csMembership objMembership in arrayMembership)
                {
                    dtoMembership objDtoMembership = new dtoMembership();
                    csClient objClient;
                    csTypeMembership objTypeMembership;
                    objDtoMembership.IDMEMBRESIA = objMembership.IDMEMBRESIA1;
                    objClient = objFindClient.findClient(objMembership.IDCLIENTE1.ToString());
                    objDtoMembership.CLIIDENTIFICACION = objClient.CLIIDENTIFICACION1;
                    objDtoMembership.MEMCLIENT = objClient.CLINOMBRE1 + " " + objClient.CLIAPELLIDOPATERNO1;
                    objTypeMembership = objFindTypeMebership.findTypeMembership(objMembership.IDTIPOMEM1.ToString());
                    objDtoMembership.MEMTIPO = objTypeMembership.TIPNOMBRE1;
                    objDtoMembership.MEMFECHAINICIO = objMembership.MEMFECHAINICIO1;
                    objDtoMembership.MEMFECHAFIN = objMembership.MEMFECHAFIN1;
                    objDtoMembership.MEMCOSTO = objMembership.MEMCOSTO1;
                    arrayDtoMembership.Add(objDtoMembership);
                }
                foreach (dtoMembership objDtoMembership in arrayDtoMembership)
                {
                    dgvMembership.Rows.Add(objDtoMembership.IDMEMBRESIA.ToString(), objDtoMembership.CLIIDENTIFICACION, objDtoMembership.MEMCLIENT, objDtoMembership.MEMTIPO, objDtoMembership.MEMFECHAINICIO.ToString("dd/MM/yyyy"), objDtoMembership.MEMFECHAFIN.ToString("dd/MM/yyyy"), objDtoMembership.MEMCOSTO.ToString());

                }



                dgvMembership.Columns["IDMEMBRESIA"].Visible = false;
                dgvMembership.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo Cargar las Membresia, Error:" + ex.Message);
            }
        }

        //buscar las membreias activas por cedula del cliente o su nombre
        public void searchMembership(String word, DataGridView dgvMembership)
        {
            ArrayList arrayDtoMembership = new ArrayList();
            try
            {
                dgvMembership.Rows.Clear();
                cn = conexionDataBasse.sqlNewConect();
                cmd = new SqlCommand("SELECT M.IDMEMBRESIA,C.CLIIDENTIFICACION,CONCAT(C.CLINOMBRE,' ',C.CLIAPELLIDOPATERNO) NOMBRE,T.TIPNOMBRE,M.MEMFECHAINICIO,M.MEMFECHAFIN,M.MEMCOSTO FROM MEMBRESIA M, CLIENTE C, MEMBRESIATIPO T WHERE M.IDCLIENTE = C.IDCLIENTE AND M.IDTIPOMEM = T.IDTIPOMEM AND (CLIIDENTIFICACION LIKE '" + word.ToString() + "' or CLINOMBRE LIKE '" + word.ToString() + "' or CLIAPELLIDOPATERNO LIKE '" + word.ToString() + "') AND MEMENABLE LIKE 1 AND (MEMFECHAFIN >= GETDATE()) ", cn);
                sqlDR = cmd.ExecuteReader();

                while (sqlDR.Read())
                {
                    dtoMembership objDtoMembership = new dtoMembership();
                    objDtoMembership.IDMEMBRESIA = Int32.Parse(sqlDR["IDMEMBRESIA"].ToString());
                    objDtoMembership.CLIIDENTIFICACION = sqlDR["CLIIDENTIFICACION"].ToString();
                    objDtoMembership.MEMCLIENT = sqlDR["NOMBRE"].ToString();  
                    objDtoMembership.MEMTIPO = sqlDR["TIPNOMBRE"].ToString();
                    objDtoMembership.MEMFECHAINICIO = sqlDR.GetDateTime(4);
                    objDtoMembership.MEMFECHAFIN = sqlDR.GetDateTime(5);
                    objDtoMembership.MEMCOSTO = float.Parse(sqlDR["MEMCOSTO"].ToString());
                    dgvMembership.Rows.Add(objDtoMembership.IDMEMBRESIA.ToString(), objDtoMembership.CLIIDENTIFICACION, objDtoMembership.MEMCLIENT, objDtoMembership.MEMTIPO, objDtoMembership.MEMFECHAINICIO.ToString("dd/MM/yyyy"), objDtoMembership.MEMFECHAFIN.ToString("dd/MM/yyyy"), objDtoMembership.MEMCOSTO.ToString());
                }
                dgvMembership.Columns["IDMEMBRESIA"].Visible = false;
                dgvMembership.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //retorna una membresia activa para llenar el modificado
        public ArrayList findMembership(String idClient)
        {
            ArrayList arrayMembership = new ArrayList();

            try
            {

                cn = conexionDataBasse.sqlNewConect();
                cmd = new SqlCommand("SELECT * FROM MEMBRESIA WHERE idClient = '"+idClient+"' AND MEMENABLE = '1' AND (MEMFECHAFIN >= GETDATE()) ", cn);
                sqlDR = cmd.ExecuteReader();
                while (sqlDR.Read())
                {
                    csMembership objMembership = new csMembership();
                    objMembership.IDMEMBRESIA1 = Int32.Parse(sqlDR["IDMEMBRESIA"].ToString());
                    objMembership.IDCLIENTE1 = Int32.Parse(sqlDR["IDCLIENTE"].ToString());
                    objMembership.IDTIPOMEM1 = Int32.Parse(sqlDR["IDTIPOMEM"].ToString());
                    objMembership.MEMFECHAINICIO1 = sqlDR.GetDateTime(3);
                    objMembership.MEMFECHAFIN1 = sqlDR.GetDateTime(4);
                    objMembership.MEMAVANCEPAGO1 = float.Parse(sqlDR["MEMAVANCEPAGO"].ToString());
                    objMembership.MEMCOSTO1 = float.Parse(sqlDR["MEMCOSTO"].ToString());
                    arrayMembership.Add(objMembership);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo obtener membresias, Error:" + ex.Message);
            }

            return arrayMembership;
        }

        public csMembership foundOneMembership(String idMembership)
        {
            csMembership objMembership = new csMembership();
            try
            {

                cn = conexionDataBasse.sqlNewConect();
                cmd = new SqlCommand("SELECT * FROM MEMBRESIA WHERE IDMEMBRESIA = '" + idMembership + "' ", cn);
                sqlDR = cmd.ExecuteReader();
               
                while (sqlDR.Read())
                {
                    
                    objMembership.IDMEMBRESIA1 = Int32.Parse(sqlDR["IDMEMBRESIA"].ToString());
                    objMembership.IDCLIENTE1 = Int32.Parse(sqlDR["IDCLIENTE"].ToString());
                    objMembership.IDTIPOMEM1 = Int32.Parse(sqlDR["IDTIPOMEM"].ToString());
                    objMembership.MEMFECHAINICIO1 = sqlDR.GetDateTime(3);
                    objMembership.MEMFECHAFIN1 = sqlDR.GetDateTime(4);
                    objMembership.MEMCOSTO1 = float.Parse(sqlDR["MEMCOSTO"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo obtener la membresia"+idMembership+", Error:" + ex.Message);
            }
            cn.Close();
            return objMembership;
        }
        


        public void fillMembershipType(ComboBox cmbTypeMembership)
        {
            List<dtoTypeMembership> listTypeMembership = new List<dtoTypeMembership>();

            cn = conexionDataBasse.sqlNewConect();
            cmd = new SqlCommand("SELECT * FROM MEMBRESIATIPO WHERE TIPMEMBERSHIPENABLE = '1' ", cn);
            sqlDR = cmd.ExecuteReader();
            ArrayList AlTypeMembership = new ArrayList();
            cmbTypeMembership.Items.Add(new { idType = "0", descriptionType = "Seleccione..." });
            cmbTypeMembership.SelectedIndex = 0;
            while (sqlDR.Read())
            {
                dtoTypeMembership objDtpTypeMembership = new dtoTypeMembership()
                {
                    IDTIPOMEM1 = Convert.ToInt32(sqlDR["IDTIPOMEM"]),
                    TIPDESCRIPTION1 = sqlDR["TIPNOMBRE"].ToString() + " - " + sqlDR["TIPDIAS"].ToString() + " Dias",
                };
                listTypeMembership.Add(objDtpTypeMembership);
            }
            cmbTypeMembership.DataSource = listTypeMembership;
            cmbTypeMembership.DisplayMember = "TIPDESCRIPTION1";
            cmbTypeMembership.ValueMember = "IDTIPOMEM1";

        }


        public csTypeMembership findMembershipType(String idTypeMembership)
        {
            int idType, tipDays;
            String tipName;
            float tipCosto;
            Boolean tipEnable;
            cn = conexionDataBasse.sqlNewConect();
            cmd = new SqlCommand("SELECT * FROM MEMBRESIATIPO Where IDTIPOMEM =  '" + idTypeMembership + "' AND TIPMEMBERSHIPENABLE = '1' ", cn);
            sqlDR = cmd.ExecuteReader();
            while (sqlDR.Read())
            {
                idType = Int32.Parse(sqlDR["IDTIPOMEM"].ToString());
                tipName = sqlDR["TIPNOMBRE"].ToString();
                tipDays = Int32.Parse(sqlDR["TIPDIAS"].ToString());
                tipCosto = float.Parse(sqlDR["TIPCOSTO"].ToString());
                tipEnable = Boolean.Parse(sqlDR["TIPMEMBERSHIPENABLE"].ToString());
                objTypeMembership = new csTypeMembership(idType, tipName, tipDays, tipCosto);
            }
            sqlDR.Close();
            return objTypeMembership;
        }

        public csMembership findDateTimeMembership(String idClient)
        {
            int idMembership, idClientMembership, idTipeMembership;
            DateTime membershipBegin, membershipEnd;
            float membershipCost, membershipAdvance;
            cn = conexionDataBasse.sqlNewConect();
            try
            {
                cmd = new SqlCommand("SELECT TOP 1 * FROM MEMBRESIA Where IDCLIENTE = '" + idClient + "' AND (MEMFECHAFIN > GETDATE()) AND MEMENABLE = '1' ORDER BY MEMFECHAFIN DESC", cn);
                sqlDR = cmd.ExecuteReader();
                while (sqlDR.Read())
                {
                    idMembership = Int32.Parse(sqlDR["IDMEMBRESIA"].ToString());
                    idClientMembership = Int32.Parse(sqlDR["IDCLIENTE"].ToString());
                    idTipeMembership = Int32.Parse(sqlDR["IDTIPOMEM"].ToString());
                    membershipBegin = sqlDR.GetDateTime(3);
                    membershipEnd = sqlDR.GetDateTime(4);
                    membershipAdvance = float.Parse(sqlDR["MEMAVANCEPAGO"].ToString());
                    membershipCost = float.Parse(sqlDR["MEMCOSTO"].ToString());
                    foundMembership = new csMembership(idMembership, idClientMembership, idTipeMembership, membershipBegin, membershipEnd, membershipCost);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar la memebresia del usuario," + idClient + "Error:" + ex.ToString());
            }
            sqlDR.Close();
            return foundMembership;
        }

        public Boolean verifyMembershipActive(String idClient)
        {
            cn = conexionDataBasse.sqlNewConect();
            Boolean resultado = false;
            try
            {
                cmd = new SqlCommand("SELECT CASE WHEN EXISTS ( SELECT * FROM MEMBRESIA Where IDCLIENTE =  '" + idClient + "' AND MEMFECHAFIN >= GETDATE() AND MEMENABLE LIKE '1' ) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END", cn);
                sqlDR = cmd.ExecuteReader();
                while (sqlDR.Read())
                {
                    resultado = sqlDR.GetBoolean(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" No se pudo verificar la existencia de mas membresias por parte del usuario " + idClient + ", Error : " + ex.ToString());
            }
            sqlDR.Close();
            return resultado;
        }

        public Boolean verifyMembershipLastDay(String idClient)
        {
            cn = conexionDataBasse.sqlNewConect();
            Boolean resultado = false;
            try
            {
                cmd = new SqlCommand("SELECT CASE WHEN EXISTS ( SELECT * FROM MEMBRESIA Where IDCLIENTE =  '" + idClient + "' AND MEMFECHAFIN LIKE GETDATE()) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END", cn);
                sqlDR = cmd.ExecuteReader();
                while (sqlDR.Read())
                {
                    resultado = sqlDR.GetBoolean(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" No se pudo verificar la existencia de mas membresias por parte del usuario " + idClient + ", Error : " + ex.ToString());
            }
            sqlDR.Close();
            return resultado;
        }

        //inserta una nueva membresia
        public String InsertMembership(String idClient, String idTypeMembership, float advance, DataGridView dgvMembership)
        {
            cn = conexionDataBasse.sqlNewConect();
            csTypeMembership typeMembership = findMembershipType(idTypeMembership);
            String dateTimeBeginMembership, dateTimeEndMembership;
            String salida = "";
            String idMembershipRegistred = "";
            int daysCount = typeMembership.TIPDIAS1;
            try
            {
                
                    if (verifyMembershipActive(idClient) != true)
                    {
                             if (verifyMembershipLastDay(idClient) != true) {
                                DateTime membershipInscription = DateTime.Now;
                                dateTimeBeginMembership = membershipInscription.ToString("yyyy/MM/dd");
                                dateTimeEndMembership = membershipInscription.AddDays(typeMembership.TIPDIAS1).ToString("yyyy/MM/dd");
                                cmd = new SqlCommand("Insert into MEMBRESIA(IDCLIENTE,IDTIPOMEM,MEMFECHAINICIO,MEMFECHAFIN,MEMCOSTO,MEMENABLE) values('" + idClient + "','" + idTypeMembership + "','" + dateTimeBeginMembership + "','" + dateTimeEndMembership + "','" + typeMembership.TIPCOSTO1.ToString() + "','1'); SELECT CAST (SCOPE_IDENTITY() AS varchar)", cn);
                                sqlDR = cmd.ExecuteReader();
                                while (sqlDR.Read())
                                {
                                    idMembershipRegistred = sqlDR.GetString(0);
                                }
                            if (membershipPayment(idClient, idMembershipRegistred, advance, typeMembership.TIPCOSTO1))
                                    {
                                        salida = "Se creo Satisfactoriamente la nueva memebresia";
                                    }
                                    else
                                    {
                                        salida = "El pago no pudo ser realiazado.";
                                    }
                             }
                             else
                             {
                                csMembership dateMembershipActive = findDateTimeMembership(idClient);
                                dateTimeBeginMembership = dateMembershipActive.MEMFECHAFIN1.AddDays(1).ToString("yyyy/MM/dd");
                                dateTimeEndMembership = dateMembershipActive.MEMFECHAFIN1.AddDays(daysCount + 1).ToString("yyyy/MM/dd");
                                cmd = new SqlCommand("Insert into MEMBRESIA(IDCLIENTE,IDTIPOMEM,MEMFECHAINICIO,MEMFECHAFIN,MEMCOSTO,MEMENABLE) values('" + idClient + "','" + idTypeMembership + "','" + dateTimeBeginMembership + "','" + dateTimeEndMembership + "','" + typeMembership.TIPCOSTO1.ToString() + "','1'); SELECT CAST (SCOPE_IDENTITY() AS varchar)", cn);
                                sqlDR = cmd.ExecuteReader();
                                while (sqlDR.Read())
                                {
                                    idMembershipRegistred = sqlDR.GetString(0);
                                }
                            if (membershipPayment(idClient,idMembershipRegistred, advance, typeMembership.TIPCOSTO1))
                                    {
                                        salida = "Se creo Satisfactoriamente la nueva memebresia";
                                    }
                                    else
                                    {
                                        salida = "El pago no pudo ser realiazado.";
                                    }
                                 }

                    }
                    else
                    {                        
                        salida = "No se puede crear, porque esta persona ya posee una membresia activa";
                    }

            }
            catch (Exception ex)
            {
                salida = "No se pudo ingresar la nueva membresia, Error : " + ex.ToString();
            }

            rechargeMembership(dgvMembership);

            return salida;
        }

        public Boolean membershipPayment(String idClient,String idMembershipRegistred, float advance, float costMembership)
        {
            float resultPayment;
            Boolean result = false;
            csClient foundClient = objClient.findClient(idClient);
            resultPayment = foundClient.CLISALDOPENDIENTE1 + costMembership - advance;
            cn = conexionDataBasse.sqlNewConect();
            try
            {
                cmd = new SqlCommand("UPDATE CLIENTE SET CLISALDOPENDIENTE ='" + resultPayment + "' WHERE idCliente = '" + idClient + "'", cn);
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar el avance, Error :" + ex.ToString());
                result = false;
            }
            cn.Close();
            //registrar pagos por usuario
            result = objPayment.toRegisterPayment(idClient, "MEMBRESIA", idMembershipRegistred, advance);
            return result;
        }

        public Boolean membershipModifyPayment(String idPayment, float paymentAmount, String idClient, float costMembership,String idMembership)
        {
            Boolean result = false;
            

            if (restartPaymentMembership(idMembership))
             {
                csClient foundClient = objClient.findClient(idClient);
                float resultPayment = foundClient.CLISALDOPENDIENTE1 + costMembership - paymentAmount;


                try
                {
                    cn = conexionDataBasse.sqlNewConect();
                    cmd = new SqlCommand("UPDATE CLIENTE SET CLISALDOPENDIENTE ='" + resultPayment + "' WHERE idCliente = '" + idClient + "'", cn);
                    cmd.ExecuteNonQuery();
                    result = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo modificar el pago, Error:" + ex.ToString());
                   result = false;
                }
            }
            else
            {
                MessageBox.Show("No se pudo restaurar el valor de Deuda del Usuario");
                result = false;
            }


            result = objPayment.ModifyPayment(idPayment, paymentAmount);
            return result;
        }

        //Modifica la suscripcion elegida
        public String modifyMembership(String idMembership, String idClient, String idTypeMembership, String advance, DataGridView dgvMembership)
        {
            String salida = "";
            String dateTimeBeginMembership, dateTimeEndMembership;
            
            try
            {
                csMembership objMembership = foundOneMembership(idMembership);
                csTypeMembership typeMembership = findMembershipType(idTypeMembership);
                csPayments membershipPayment = objPayment.foundPayments(idMembership, "MEMBRESIA");
                DateTime membershipInscription = Convert.ToDateTime(objMembership.MEMFECHAINICIO1);
                //dateTimeBeginMembership = membershipInscription.ToString("yyyy/MM/dd");
                    if (membershipModifyPayment(membershipPayment.IDPAGO.ToString(), float.Parse(advance),objMembership.IDCLIENTE1.ToString(),typeMembership.TIPCOSTO1, idMembership))
                    {
                        dateTimeEndMembership = membershipInscription.AddDays(typeMembership.TIPDIAS1).ToString("yyyy/MM/dd");
                        cn = conexionDataBasse.sqlNewConect();
                        cmd = new SqlCommand("UPDATE MEMBRESIA SET IDCLIENTE = '" + idClient + "',IDTIPOMEM ='" + idTypeMembership + "', MEMFECHAFIN ='" + dateTimeEndMembership +"',MEMCOSTO ='"+typeMembership.TIPCOSTO1 + "' WHERE IDMEMBRESIA = '" + idMembership + "'", cn);
                        cmd.ExecuteNonQuery();
                        salida = "Se Modifico Correctamente la membresia ";
                    }else
                    {
                        salida = "No se pudo actualizar el Pago Realizado";
                    }
                rechargeMembership(dgvMembership);
            }
            catch (Exception ex)
            {
                salida = "No se pudo actualizar : " + ex.ToString();
            }
            cn.Close();

            return salida;
        }

        //restaurar pagos 

        public Boolean restartPaymentMembership(String idMembership)
        {
            Boolean salida = false;
            float restartBalance = 0;
            try
            {
                csMembership objMembership = foundOneMembership(idMembership);
                csPayments objPaymentMembership = objPayment.foundPayments(idMembership,"MEMBRESIA");
                csClient objClientMembership = objClient.findClient(objMembership.IDCLIENTE1.ToString());
                //resultPayment = foundClient.CLISALDOPENDIENTE1 + costMembership - advance;
                csTypeMembership typeMembership = functionTypeMembership.findTypeMembership(objMembership.IDTIPOMEM1.ToString());

                //Operation for restart membership
                restartBalance =  objClientMembership.CLISALDOPENDIENTE1 - typeMembership.TIPCOSTO1 + objPaymentMembership.PAGOVALOR;
                cn = conexionDataBasse.sqlNewConect();
                cmd = new SqlCommand("UPDATE CLIENTE SET CLISALDOPENDIENTE ='" + restartBalance + "' WHERE idCliente = '" + objMembership.IDCLIENTE1 + "'", cn);
                cmd.ExecuteNonQuery();

                salida = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo restaurar el pago!, Error:" + ex.ToString());
                salida = false;
            }
            cn.Close();

            return salida;
        }

        //borrar Membresia
        public String DeleteMembership(String idMembership, DataGridView dgvMembership)
        {
            String salida = "";

            if(deletePayment(idMembership))
            {
                cn = conexionDataBasse.sqlNewConect();
                cmd = new SqlCommand("UPDATE MEMBRESIA SET MEMENABLE = '" + 0 + "' WHERE IDMEMBRESIA = '" + idMembership + "'", cn);
                cmd.ExecuteNonQuery();
                salida = "Se Elimino Correctamente la membresia ";
                rechargeMembership(dgvMembership);
            }
            else
            {
                salida = "No se pudo Eliminar la membresia";
            }

            return salida;
        }

        public Boolean deletePayment(String idMembership)
        {
            funMembership opMembership = new funMembership();
            csMembership membershipClient = opMembership.foundOneMembership(idMembership);
            csPayments membershipPayment = objPayment.foundPayments(idMembership, "MEMBRESIA");
            Boolean result = false;

            if (restartPaymentMembership(idMembership))
            {
                result = objPayment.InactivityPayment(membershipPayment.IDCLIENTE.ToString());
            }
            else
            {
                MessageBox.Show("No se pudo restaurar el valor de Deuda del Usuario");
                result = false;
            }


           
            return result;
        }
        



    }
}
