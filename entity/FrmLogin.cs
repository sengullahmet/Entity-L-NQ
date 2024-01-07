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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

           


        }
        dbEntityUrunEntities1 db=new dbEntityUrunEntities1();
        private void button1_Click(object sender, EventArgs e)
        {

            var kosul = from x in db.tblAdmin
                        where x.UserName == txtUser.Text && x.Password == txtPass.Text
                        select x;

            if (kosul.Any()==true)
            {
                FrmAnaForm frm = new FrmAnaForm();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giriş İşlemi Başarısız !! ","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }



        }
    }
}
