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
    public partial class frmPayments : Form
    {
        funPayments functionPayments = new funPayments();
        public frmPayments()
        {
            InitializeComponent();
            functionPayments.chargePayments(dgvPayments);
        }

        private void btnInsertPayment_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            String word = "%" + txtSearch.Text + "%";
            functionPayments.searchPayment(word, dgvPayments);
        }
    }
}
