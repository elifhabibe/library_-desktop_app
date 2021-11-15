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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f1 = new Form4();
            f1.Close();
            Form1 f2 = new Form1();
            f2.Show();

            this.Hide();
        }
        SqlConnection con;
        private void Form4_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=kutuphane2;Integrated Security=True");
            con.Open();
            SqlDataAdapter adap = new SqlDataAdapter("select * from uye", con);
            DataSet ds = new DataSet();
            adap.Fill(ds, "uye");
            dataGridView1.DataSource = ds.Tables["uye"];
            con.Close();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            /*Model1 ent = new Model1();
            var Sonuc = from uye in ent.uyes
                        where uye.uyead == "elif"
                        select uye;
            foreach (var item in Sonuc)
            {
                listBox1.Items.Add(item.uyead + " - " + item.uyead);
            }*/
            Model1 ent = new Model1();
            int a = Convert.ToInt32(textBox1.Text);
            var Sonuc = from odunc in ent.oduncs
                        where odunc.uyeid ==a
                        group odunc by odunc.uyeid into Grup
                        select new
                        {
                            odunc = Grup,
                            uyeid = Grup.Key
                        };
            foreach (var item in Sonuc)
            {
                listBox1.Items.Add(item.uyeid + " id li müşteri " + item.odunc.Count() + " adet kitap almıştır.");
                foreach (var odunc in item.odunc)
                {
                    listBox1.Items.Add("-->" + odunc.kitapid);
                }
            }
        }
    }
}
