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


namespace BLOOD_BANK_MANAGEMENT_SYSTEM
{
    public partial class LOGIN : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=15081598-123-SE;Initial Catalog=BLOOD_BANK_MANAGEMENT_SYSTEM;Integrated Security=True");
       
        public LOGIN()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=15081598-123-SE;Initial Catalog=BLOOD_BANK_MANAGEMENT_SYSTEM;Integrated Security=True;");
       
            SqlDataAdapter sda = new SqlDataAdapter ("select count(*) from Login where Username = '"+textBox1.Text+"' and Password = '"+textBox2.Text+"' and Role='"+comboBox1.Text+"'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                SqlDataAdapter sda1 = new SqlDataAdapter("select Role from Login where Username = '" + textBox1.Text + "' and Password = '" + textBox2.Text + "' and Role='" + comboBox1.Text + "'", con);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);

                if (dt1.Rows[0][0].ToString() == "Manager")
                {
                     this.Hide();
                    MANAGER mm = new MANAGER();
                    mm.Show();

                }

                if (dt1.Rows[0][0].ToString() == "Clerk")
                {
                    this.Hide();
                    CLERK cl = new CLERK();
                    cl.Show();
                }


                if (dt1.Rows[0][0].ToString() == "lab-attendant")
            {
                this.Hide();
                LAB la = new LAB();
                la.Show();
            }

               

            }
            else 
           {
               MessageBox.Show("Invalid password or username");
           
           }
            

            


        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }
    }
}
