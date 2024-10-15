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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EntityUrunEntities db = new EntityUrunEntities();
            var sorgu = (from x in db.GIRIS where textBox1.Text == x.KADI && textBox2.Text == x.SİFRE select x.ID );
            if (sorgu.Any())
            {
                Form2 form = new Form2();
                form.Show();
                this.Hide();
            }
            {
                
            }
        }
    }
}
