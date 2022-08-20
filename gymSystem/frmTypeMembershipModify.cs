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
    public partial class frmTypeMembershipModify : Form
    {
        String catchIdTypeMembership;
        DataGridView dgvCatchTypeMembership;
        funTypeMembership objTypeMembership = new funTypeMembership();
        public frmTypeMembershipModify()
        {
            InitializeComponent();
        }
        public frmTypeMembershipModify(string idTypeMembership, DataGridView dgvTypeMembership)
        {
            InitializeComponent();
            catchIdTypeMembership = idTypeMembership;
            dgvCatchTypeMembership = dgvTypeMembership;
            objTypeMembership.FillTextBoxModifyTypeMembership(idTypeMembership, txtNameMembership, txtQuantityOfDays, txtPrizeMembership);

        }


        private void btnCancelSaveMembershipType_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSaveMemberShipType_Click(object sender, EventArgs e)
        {
            frmTypeMembershipModify objTypeMembershipModify = new frmTypeMembershipModify();
            String result = objTypeMembership.ModifyTypeMembeshipInDataBase(catchIdTypeMembership, txtNameMembership.Text, txtQuantityOfDays.Text, txtPrizeMembership.Text, dgvCatchTypeMembership);
            MessageBox.Show(result);
            Close();
        }

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
