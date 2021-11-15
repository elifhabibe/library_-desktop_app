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

namespace kutuphaneson
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        SqlConnection con;
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f1 = new Form2();
            f1.Close();
            Form1 f2 = new Form1();
            f2.Show();

            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
       

        Model1 ent = new Model1();
        private void button1_Click(object sender, EventArgs e)
        {
            uye u = new uye(); 
            u.uyead= textBox1.Text;
            u.uyesoyad = textBox2.Text;
            u.adres=textBox3.Text;
            ent.uyes.Add(u);
            ent.SaveChanges();
            MessageBox.Show("kayıt eklendi");
            dataGridView1.DataSource = ent.uyes.ToList();
            
        }
    }
}
