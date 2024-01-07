using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace entity
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void btnCategorıes_Click(object sender, EventArgs e)
        {
            FrmCategories frm = new FrmCategories();
            frm.Show();
            this.Hide();

        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            FrmProduct frm= new FrmProduct();  
            frm.Show();
            this.Hide();    

        }

        private void btnStatics_Click(object sender, EventArgs e)
        {
            FrmStatics frm=new FrmStatics();
            frm.Show();
            this.Hide();


        }
    }
}
