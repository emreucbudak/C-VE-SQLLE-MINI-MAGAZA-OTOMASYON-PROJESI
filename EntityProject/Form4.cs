using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityProject
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        EntityUrunEntities db = new EntityUrunEntities();
        private void Form4_Load(object sender, EventArgs e)
        {
            label2.Text = db.TBLKATEGORİ.Count().ToString();
            label5.Text = db.URUNLER.Count().ToString();
            label3.Text = db.MUSTERILER.Count(x => x.DURUM == true).ToString();
            label7.Text = db.MUSTERILER.Count(x => x.DURUM == false).ToString();
            label15.Text = db.URUNLER.Count(x => x.KATEGORİ == 2).ToString();
            label13.Text = db.URUNLER.Sum(y => y.STOK).ToString();
            label21.Text = db.TBLSATIS.Sum(y => y.FIYAT).ToString();
            label11.Text = (from x in db.URUNLER orderby x.FİYAT descending select x.FİYAT).FirstOrDefault().ToString();
            label9.Text = (from x in db.URUNLER orderby x.FİYAT ascending select x.FİYAT).FirstOrDefault().ToString();
            label23.Text = (from x in db.MUSTERILER select x.SEHIR).Distinct().Count().ToString();
            label17.Text = db.MARKABUL().FirstOrDefault().ToString();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }
    }
}
