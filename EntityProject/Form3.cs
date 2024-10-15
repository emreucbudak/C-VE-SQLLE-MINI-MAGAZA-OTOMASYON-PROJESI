using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityProject
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        EntityUrunEntities db = new EntityUrunEntities();
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.URUNLER select new { x.URUNID, x.URUNAD, x.URUNMARKA, x.DURUM, x.FİYAT, x.TBLKATEGORİ.AD }).ToList();
            //TOLİSTİ UNUTMA !!!!!!! LİSTELEMEK İÇİN
    }

        private void button2_Click(object sender, EventArgs e)
        {
            URUNLER urun = new URUNLER();
            urun.URUNAD = textBox2.Text;
            urun.URUNMARKA = textBox3.Text;
            urun.STOK = short.Parse(textBox4.Text);
            urun.KATEGORİ = int.Parse(comboBox1.SelectedValue.ToString());
            urun.FİYAT = int.Parse(textBox5.Text);
            urun.DURUM = true;
            db.URUNLER.Add(urun);
            db.SaveChanges();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            var ktgr = db.URUNLER.Find(x);
            db.URUNLER.Remove(ktgr);
            db.SaveChanges();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            var urn = db.URUNLER.Find(x);
            urn.URUNAD = textBox2.Text;
            urn.URUNMARKA = textBox3.Text;
            urn.STOK = short.Parse(textBox4.Text);
            urn.FİYAT = int.Parse(textBox5.Text);
            urn.DURUM = true;
            db.SaveChanges();
            MessageBox.Show("Güncelleme Yapıldı");
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            var kategoriler = (from x in db.TBLKATEGORİ select new
            {
                x.ID,
                x.AD
            } ).ToList();
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "AD";
            comboBox1.DataSource = kategoriler;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text = comboBox1.SelectedValue.ToString();
        }
    }
}
