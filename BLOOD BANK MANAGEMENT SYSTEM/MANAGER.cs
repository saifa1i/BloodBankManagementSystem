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
    public partial class MANAGER : Form

       
    {
        SqlConnection con = new SqlConnection(@"Data Source=15081598-123-SE;Initial Catalog=BLOOD_BANK_MANAGEMENT_SYSTEM;Integrated Security=True");
        public MANAGER()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into HOSPITAL values ("+textBox1.Text+",'"+textBox2.Text+"',"+textBox3.Text+",'"+textBox4.Text+"')";
            cmd.ExecuteNonQuery();
           
            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            disp_data();
            MessageBox.Show("values are inserted successfully");
        }

        public void disp_data()
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from HOSPITAL";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            


        }

        private void MANAGER_Load(object sender, EventArgs e)
        {
            disp_data();
            disp_data1();
            disp_data2();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update HOSPITAL set H_ID="+textBox1.Text+",NAME='"+textBox2.Text+"',PHONE_NUMBER="+textBox3.Text+",H_ADDRESS='"+textBox4.Text+"' where H_ID="+textBox6.Text+"";
            cmd.ExecuteNonQuery();

            con.Close();
            disp_data();
            MessageBox.Show("values UPDATED successfully");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from HOSPITAL where H_ID=" + textBox5.Text + "";
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
            cmd.CommandText = "select * from HOSPITAL where H_ID="+textBox7.Text+"";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            MessageBox.Show("values searched successfully");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from MANAGER";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }

      private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click_1(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into BLOOD_BANKS values (" + textBox10.Text + ",'" + textBox11.Text + "'," + textBox15.Text + ",'" + textBox16.Text + "'," + textBox13.Text + ")";
            cmd.ExecuteNonQuery();

            con.Close();
            textBox10.Text = "";
            textBox11.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
            textBox13.Text = "";
            disp_data1();
            MessageBox.Show("values are inserted successfully");
        }
        public void disp_data1()
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from BLOOD_BANKS";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView3.DataSource = dt;
            con.Close();



        }

        private void button7_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update BLOOD_BANKS set B_B_ID=" + textBox10.Text + ",NAME='" + textBox11.Text + "',PHONE_NUMBER=" + textBox15.Text + ",B_B_ADDRESS='" + textBox16.Text + "',[B B M PH #]=" + textBox13.Text + " where B_B_ID=" + textBox9.Text + "";
            cmd.ExecuteNonQuery();

            con.Close();
            disp_data1();
            MessageBox.Show("values UPDATED successfully");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from BLOOD_BANKS where B_B_ID=" + textBox12.Text + "";
            cmd.ExecuteNonQuery();

            con.Close();
            disp_data1();
            MessageBox.Show("values deleted successfully");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from BLOOD_BANKS where B_B_ID=" + textBox14.Text + "";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView3.DataSource = dt;
            con.Close();
            MessageBox.Show("values searched successfully");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into EMPLOYEE values (" + textBox18.Text + ",'" + textBox19.Text + "','" + textBox20.Text + "'," + textBox22.Text + ",'" + textBox23.Text + "'," + textBox21.Text + ",'" + textBox24.Text + "')";
            cmd.ExecuteNonQuery();

            con.Close();
            textBox18.Text = "";
            textBox19.Text = "";
            textBox20.Text = "";
            textBox22.Text = "";
            textBox23.Text = "";
            textBox21.Text = "";
            textBox24.Text = "";
            disp_data2();
            MessageBox.Show("values are inserted successfully");
        }
        public void disp_data2()
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from EMPLOYEE";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView4.DataSource = dt;
            con.Close();



        }

        private void button11_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update EMPLOYEE set E_ID=" + textBox18.Text + ",NAME='" + textBox19.Text + "',FATHER_NAME='" + textBox20.Text + "', AGE=" + textBox22.Text + ",E_ADDRESS='" + textBox23.Text + "',PHONE_NUMBER=" + textBox21.Text + ",POSITION='" + textBox24.Text + "' where E_ID=" + textBox17.Text + "";
            cmd.ExecuteNonQuery();

            con.Close();
            disp_data2();
            MessageBox.Show("values UPDATED successfully");

        }

        private void button14_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from EMPLOYEE where E_ID=" + textBox26.Text + "";
            cmd.ExecuteNonQuery();

            con.Close();
            disp_data2();
            MessageBox.Show("values deleted successfully");

        }

        private void button13_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from EMPLOYEE where E_ID=" + textBox25.Text + "";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView4.DataSource = dt;
            con.Close();
            MessageBox.Show("values searched successfully");
        }

    }
}
