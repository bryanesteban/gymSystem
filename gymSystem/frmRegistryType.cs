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
    public partial class frmRegistryType : Form
    {
        funTypeMembership objTypeMembership = new funTypeMembership();
        public frmRegistryType()
        {
            InitializeComponent();
        }

        private void btnInsertType_Click(object sender, EventArgs e)
        {
            frmTypeMembershipInsert objRegistryInsert = new frmTypeMembershipInsert(dgvTypeMembership);
            objRegistryInsert.Show();
        }

        private void frmRegistryType_Load(object sender, EventArgs e)
        {
            funTypeMembership objTypeMembership = new funTypeMembership();
            objTypeMembership.chargeTypeMembership(dgvTypeMembership);
        }

        private void btnModifyType_Click(object sender, EventArgs e)
        {
            String IdTypeMembershipDgv = this.dgvTypeMembership.CurrentRow.Cells[0].Value.ToString();
            frmTypeMembershipModify objClientModify = new frmTypeMembershipModify(IdTypeMembershipDgv, dgvTypeMembership);
            objClientModify.Show();
        }

        private void btnDeleteType_Click(object sender, EventArgs e)
        {
            String IdTypeMembershipDgv = this.dgvTypeMembership.CurrentRow.Cells[0].Value.ToString();
            String resultado = objTypeMembership.DeleteTypeMembership(IdTypeMembershipDgv, dgvTypeMembership);
            MessageBox.Show(resultado);
        }
    }
}
