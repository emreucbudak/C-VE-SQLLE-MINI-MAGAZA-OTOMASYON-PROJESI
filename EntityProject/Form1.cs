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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        EntityUrunEntities db = new EntityUrunEntities();
        private void button4_Click(object sender, EventArgs e)
        {
            // listelerken listeyi değişkene attık veritabanıadı.tabloadı.tolist methoduyla onu çağırdık
            var kategoriler  = db.TBLKATEGORİ.ToList();
            dataGridView1.DataSource = kategoriler;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //EKLERKEN TABLODAN NESNE OLUSTURUP ERİŞİCEZ
            TBLKATEGORİ tb = new TBLKATEGORİ();
            tb.AD = textBox2.Text;
            db.TBLKATEGORİ.Add(tb);
            db.SaveChanges();
            MessageBox.Show("KATEGORİ EKLENDİ ","BİLGİ",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            var ktgr = db.TBLKATEGORİ.Find(x);
            db.TBLKATEGORİ.Remove(ktgr);
            db.SaveChanges();
            //save changes execute non query ile aynıdır onu unutma!!!!
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            var ktgr = db.TBLKATEGORİ.Find(x);
            ktgr.AD = textBox2.Text;
            db.SaveChanges();
            MessageBox.Show("Güncelleme Yapıldı");
        }
    }
}
