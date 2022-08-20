using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gymSystem.Funciones
{
    class funProduct
    {
        conexionbd conexionDataBasse = new conexionbd();
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader sqlDR;
        DataTable dt;
        SqlDataAdapter da;

        //Funcion para insertar un nuevo producto
        public String InsertProduct(String nameProduct, String barCodeProduct, String supplier, String cost, String Prize)
        {

            
            String salida = "";
            try
            {
                if (verifyProduct(barCodeProduct) != true)
                {
                    cn = conexionDataBasse.sqlNewConect();
                    DateTime membershipInscription = DateTime.Now;
                    cmd = new SqlCommand("Insert into PRODUCTO(PRONOMBRE,PROCODIGOBARRAS,PRONOMPROVEEDOR,PROCOSTOUNIDAD,PROVALOR,PROEXISTENCIA,PROENABLE) values('" + nameProduct + "','" + barCodeProduct + "','" + supplier + "','" + cost + "','" + Prize +"','0','1')", cn);
                    cmd.ExecuteNonQuery();
                    salida = "Se creo Satisfactoriamente el nuevo producto";
                    nameProduct = "";
                }
                else
                {
                    salida = " No se pudo Insertar el Producto: " + nameProduct + " porque ya existe";

                }
                
            }
            catch (Exception ex)
            {
                salida = "No se pudo Ingresar el Nuevo Producto, Error : " + ex.ToString();
            }

            return salida;
        }

        public Boolean verifyProduct(String barCodeProduct)
        {
            cn = conexionDataBasse.sqlNewConect();
            Boolean resultado = false;
            try
            {
                cmd = new SqlCommand("SELECT CASE WHEN EXISTS ( SELECT * FROM PRODUCTO Where PROCODIGOBARRAS =  '" + barCodeProduct + "' and PROENABLE = '1' ) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END", cn);
                sqlDR = cmd.ExecuteReader();
                while (sqlDR.Read())
                {
                    resultado = sqlDR.GetBoolean(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" No se pudo verificar la existencia de Productos con el codigo de barras: " + barCodeProduct + ", Error : " + ex.ToString());
            }
            sqlDR.Close();

            return resultado;
        }
    }
}
