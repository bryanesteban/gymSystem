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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            frmRegistryClient objClient = new frmRegistryClient();
            objClient.Show();
        }

        private void btnEntryClient_Click(object sender, EventArgs e)
        {
            frmClientEntry v1 = new frmClientEntry();
            v1.Show();
            //conexionbd c = new conexionbd();
        }

        private void btnregistryClient_Click(object sender, EventArgs e)
        {
            frmRegistryClient objRegistryClient = new frmRegistryClient();
            objRegistryClient.Show();
        }


        private void btnMembership_Click(object sender, EventArgs e)
        {
            frmMembership objMembership = new frmMembership();
            objMembership.Show();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            frmProduct objProduct = new frmProduct();
            objProduct.Show();
        }

        private void btnTypeMembership_Click(object sender, EventArgs e)
        {
            frmRegistryType ObjTypeMembership = new frmRegistryType();
            ObjTypeMembership.Show();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            frmPayments payments = new frmPayments();
            payments.Show();
        }
    }
}
