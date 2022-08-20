using gymSystem.Funciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gymSystem
{
    public partial class frmProductInsert : Form
    {
        public frmProductInsert()
        {
            InitializeComponent();
        }
        funProduct objProduct = new funProduct();
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtNameProduct.Text.Trim()) == false)
            {
                if(string.IsNullOrEmpty(txtBarCode.Text.Trim()) == false)
                {
                    if (string.IsNullOrEmpty(txtSupplier.Text.Trim()) == false)
                    {
                        if (string.IsNullOrEmpty(txtCost.Text.Trim()) == false)
                        {
                            if (string.IsNullOrEmpty(txtPrize.Text.Trim()) == false)
                            {
                               String resultado = objProduct.InsertProduct(txtNameProduct.Text, txtBarCode.Text, txtNameProduct.Text, txtCost.Text, txtPrize.Text);
                                MessageBox.Show(resultado);
                            }
                            else
                            {
                                MessageBox.Show("Ingrese un precio Valido!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ingrese un costo Valido!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un Proveedor Valido!");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un codigo de barras Valido!");
                }
            }else
            {
                MessageBox.Show("Ingrese el Nombre del Producto!");
            }
        }
    }
}
