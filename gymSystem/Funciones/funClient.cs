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
    class funClient
    {
        conexionbd conexionDataBasse = new conexionbd();
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader sqlDR;
        DataTable dt;
        SqlDataAdapter da;
        SqlDataReader dr;
        public csClient findClient(String codeClient)
        {
            cn = conexionDataBasse.sqlNewConect();
            
            csClient objClient = new csClient();
            try
            {
                cmd = new SqlCommand("SELECT * FROM CLIENTE WHERE IDCLIENTE = '" + codeClient + "' and CLIENABLE LIKE 1 ", cn);
                sqlDR = cmd.ExecuteReader();
                while (sqlDR.Read())
                {
                    objClient.IDCLIENTE1 = int.Parse(sqlDR["IDCLIENTE"].ToString());
                    objClient.CLIIDENTIFICACION1 = sqlDR.GetString(1);
                    objClient.CLINOMBRE1 = sqlDR.GetString(2);
                    objClient.CLISEGUNDONOMBRE1 = sqlDR.GetString(3);
                    objClient.CLIAPELLIDOPATERNO1 = sqlDR.GetString(4);
                    objClient.CLIAPELLIDOMATERNO1 = sqlDR.GetString(5);
                    objClient.CLIFECHANACIMIENTO1 = sqlDR.GetDateTime(6);
                    objClient.CLIFECHAINSCRIPCION1 = sqlDR.GetDateTime(7);
                    objClient.CLITELEFONO1 = sqlDR.GetString(8);
                    objClient.CLIDIRECCION1 = sqlDR.GetString(9);
                    objClient.CLISALDOPENDIENTE1 = float.Parse(sqlDR["CLISALDOPENDIENTE"].ToString());
                    break;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo obtener el Cliente, Error:"+ex.ToString());
            }
            sqlDR.Close();
            cn.Close();
            return objClient;
        }

        public ArrayList getClient()
        {
            ArrayList arrayClient = new ArrayList();
            

            cn = conexionDataBasse.sqlNewConect();
            cmd = new SqlCommand("SELECT * FROM CLIENTE CLIENABLE LIKE 1 ", cn);
            sqlDR = cmd.ExecuteReader();
            
            while (sqlDR.Read())
            {
                csClient objClient = new csClient();
                objClient.IDCLIENTE1 = int.Parse(sqlDR["IDCLIENTE"].ToString());
                objClient.CLIIDENTIFICACION1 = sqlDR.GetString(1);
                objClient.CLINOMBRE1 = sqlDR.GetString(2);
                objClient.CLISEGUNDONOMBRE1 = sqlDR.GetString(3);
                objClient.CLIAPELLIDOPATERNO1 = sqlDR.GetString(4);
                objClient.CLIAPELLIDOMATERNO1 = sqlDR.GetString(5);
                objClient.CLIFECHANACIMIENTO1 = sqlDR.GetDateTime(6);
                objClient.CLIFECHAINSCRIPCION1 = sqlDR.GetDateTime(7);
                objClient.CLITELEFONO1 = sqlDR.GetString(8);
                objClient.CLIDIRECCION1 = sqlDR.GetString(9);
                objClient.CLISALDOPENDIENTE1 = float.Parse(sqlDR["CLISALDOPENDIENTE"].ToString());

                arrayClient.Add(objClient);
            }
            sqlDR.Close();
            cn.Close();
            return arrayClient;
        }

        //valida que no exista otro cliente con los mismos datos en la base de datos
        public int personaRegistrada(string identification)
        {
            cn = conexionDataBasse.sqlNewConect();
            int registrySame = 0;
            try
            {
                cmd = new SqlCommand("Select * from CLIENTE where CLIIDENTIFICACION = '" + identification + "' AND CLIENABLE LIKE '1' ", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    registrySame++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo hacer la consulta: " + ex.ToString());
            }
            return registrySame;

        }
    

    // ingresa nuevos clientes con sus respectivos datos como:
    //cedula,nombre, apellido materno, apellido paterno, fecha de nacimiento y fecha de Inscripcion
    public string insertClint(string identification, string name, string secondName, string middlename, string lastname,
                                  string dateborn, string dateinscription, string telefono, string direccion,DataGridView dgvClient)
        {
            cn = conexionDataBasse.sqlNewConect();
            string salida = "Se inserto Correctamnete";
            try
            {
                cmd = new SqlCommand("Insert into CLIENTE(cliIdentificacion,cliNombre,cliSegundoNombre,cliApellidoPaterno,cliApellidoMaterno,cliFechaNacimiento,cliFechaInscripcion, cliTelefono, cliDireccion, cliSaldoPendiente, cliEnable) values" +
                    "('" + identification + "','" + name + "','" + secondName + "','" + lastname + "','" + middlename + "','" + dateborn + "','" + dateinscription + "','" + telefono + "','" + direccion + "','0',' 1 ')", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se ingreseo : " + ex.ToString();
            }
            reChargeClient(dgvClient);
            return salida;

        }
        //cargar clientes en una gridview

        public void chargeClient(DataGridView dgvClient)
        {
            String balance="";
            try
            {
                dgvClient.Rows.Clear();
                dgvClient.Columns.Add("IDCLIENTE", "ID");
                dgvClient.Columns.Add("CLIIDENTIFICACION", "Cedula");
                dgvClient.Columns.Add("CLINOMBRES", "Nombres");
                dgvClient.Columns.Add("CLIAPELLIDOS", "Apellidos");
                dgvClient.Columns.Add("CLIFECHANACIMIENTO", "Nacimiento");
                dgvClient.Columns.Add("CLIFECHAINSCRIPCION", "Inscripcion");
                dgvClient.Columns.Add("CLITELEFONO", "Telefono");
                dgvClient.Columns.Add("CLIDIRECCION", "Direccion");
                dgvClient.Columns.Add("CLISALDOPENDIENTE", "Saldo Pendiente");

                dgvClient.Rows.Clear();
                cn = conexionDataBasse.sqlNewConect();
                cmd = new SqlCommand("SELECT * FROM CLIENTE WHERE CLIENABLE LIKE 1", cn);
                sqlDR = cmd.ExecuteReader();

                while (sqlDR.Read())
                {
                    dtoClient objClient = new dtoClient();
                    objClient.IDCLIENTE = int.Parse(sqlDR["IDCLIENTE"].ToString());
                    objClient.CLIIDENTIFICACION = sqlDR.GetString(1);
                    objClient.CLINOMBRES = sqlDR.GetString(2)+" "+ sqlDR.GetString(3);
                    objClient.CLIAPELLIDOS = sqlDR.GetString(4)+" "+ sqlDR.GetString(5);
                    objClient.CLIFECHANACIMIENTO = sqlDR.GetDateTime(6);
                    objClient.CLIFECHAINSCRIPCION = sqlDR.GetDateTime(7);
                    objClient.CLITELEFONO = sqlDR.GetString(8);
                    objClient.CLIDIRECCION = sqlDR.GetString(9);
                    objClient.CLISALDOPENDIENTE = float.Parse(sqlDR["CLISALDOPENDIENTE"].ToString());
                    if (objClient.CLISALDOPENDIENTE == 0)
                        balance = objClient.CLISALDOPENDIENTE.ToString();
                    else
                    {
                        if (objClient.CLISALDOPENDIENTE < 0)
                            balance = (objClient.CLISALDOPENDIENTE * -1).ToString() + " a favor";
                        else
                            balance = objClient.CLISALDOPENDIENTE.ToString() + " pendiente";
                    }
                    dgvClient.Rows.Add(objClient.IDCLIENTE.ToString(), objClient.CLIIDENTIFICACION, objClient.CLINOMBRES, objClient.CLIAPELLIDOS, objClient.CLIFECHANACIMIENTO.ToString("dd/MM/yyyy"), objClient.CLIFECHAINSCRIPCION.ToString("dd/MM/yyyy"), objClient.CLITELEFONO, objClient.CLIDIRECCION, balance);
                }
                dgvClient.Columns["IDCLIENTE"].Visible = false;
                dgvClient.ClearSelection();
                dgvClient.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo Cargar los Clientes, Error:" + ex.Message);
            }
        }

        //funcion Para recargar Clientes despues de borrado o modificado
        public void reChargeClient(DataGridView dgvClient)
        {
            String balance=" ";
            try
            {
                dgvClient.Rows.Clear();
                cn = conexionDataBasse.sqlNewConect();
                cmd = new SqlCommand("SELECT * FROM CLIENTE WHERE CLIENABLE LIKE 1", cn);
                sqlDR = cmd.ExecuteReader();

                while (sqlDR.Read())
                {
                    dtoClient objClient = new dtoClient();
                    objClient.IDCLIENTE = int.Parse(sqlDR["IDCLIENTE"].ToString());
                    objClient.CLIIDENTIFICACION = sqlDR.GetString(1);
                    objClient.CLINOMBRES = sqlDR.GetString(2) + " " + sqlDR.GetString(3);
                    objClient.CLIAPELLIDOS = sqlDR.GetString(4) + " " + sqlDR.GetString(5);
                    objClient.CLIFECHANACIMIENTO = sqlDR.GetDateTime(6);
                    objClient.CLIFECHAINSCRIPCION = sqlDR.GetDateTime(7);
                    objClient.CLITELEFONO = sqlDR.GetString(8);
                    objClient.CLIDIRECCION = sqlDR.GetString(9);
                    objClient.CLISALDOPENDIENTE = float.Parse(sqlDR["CLISALDOPENDIENTE"].ToString());
                    if (objClient.CLISALDOPENDIENTE == 0)
                        balance = objClient.CLISALDOPENDIENTE.ToString();
                    else
                    {
                        if (objClient.CLISALDOPENDIENTE < 0)
                            balance = (objClient.CLISALDOPENDIENTE*-1).ToString() + " a favor";
                        else
                            balance = objClient.CLISALDOPENDIENTE.ToString() + " pendiente";
                    }
                    dgvClient.Rows.Add(objClient.IDCLIENTE.ToString(), objClient.CLIIDENTIFICACION, objClient.CLINOMBRES, objClient.CLIAPELLIDOS, objClient.CLIFECHANACIMIENTO.ToString("dd/MM/yyyy"), objClient.CLIFECHAINSCRIPCION.ToString("dd/MM/yyyy"), objClient.CLITELEFONO, objClient.CLIDIRECCION, balance);
                }
                dgvClient.Columns["IDCLIENTE"].Visible = false;
                dgvClient.ClearSelection();
                dgvClient.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo Cargar los Clientes, Error:" + ex.Message);
            }
        }

        //funcion para desactivar algun cliente 

        public String DeleteClient(String idClient)
        {

            string salida = "Se Elimino Correctamente el campo ";
            cn = conexionDataBasse.sqlNewConect();
            try
            {
                cmd = new SqlCommand("UPDATE CLIENTE SET  cliEnable = '0' WHERE idCliente = '" + idClient + "'", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se pudo actualizar : " + ex.ToString();
            }
            return salida;
        }

        //Funcion para la busqueda de Clientes por nombres, apellidos o cedula 
        public void searchClient(String word, DataGridView dgvClient)
        {
            try
            {
                dgvClient.Rows.Clear();
                cn = conexionDataBasse.sqlNewConect();
                cmd = new SqlCommand("SELECT * FROM CLIENTE WHERE  (CLIIDENTIFICACION LIKE '" + word.ToString() + "' or CLINOMBRE LIKE '" + word.ToString() + "' or CLIAPELLIDOPATERNO LIKE '" + word.ToString() + "') AND CLIENABLE LIKE 1 ", cn);
                sqlDR = cmd.ExecuteReader();

                while (sqlDR.Read())
                {
                    dtoClient objClient = new dtoClient();
                    objClient.IDCLIENTE = int.Parse(sqlDR["IDCLIENTE"].ToString());
                    objClient.CLIIDENTIFICACION = sqlDR.GetString(1);
                    objClient.CLINOMBRES = sqlDR.GetString(2) + " " + sqlDR.GetString(3);
                    objClient.CLIAPELLIDOS = sqlDR.GetString(4) + " " + sqlDR.GetString(5);
                    objClient.CLIFECHANACIMIENTO = sqlDR.GetDateTime(6);
                    objClient.CLIFECHAINSCRIPCION = sqlDR.GetDateTime(7);
                    objClient.CLITELEFONO = sqlDR.GetString(8);
                    objClient.CLIDIRECCION = sqlDR.GetString(9);
                    objClient.CLISALDOPENDIENTE = float.Parse(sqlDR["CLISALDOPENDIENTE"].ToString());
                    dgvClient.Rows.Add(objClient.IDCLIENTE.ToString(), objClient.CLIIDENTIFICACION, objClient.CLINOMBRES, objClient.CLIAPELLIDOS, objClient.CLIFECHANACIMIENTO.ToString("dd/MM/yyyy"), objClient.CLIFECHAINSCRIPCION.ToString("dd/MM/yyyy"), objClient.CLITELEFONO, objClient.CLIDIRECCION, objClient.CLISALDOPENDIENTE.ToString());
                }
                dgvClient.Columns["IDCLIENTE"].Visible = false;
                dgvClient.ClearSelection();
                dgvClient.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // LLenar Ventana de modificar desde el dataGrid

        public void FillTextBoxModifyClient(String id, TextBox txtIdentification, TextBox txtName, TextBox txtSecondName, TextBox txtMiddleName,
                                            TextBox txtLastName, DateTimePicker dateBorn, TextBox txtPhone, TextBox txtAddress)
        {
            cn = conexionDataBasse.sqlNewConect();
            try
            {
                cmd = new SqlCommand("Select * from CLIENTE where idCliente = " + id + "", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    txtIdentification.Text = dr["cliIdentificacion"].ToString();
                    txtName.Text = dr["cliNombre"].ToString();
                    txtSecondName.Text = dr["cliSegundoNombre"].ToString();
                    txtLastName.Text = dr["cliApellidoPaterno"].ToString();
                    txtMiddleName.Text = dr["cliApellidoMaterno"].ToString();
                    txtPhone.Text = dr["cliTelefono"].ToString();
                    txtAddress.Text = dr["cliDireccion"].ToString();
                    dateBorn.Value = Convert.ToDateTime(dr["cliFechaNacimiento"].ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llegar los campos :" + ex.ToString());
            }

        }


        //Funcion para modificar la lista de usuarios

        public string ModifyClientInDataBase(string IdClient, string identification, string secondName, string name, string middlename, string lastname, string dateborn, string phone, string address)
        {
            string salida = "Se Modifico Correctamente el campo ";
            cn = conexionDataBasse.sqlNewConect();
            try
            {
                cmd = new SqlCommand("UPDATE CLIENTE SET cliIdentificacion = '" + identification + "',cliNombre ='" + name + "', cliSegundoNombre ='" + secondName + "',cliApellidoMaterno = '" + middlename + "', cliApellidoPaterno ='" + lastname + "', cliFechaNacimiento = '" + dateborn + "', cliTelefono = '" + phone + "', cliDireccion = '" + address + "' WHERE idCliente = '" + IdClient + "'", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se pudo actualizar : " + ex.ToString();
            }
            cn.Close();
            return salida;

        }
    }
}
