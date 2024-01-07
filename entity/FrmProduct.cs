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

namespace entity
{
    public partial class FrmProduct : Form
    {
        public FrmProduct()
        {
            InitializeComponent();
        }

        public void temizle()
        {
            txtId.Clear();
            txtName.Clear();
            txtBrand.Clear();
            txtStock.Clear();
            txtPrice.Clear();
            txtState.Clear();
            cmbCategorıes.Text = "";
        }


        dbEntityUrunEntities1 db=new dbEntityUrunEntities1();
        private void btnListele_Click(object sender, EventArgs e)
        {

            var product = (from x in db.tbl_Product
                           select new
                           {
                              x.ProductId,
                              x.ProductName,
                              x.Price,
                              x.State,
                              x.Brand, x.Stock,
                           }

                        ).ToList();

            dataGridView1.DataSource= product;
           

           

          
           




        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text    = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtName.Text  = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtBrand.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtStock.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtPrice.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtState.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
           //cmbCategorıes.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            

            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            tbl_Product t = new tbl_Product();

            t.ProductName= txtName.Text;
            t.Brand=txtBrand.Text;
            t.Stock = short.Parse(txtStock.Text);
            t.Price =decimal.Parse(txtPrice.Text);
            t.Categories = int.Parse(cmbCategorıes.SelectedValue.ToString());
            t.State = true;
            db.SaveChanges();
            MessageBox.Show("Ekleme İşlemi Başarılı !!");

            db.tbl_Product.Add(t);
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {

            var categorıes = (from x in db.tbl_Categorıes
                              select new
                              {
                                 x.Id,
                                  x.Name
                              }



                            ).ToList();

            cmbCategorıes.ValueMember = "ID";
            cmbCategorıes.DisplayMember = "NAME";
            cmbCategorıes.DataSource = categorıes;



         


        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int removing = Int16.Parse(txtId.Text);
            var product = db.tbl_Product.Find(removing);

            db.tbl_Product.Remove(product);
            db.SaveChanges();
            MessageBox.Show("Silme İşlemi başarılı !!!");
            temizle();

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            int product = Int16.Parse(txtId.Text);
            var producted=db.tbl_Product.Find(product);

            producted.ProductName = txtName.Text;
            producted.Brand= txtBrand.Text;
            db.SaveChanges();
            MessageBox.Show("Güncelleme İşlemi Başarılı !!");




        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAnaForm frm = new FrmAnaForm();
            frm.Show();
            this.Hide();
             
        }
    }
}
