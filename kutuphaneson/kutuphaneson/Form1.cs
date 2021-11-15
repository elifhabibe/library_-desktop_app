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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
            this.IsMdiContainer = true;
        }

        SqlConnection con;
        private void Form1_Load(object sender, EventArgs e)
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
            Form1 f1 = new Form1();
            f1.Close();
            Form2 f2 = new Form2();
            f2.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Close();
            Form3 f2 = new Form3();
            f2.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Close();
            Form4 f2 = new Form4();
            f2.Show();

            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Close();
            Form5 f2 = new Form5();
            f2.Show();

            this.Hide();
        }
        Model1 ent = new Model1();
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                List<uye> liste1 = ent.uyes.OrderByDescending(p => p.uyead).ToList();
                dataGridView1.DataSource = liste1;
            }

        }
       
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
                if (radioButton1.Checked == true)
                {
                    List<uye> liste1 = ent.uyes.OrderBy(p => p.uyead).ToList();
                    dataGridView1.DataSource = liste1;
                }
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var sorgu = from d1 in ent.kitaps
                        join d2 in ent.yazars
                        on d1.kitapid equals d2.yazarid
                        select new
                        {
                            yazar = d2.yazarad,
                            kitabı = d1.kitapad

                        };
            dataGridView1.DataSource = sorgu.ToList();
        }
    }
}
