using gymSystem.Clases;
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
    public partial class frmMembershipModify : Form
    {
        String codeClient;
        funClient objFunClient = new funClient();
        csClient objClient;
        String idMembershipPass ="";
        DataGridView dgvMembershipPass;
        funMembership objMembership = new funMembership();
        funPayments objPayments = new funPayments();
        public frmMembershipModify()
        {
            InitializeComponent();
        }
        public frmMembershipModify(DataGridView dgvMembership,String idMembership)
        {
            InitializeComponent();
            idMembershipPass = idMembership;
            dgvMembershipPass = dgvMembership;
            objMembership.fillMembershipType(cmbTypeMembership);
            chargeModify();
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
                        String resultAgreeMembership = objMembership.modifyMembership(idMembershipPass,codeClient, valueTypeMembershipcmb.ToString(), txtAbono.Text, dgvMembershipPass);
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
            }
            else
            {
                MessageBox.Show("Ingrese un Usuario");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            frmAddUser objAddUser = new frmAddUser();
            if (objAddUser.ShowDialog() == DialogResult.OK)
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

        //carga los datos que se podran modificar
        public void chargeModify()
        {
            csMembership membershipDetails = objMembership.foundOneMembership(idMembershipPass);
            codeClient = membershipDetails.IDCLIENTE1.ToString();
            objClient = objFunClient.findClient(membershipDetails.IDCLIENTE1.ToString());
            //carga los datos de usuario
            txtIdentificationClient.Text = objClient.CLIIDENTIFICACION1.ToString();
            txtNamesClient.Text = objClient.CLINOMBRE1.ToString() + " " + objClient.CLISEGUNDONOMBRE1.ToString();
            txtLastNameClient.Text = objClient.CLIAPELLIDOPATERNO1.ToString() + " " + objClient.CLIAPELLIDOMATERNO1.ToString();
            //carga la seleccion del combobox
            cmbTypeMembership.SelectedValue = membershipDetails.IDTIPOMEM1;
            //cargar el saldo que se cargo en un principio
            csPayments objPaymentInfo= objPayments.foundPayments(membershipDetails.IDMEMBRESIA1.ToString(),"MEMBRESIA");
            txtAbono.Text = objPaymentInfo.PAGOVALOR.ToString();
        }
    }
}
