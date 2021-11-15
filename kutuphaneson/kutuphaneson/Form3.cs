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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f1 = new Form3();
            f1.Close();
            Form1 f2 = new Form1();
            f2.Show();

            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        SqlConnection con;
        private void Form3_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=kutuphane2;Integrated Security=True");
            con.Open();
            SqlDataAdapter adap = new SqlDataAdapter("select * from uye", con);
            DataSet ds = new DataSet();
            adap.Fill(ds, "uye");
            dataGridView1.DataSource = ds.Tables["uye"];
            con.Close();
        }

        Model1 ent = new Model1();
        private void button1_Click(object sender, EventArgs e)
        {
            string a =textBox1.Text;
            uye u = ent.uyes.First(f => f.uyead == a);
            ent.uyes.Remove(u);
            ent.SaveChanges();
            dataGridView1.DataSource = ent.uyes.ToList();
        }
    }
}
