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
    public partial class LAB : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=15081598-123-SE;Initial Catalog=BLOOD_BANK_MANAGEMENT_SYSTEM;Integrated Security=True");
       
        public LAB()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from EMPLOYEE where POSITION = 'lab-attendant'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        public void disp_data()
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from EMPLOYEE";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();



        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into BLOOD values ('" + textBox2.Text + "'," + textBox3.Text + ",'" + textBox4.Text + "'," + textBox5.Text + "," + textBox6.Text + ")";
            cmd.ExecuteNonQuery();

            con.Close();
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
           
            disp_data1();
            MessageBox.Show("values are inserted successfully");
        }
        public void disp_data1()
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from BLOOD";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update BLOOD set BLOOD_GROUP='" + textBox2.Text + "',COST=" + textBox3.Text + ",IMPORTANCE='" + textBox4.Text + "',D_ID=" + textBox5.Text + ",Patient_ID=" + textBox6.Text + " where   BLOOD.BLOOD_GROUP='" + textBox1.Text + "'and BLOOD.D_ID =" + textBox9.Text + "";
            cmd.ExecuteNonQuery();

            con.Close();
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox1.Text = "";
            textBox9.Text = "";
            disp_data1();
            MessageBox.Show("values UPDATED successfully");
        }

        private void LAB_Load(object sender, EventArgs e)
        {
            disp_data1();
            disp_data();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from BLOOD where BLOOD.BLOOD_GROUP='" + textBox7.Text + "' and BLOOD.D_ID=" + textBox10.Text + "";
            cmd.ExecuteNonQuery();

            con.Close();
            textBox7.Text = "";
            textBox10.Text = "";
            disp_data1();
            MessageBox.Show("values deleted successfully");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from BLOOD where  BLOOD_GROUP='" + textBox8.Text + "' and D_ID=" + textBox11.Text + "";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
            textBox8.Text = "";
            textBox11.Text = "";
            MessageBox.Show("values searched successfully");
        }
    }
}
