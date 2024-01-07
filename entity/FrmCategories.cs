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
    public partial class FrmCategories : Form
    {
        public FrmCategories()
        {
            InitializeComponent();
        }
        dbEntityUrunEntities1 db=new dbEntityUrunEntities1();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            var categorıess = db.tbl_Categorıes.ToList();
            dataGridView1.DataSource = categorıess;








                
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            tbl_Categorıes table = new tbl_Categorıes();

            table.Id = Int16.Parse(textBox1.Text);
            table.Name = textBox2.Text;

            db.tbl_Categorıes.Add(table);
            db.SaveChanges();
            MessageBox.Show("Kayıt İşlemi Başarılı","Bilgilendirme");









          
           
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            int x = Int16.Parse(textBox1.Text);
            var ktg = db.tbl_Categorıes.Find(x);

            db.tbl_Categorıes.Remove(ktg);
            db.SaveChanges();
            MessageBox.Show("İşlem Başarılı !!","Bilgilendirme");







        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            var ktg = db.tbl_Categorıes.Find(x);

            ktg.Name= textBox2.Text;
            db.SaveChanges();
            MessageBox.Show("Kayıt İşlemi Başarılı","Bilgilendirme ");




            




        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();



        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            FrmAnaForm frm = new FrmAnaForm();
            frm.Show();
            this.Hide();

        }
    }
}
