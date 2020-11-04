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
    public partial class CLERK : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=15081598-123-SE;Initial Catalog=BLOOD_BANK_MANAGEMENT_SYSTEM;Integrated Security=True");
       
        public CLERK()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from EMPLOYEE where POSITION = 'clerk'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       
        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into DONOR values (" + textBox2.Text + ",'" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "'," + textBox6.Text + ",'" + textBox7.Text + "','" + textBox8.Text + "')";
            cmd.ExecuteNonQuery();

            con.Close();
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            disp_data();
            MessageBox.Show("values are inserted successfully");
        }
        public void disp_data()
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from DONOR";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();



        }
        private void CLERK_Load(object sender, EventArgs e)
        {
            disp_data();
            disp_data1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update DONOR set D_ID=" + textBox2.Text + ",NAME='" + textBox3.Text + "',FATHER_NAME='" + textBox4.Text + "',D_ADDRESS='" + textBox5.Text + "',PHONE_NUMBER=" + textBox6.Text + ",WISH_TO_DONATE_AGAIN='" + textBox7.Text + "',BLOOD_GROUP='" + textBox8.Text + "' where D_ID ="+textBox1.Text+"";
            cmd.ExecuteNonQuery();

            con.Close();
            disp_data();
            MessageBox.Show("values UPDATED successfully");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from DONOR where D_ID=" + textBox9.Text + "";
            cmd.ExecuteNonQuery();

            con.Close();
            disp_data();
            MessageBox.Show("values deleted successfully");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from DONOR where D_ID=" + textBox10.Text + "";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
            MessageBox.Show("values searched successfully");
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into PATIENT values (" + textBox12.Text + ",'" + textBox13.Text + "','" + textBox14.Text + "','" + textBox15.Text + "','" + textBox16.Text + "','" + textBox17.Text + "'," + textBox18.Text + ",'" + textBox19.Text + "')";
            cmd.ExecuteNonQuery();

            con.Close();
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
            textBox17.Text = "";
            textBox18.Text = "";
            textBox19.Text = "";
            disp_data1();
            MessageBox.Show("values are inserted successfully");
        }
        public void disp_data1()
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from PATIENT";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView3.DataSource = dt;
            con.Close();



        }

        private void button6_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update PATIENT set P_ID=" + textBox12.Text + ",NAME='" + textBox13.Text + "',FATHER_NAME='" + textBox14.Text + "',P_ADDRESS='" + textBox15.Text + "',GENDER='" + textBox16.Text + "',DISEASE='" + textBox17.Text + "',Donor_ID=" + textBox18.Text + ",BLOOD_GROUP='" + textBox19.Text + "' where P_ID =" + textBox11.Text + "";
            cmd.ExecuteNonQuery();

            con.Close();
            disp_data1();
            MessageBox.Show("values UPDATED successfully");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from PATIENT where P_ID=" + textBox20.Text + "";
            cmd.ExecuteNonQuery();

            con.Close();
            disp_data1();
            MessageBox.Show("values deleted successfully");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from PATIENT where P_ID=" + textBox21.Text + "";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView3.DataSource = dt;
            con.Close();
            MessageBox.Show("values searched successfully");
        }
    }
}
