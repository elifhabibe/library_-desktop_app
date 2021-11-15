using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphaneson
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 f1 = new Form5();
            f1.Close();
            Form1 f2 = new Form1();
            f2.Show();

            this.Hide();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Model1 ent = new Model1();
            string aranacak = textBox1.Text;
            var query = ent.kitaps.ToList();
            var sonuc = query.Where(w => w.kitapad == aranacak).ToList();
            dataGridView1.DataSource = sonuc;
        }
    }
}
