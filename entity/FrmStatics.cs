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
    public partial class FrmStatics : Form
    {
        public FrmStatics()
        {
            InitializeComponent();
        }

        dbEntityUrunEntities1 db=new dbEntityUrunEntities1();   
        private void frmStatics_Load(object sender, EventArgs e)
        {
            label2.Text  = db.tbl_Categorıes.Count().ToString();  // kategori sayısı
            label3.Text  = db.tbl_Product.Count().ToString();   // ürün sayısı
            label5.Text  = db.tbl_Customer.Count(x=> x.state==true).ToString();  // aktif müşteri sayısı
            label7.Text  = db.tbl_Customer.Count(x=>x.state==false).ToString(); // pasif müşteri sayısı
            label11.Text = db.tbl_Product.Sum(x=> x.Stock).ToString();   // toplam stok sayısı
            label19.Text = db.tbl_Sales.Sum(x=> x.Price).ToString();     // kasadaki tutar
            label9.Text  = db.tbl_Product.Count(x=> x.Categories==1).ToString(); // Beyaz Eşya Adedi
            label23.Text = db.tbl_Product.Count(x=> x.ProductName== "Fridge").ToString(); // Buzdolabı Adedi
            label17.Text = (from x in db.tbl_Customer select x.City).Distinct().Count().ToString(); // Şehirleri Saydırma


                            


            label13.Text = (from x in db.tbl_Product orderby x.Price descending select x.ProductName).FirstOrDefault();  // En Yüksek Fiyatlı Ürün
            label15.Text = (from y in db.tbl_Product orderby y.Price ascending select y.ProductName).FirstOrDefault();   // En Düşük Fiyatlı Ürün
            label21.Text = db.brandTake().FirstOrDefault();

            






           




          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmAnaForm frm = new FrmAnaForm();
            frm.Show();
            this.Hide();
        }
    }
}
