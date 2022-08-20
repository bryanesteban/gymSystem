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
    public partial class frmTypeMembershipInsert : Form
    {
        DataGridView dgvCatchTypeMembership;
        funTypeMembership objTypeMemberShipInsert = new funTypeMembership();
        String Mensaje;
       
        public frmTypeMembershipInsert()
        {
            InitializeComponent();
        }
        //recibe el datagrid de todos tipos de membresias 
        public frmTypeMembershipInsert(DataGridView dgvTypeMembership)
        {
            dgvCatchTypeMembership = dgvTypeMembership;
            InitializeComponent();
        }
        private void btnSaveMemberShipType_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNameMembership.Text.Trim()) == false || string.IsNullOrEmpty(txtQuantityOfDays.Text.Trim()) == false ||
                string.IsNullOrEmpty(txtPrizeMembership.Text.Trim()) == false)
            {
                Mensaje = objTypeMemberShipInsert.insertTypeMembership(txtNameMembership.Text, txtQuantityOfDays.Text, txtPrizeMembership.Text, dgvCatchTypeMembership);
                MessageBox.Show(Mensaje);
                txtNameMembership.Text = "";
                txtPrizeMembership.Text = "";
                txtQuantityOfDays.Text = "";
            }
            else
            {
                MessageBox.Show("Debe Llenar todos los campos primero");
            }
        }
        //cancela el ingreso de un nuevo tipo de membresia
        private void btnCancelSaveMembershipType_Click(object sender, EventArgs e)
        {
            Close();
        }


        //funcion de aplastado de teclas, no permite ingresar algo diferente de numeros o puntos
        private void txtQuantityOfDays_KeyPress(object sender, KeyPressEventArgs e)
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
        //funcion de aplastado de teclas, no permite ingresar algo diferente de numeros o puntos
        private void txtPrizeMembership_KeyPress(object sender, KeyPressEventArgs e)
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
