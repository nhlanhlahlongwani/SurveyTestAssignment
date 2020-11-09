using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Part2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public SqlConnection con = new SqlConnection(@"Data Source=TIYANI;Initial Catalog=ConnectionDb;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 sw = new Form1();
            sw.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            con.Open();
            // string sqlQuery=
            SqlCommand cmd = new SqlCommand(@"select sum(eat_out) as [eat out total] from surveyinfo", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                  txtEat.Text = (dr["eat_out"].ToString());
                //label12.Text = (dr["eat_out"].ToString());
            }

            con.Close();



        }
    }
}
