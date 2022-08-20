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
    public partial class frmClientEntry : Form

    {
        DataGridView dgvClientPass;
        //ingreso de nuevo cliente en la base de datos
        funClient entrynew = new funClient();
        public frmClientEntry()
        {
            InitializeComponent();
        }
        public frmClientEntry(DataGridView dgvClient)
        {
            InitializeComponent();
            dgvClientPass = dgvClient;
        }
        private void btnCancelSaveClient_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSaveClient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdentification.Text.Trim()) == false && string.IsNullOrEmpty(txtName.Text.Trim()) == false && string.IsNullOrEmpty(txtMiddleName.Text.Trim()) == false &&
                string.IsNullOrEmpty(txtLastName.Text.Trim()) == false && string.IsNullOrEmpty(txtAddress.Text.Trim()) == false && string.IsNullOrEmpty(txtPhone.Text.Trim()) == false &&
                string.IsNullOrEmpty(txtSecondName.Text.Trim()) == false) { 
                if (entrynew.personaRegistrada(txtIdentification.Text.ToString()) == 0)
                {
                    DateTime DateBornPick = dateBorn.Value.Date;
                    DateTime DateInscriptionPick = dateRegistry.Value.Date;
                    String DateBornText = DateBornPick.ToString("yyyy/MM/dd");
                    String DateInscriptionText = DateInscriptionPick.ToString("yyyy/MM/dd");
                    MessageBox.Show(entrynew.insertClint(txtIdentification.Text, txtName.Text,txtSecondName.Text , txtMiddleName.Text,
                                                       txtLastName.Text, DateBornText, DateInscriptionText, txtPhone.Text, txtAddress.Text,dgvClientPass));
                    txtIdentification.Text = "";
                    txtName.Text = "";
                    txtMiddleName.Text = "";
                    txtLastName.Text = "";
                    txtAddress.Text = "";
                    txtPhone.Text = "";
                    txtSecondName.Text = "";

                }
                else
                {
                    MessageBox.Show("Imposible registrar, El registro ya existe");
                }
            }
            else
            {
                MessageBox.Show("Debe completar todas las casillas primero");
            }
        }

        private void txtIdentification_KeyPress(object sender, KeyPressEventArgs e)
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
