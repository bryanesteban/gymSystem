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
    public partial class frmClientModify : Form
    {
        String idClientCatch;
        funClient objRegistryClient = new funClient();
        public frmClientModify()
        {
            InitializeComponent();
        }

        public frmClientModify(String idClient)
        {
            InitializeComponent();
            idClientCatch = idClient;
            objRegistryClient.FillTextBoxModifyClient(idClient, txtIdentification, txtName, txtSecondName, txtMiddleName, txtLastName, dateBorn, txtPhone, txtAddress);
        }

        private void btnModifyClient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdentification.Text.Trim()) == false && string.IsNullOrEmpty(txtName.Text.Trim()) == false && string.IsNullOrEmpty(txtMiddleName.Text.Trim()) == false &&
       string.IsNullOrEmpty(txtLastName.Text.Trim()) == false && string.IsNullOrEmpty(txtAddress.Text.Trim()) == false && string.IsNullOrEmpty(txtPhone.Text.Trim()) == false &&
       string.IsNullOrEmpty(txtSecondName.Text.Trim()) == false)
            {

                    DateTime DateBornPick = dateBorn.Value.Date;
                    String dateBornText = DateBornPick.ToString("yyyy/MM/dd");
                    String respuesta = objRegistryClient.ModifyClientInDataBase(idClientCatch, txtIdentification.Text, txtName.Text, txtSecondName.Text,
                                                             txtMiddleName.Text, txtLastName.Text, dateBornText, txtPhone.Text, txtAddress.Text);


                Close();
                MessageBox.Show(respuesta);

            }
            else
            {
                MessageBox.Show("Debe completar todas las casillas primero");
            }
        }

        private void btnCancelModifyClient_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnModifyClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
