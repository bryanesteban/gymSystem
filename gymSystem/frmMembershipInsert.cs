using gymSystem.Clases;
using gymSystem.Funciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gymSystem
{
    public partial class frmMembershipInsert : Form
    {
         
        funMembership memberShipInsertObj = new funMembership();
        funClient objFunClient = new funClient();
        String codeClient;
        csClient objClient;
        DataGridView dgvMembership;
        public frmMembershipInsert()
        {
            InitializeComponent();
            memberShipInsertObj.fillMembershipType(cmbTypeMembership);

        }

        public frmMembershipInsert(DataGridView dgvMembershippass)
        {
            InitializeComponent();
            memberShipInsertObj.fillMembershipType(cmbTypeMembership);
            dgvMembership = dgvMembershippass;
        }

        private void btnAddNewMembership_Click(object sender, EventArgs e)
        {
            frmAddUser objAddUser = new frmAddUser();
            if(objAddUser.ShowDialog() == DialogResult.OK)
            {
                codeClient = objAddUser.CodeClient;
                if (codeClient != null && codeClient != "")
                {
                    objClient = objFunClient.findClient(codeClient);
                    txtIdentificationClient.Text = objClient.CLIIDENTIFICACION1.ToString();
                    txtNamesClient.Text = objClient.CLINOMBRE1.ToString() + " " + objClient.CLISEGUNDONOMBRE1.ToString();
                    txtLastNameClient.Text = objClient.CLIAPELLIDOPATERNO1.ToString() + " " + objClient.CLIAPELLIDOMATERNO1.ToString();
                }
            }
        }

        private void btnAgree_Click(object sender, EventArgs e)
        {
            int valueTypeMembershipcmb = (int)cmbTypeMembership.SelectedValue;
            if (txtIdentificationClient.Text.Length != 0)
            {

                if (txtAbono.Text.Length != 0)
                {
                    if (valueTypeMembershipcmb != 0)
                    {
                        String resultAgreeMembership=memberShipInsertObj.InsertMembership(codeClient, valueTypeMembershipcmb.ToString(), float.Parse(txtAbono.Text), dgvMembership);
                        MessageBox.Show(resultAgreeMembership);
                        if (resultAgreeMembership.Equals("Se creo Satisfactoriamente la nueva memebresia"))
                        {
                            Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un tipo de Membresia Valido");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese el abono que realizara el usuario");
                }
            }else
            {
                MessageBox.Show("Ingrese un Usuario");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtAbono_KeyPress(object sender, KeyPressEventArgs e)
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
