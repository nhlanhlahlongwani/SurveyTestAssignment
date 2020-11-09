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
//using System.Data;

namespace Part2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public double grp1 = 0;
        public double grp2 = 0;
        public double grp3 = 0;
        public double grp4 = 0;
        public double grp5 = 0;
        public int total = 20;
    public  SqlConnection con = new SqlConnection(@"Data Source=TIYANI;Initial Catalog=ConnectionDb;Integrated Security=True");
        private void button2_Click(object sender, EventArgs e)
        {
     
           try
           {

             

                SqlCommand cmd = new SqlCommand(@"INSERT INTO userDetails (userSurname,userName,contactNo,userDate,age) VALUES ('" + txtSurname.Text + "','" + txtFName.Text + "', '" + txtCNumber.Text + "', '" + txtDate.Text + "', '" + txtAge.Text + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
      

            }
            catch (Exception eee)
            {
                MessageBox.Show("Error" + eee);
            }

           
            
            radioButtons();
            this.Hide();
            var form = new Form1();
            form.Closed += (s, args) => this.Close();
            MessageBox.Show("successfully registered");
            form.Show();

           

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Good day click okey to fill out form!!!");
        }

        
        public void radioButtons()
        {
            try
            {
                foreach (string chk in checkedListBox1.CheckedItems)
                {

                     SqlCommand cmd2 = new SqlCommand(@"INSERT INTO surveyinfo (Fav_Food) VALUES ('" + chk + "')", con);
                      con.Open();
                      cmd2.ExecuteNonQuery();
                      con.Close();
                   
                    

                }
              
                if (this.radioButton1.Checked)
                {
                    grp1 = 1;
                    SqlCommand cmd2 = new SqlCommand(@"INSERT INTO surveyinfo (eat_out) VALUES ('" + grp1 + "')", con);
                    con.Open();
                    cmd2.ExecuteNonQuery();
                    con.Close();

                }
                if (this.radioButton2.Checked)
                {
                    grp1 = 2;
                    SqlCommand cmd2 = new SqlCommand(@"INSERT INTO surveyinfo (eat_out) VALUES ('"  + grp1 + "')", con);
                    con.Open();
                    cmd2.ExecuteNonQuery();
                    con.Close();
                }
                if (this.radioButton3.Checked)
                {
                    grp1 = 3;
                    SqlCommand cmd2 = new SqlCommand(@"INSERT INTO surveyinfo (eat_out) VALUES ('" +  grp1 + "')", con);
                    con.Open();
                    cmd2.ExecuteNonQuery();
                    con.Close();
                }
                if (this.radioButton4.Checked)
                {
                    grp1 = 4;
                    SqlCommand cmd2 = new SqlCommand(@"INSERT INTO surveyinfo (eat_out) VALUES ('" +grp1 + "')", con);
                    con.Open();
                    cmd2.ExecuteNonQuery();
                    con.Close();
                }
                if (this.radioButton5.Checked)
                {
                    grp1 = 5;
                    SqlCommand cmd2 = new SqlCommand(@"INSERT INTO surveyinfo (eat_out) VALUES ('" + grp1 + "')", con);
                    con.Open();
                    cmd2.ExecuteNonQuery();
                    con.Close();
                }
                if (this.radioButton10.Checked)
                {
                    grp2 = 1;
                    SqlCommand cmd2 = new SqlCommand(@"INSERT INTO surveyinfo (eat_out) VALUES ('" + grp2 + "')", con);
                    con.Open();
                    cmd2.ExecuteNonQuery();
                    con.Close();
                }
                if (this.radioButton9.Checked)
                {
                    grp2 = 2;
                    SqlCommand cmd2 = new SqlCommand(@"INSERT INTO surveyinfo (watch_movies) VALUES ('" + grp2 + "')", con);
                    con.Open();
                    cmd2.ExecuteNonQuery();
                    con.Close();
                }
                if (this.radioButton8.Checked)
                {
                    grp2 = 3;
                    SqlCommand cmd2 = new SqlCommand(@"INSERT INTO surveyinfo (watch_movies) VALUES ('" +grp2 + "')", con);
                    con.Open();
                    cmd2.ExecuteNonQuery();
                    con.Close();
                }
                if (this.radioButton7.Checked)
                {
                    grp2 = 4;
                    SqlCommand cmd2 = new SqlCommand(@"INSERT INTO surveyinfo (watch_movies) VALUES ('" + grp2 + "')", con);
                    con.Open();
                    cmd2.ExecuteNonQuery();
                    con.Close();
                }
                if (this.radioButton6.Checked)
                {
                    grp2 = 5;
                    SqlCommand cmd2 = new SqlCommand(@"INSERT INTO surveyinfo (watch_movies) VALUES ('" + grp2 + "')", con);
                    con.Open();
                    cmd2.ExecuteNonQuery();
                    con.Close();
                }
                if (this.radioButton15.Checked)
                {
                    grp3 = 1;
                    SqlCommand cmd2 = new SqlCommand(@"INSERT INTO surveyinfo (watch_TV) VALUES ('" + grp3 + "')", con);
                    con.Open();
                    cmd2.ExecuteNonQuery();
                    con.Close();
                }
                if (this.radioButton14.Checked)
                {
                    grp3 = 2;
                    SqlCommand cmd2 = new SqlCommand(@"INSERT INTO surveyinfo (watch_TV) VALUES ('" + grp3 + "')", con);
                    con.Open();
                    cmd2.ExecuteNonQuery();
                    con.Close();
                }
                if (this.radioButton13.Checked)
                {
                    grp3 = 3;
                    SqlCommand cmd2 = new SqlCommand(@"INSERT INTO surveyinfo (watch_TV) VALUES ('" + grp3 + "')", con);
                    con.Open();
                    cmd2.ExecuteNonQuery();
                    con.Close();
                }
                if (this.radioButton12.Checked)
                {
                    grp3 = 4;
                    SqlCommand cmd2 = new SqlCommand(@"INSERT INTO surveyinfo (watch_TV) VALUES ('" + grp3 + "')", con);
                    con.Open();
                    cmd2.ExecuteNonQuery();
                    con.Close();
                }
                if (this.radioButton11.Checked)
                {
                    grp3 = 5;
                    SqlCommand cmd2 = new SqlCommand(@"INSERT INTO surveyinfo (watch_TV) VALUES ('" + grp3 + "')", con);
                    con.Open();
                    cmd2.ExecuteNonQuery();
                    con.Close();
                }
                if (this.radioButton20.Checked)
                {
                    grp4 = 1;
                    SqlCommand cmd2 = new SqlCommand(@"INSERT INTO surveyinfo (lis_radio) VALUES ('" + grp4 + "')", con);
                    con.Open();
                    cmd2.ExecuteNonQuery();
                    con.Close();
                }
                if (this.radioButton19.Checked)
                {
                    grp4 = 2;
                    SqlCommand cmd2 = new SqlCommand(@"INSERT INTO surveyinfo (lis_radio) VALUES ('" + grp4 + "')", con);
                    con.Open();
                    cmd2.ExecuteNonQuery();
                    con.Close();
                }
                if (this.radioButton18.Checked)
                {
                    grp4 = 3;
                    SqlCommand cmd2 = new SqlCommand(@"INSERT INTO surveyinfo (lis_radio) VALUES ('" + grp4 + "')", con);
                    con.Open();
                    cmd2.ExecuteNonQuery();
                    con.Close();
                }
                if (this.radioButton17.Checked)
                {
                    grp4 = 4;
                    SqlCommand cmd2 = new SqlCommand(@"INSERT INTO surveyinfo (lis_radio) VALUES ('" + grp4 + "')", con);
                    con.Open();
                    cmd2.ExecuteNonQuery();
                    con.Close();
                }
                if (this.radioButton16.Checked)
                {
                    grp4 = 5;
                    SqlCommand cmd2 = new SqlCommand(@"INSERT INTO surveyinfo (lis_radio) VALUES ('" + grp4 + "')", con);
                    con.Open();
                    cmd2.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("error" + ee);
            }

           
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }

}