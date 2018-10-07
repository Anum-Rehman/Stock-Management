using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Stock_Management
{
    public partial class Workers : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\Anum\Documents\Stock Management.mdf"";Integrated Security=True;Connect Timeout=30");
        public Workers()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form2 home = new Form2();
            this.Hide();
            home.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            if(radioButton1.Checked){
            SqlCommand sc = new SqlCommand("insert into Worker(WorkerID,Name,Contact,Gender,Salary,Address,Position,DOB)values(@WorkerID,@Name,@Contact,@Gender,@Salary,@Address,@Position,@DOB)", con);
            sc.Parameters.AddWithValue("@WorkerID", textBox1.Text);
            sc.Parameters.AddWithValue("@Name", textBox3.Text);
            sc.Parameters.AddWithValue("@Contact", textBox2.Text);
            sc.Parameters.AddWithValue("@Gender", radioButton1.Text);
            sc.Parameters.AddWithValue("@Salary",textBox6.Text);
            sc.Parameters.AddWithValue("@Address", textBox5.Text);
            sc.Parameters.AddWithValue("@Position",textBox7.Text);
            sc.Parameters.AddWithValue("@DOB", dateTimePicker1.Text);
            sc.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Worker", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow items in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = items["WorkerID"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = items["Name"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = items["Gender"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = items["Contact"].ToString();
                dataGridView1.Rows[n].Cells[5].Value = items["Address"].ToString();
                dataGridView1.Rows[n].Cells[6].Value = items["Salary"].ToString();
                dataGridView1.Rows[n].Cells[7].Value = items["Position"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = items["DOB"].ToString();
            }
            con.Close();
            }
            else if (radioButton2.Checked)
            {
                SqlCommand sc = new SqlCommand("insert into Worker(WorkerID,Name,Contact,Gender,Salary,Address,Position,DOB)values(@WorkerID,@Name,@Contact,@Gender,@Salary,@Address,@Position,@DOB)", con);
                sc.Parameters.AddWithValue("@WorkerID", textBox1.Text);
                sc.Parameters.AddWithValue("@Name", textBox3.Text);
                sc.Parameters.AddWithValue("@Contact", textBox2.Text);
                sc.Parameters.AddWithValue("@Gender", radioButton2.Text);
                sc.Parameters.AddWithValue("@Salary", textBox6.Text);
                sc.Parameters.AddWithValue("@Address", textBox5.Text);
                sc.Parameters.AddWithValue("@Position", textBox7.Text);
                sc.Parameters.AddWithValue("@DOB", dateTimePicker1.Text);
                sc.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter("select * from Worker", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.Rows.Clear();
                foreach (DataRow items in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = items["WorkerID"].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = items["Name"].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = items["Gender"].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = items["Contact"].ToString();
                    dataGridView1.Rows[n].Cells[5].Value = items["Address"].ToString();
                    dataGridView1.Rows[n].Cells[6].Value = items["Salary"].ToString();
                    dataGridView1.Rows[n].Cells[7].Value = items["Position"].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = items["DOB"].ToString();
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Please select the Gender","Message",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
            con.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label11.Text = DateTime.Now.ToString("HH:mm:ss");
            label13.Text = DateTime.Now.ToString("dd-MM-yyyy");
            label14.Text = DateTime.Now.ToString("dddd");
        }

        private void Workers_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Worker", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow items in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = items["WorkerID"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = items["Name"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = items["Gender"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = items["Contact"].ToString();
                dataGridView1.Rows[n].Cells[5].Value = items["Address"].ToString();
                dataGridView1.Rows[n].Cells[6].Value = items["Salary"].ToString();
                dataGridView1.Rows[n].Cells[7].Value = items["Position"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = items["DOB"].ToString();
            }
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            if (radioButton1.Checked)
            {
                SqlCommand sc = new SqlCommand("update Worker set Name='"+textBox3.Text+"',Contact='"+textBox2.Text+"',Gender='"+radioButton1.Text+"',Salary='"+textBox6.Text+"',Address='"+textBox5.Text+"',Position='"+textBox7.Text+"',DOB='"+dateTimePicker1.Text+"'where WorkerID='"+textBox1.Text+"'", con);
                sc.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter("select * from Worker", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.Rows.Clear();
                foreach (DataRow items in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = items["WorkerID"].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = items["Name"].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = items["Gender"].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = items["Contact"].ToString();
                    dataGridView1.Rows[n].Cells[5].Value = items["Address"].ToString();
                    dataGridView1.Rows[n].Cells[6].Value = items["Salary"].ToString();
                    dataGridView1.Rows[n].Cells[7].Value = items["Position"].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = items["DOB"].ToString();
                }
            }
            else if (radioButton2.Checked)
            {
                SqlCommand sc = new SqlCommand("update Worker set Name='" + textBox3.Text + "',Contact='" + textBox2.Text + "',Gender='" + radioButton2.Text + "',Salary='" + textBox6.Text + "',Address='" + textBox5.Text + "',Position='" + textBox7.Text + "',DOB='" + dateTimePicker1.Text + "'where WorkerID='" + textBox1.Text + "'", con);
                sc.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter("select * from Worker", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.Rows.Clear();
                foreach (DataRow items in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = items["WorkerID"].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = items["Name"].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = items["Gender"].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = items["Contact"].ToString();
                    dataGridView1.Rows[n].Cells[5].Value = items["Address"].ToString();
                    dataGridView1.Rows[n].Cells[6].Value = items["Salary"].ToString();
                    dataGridView1.Rows[n].Cells[7].Value = items["Position"].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = items["DOB"].ToString();
                }
            }
            else
            {
                MessageBox.Show("Please select the Gender", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
            {
                MessageBox.Show("Please Enter the Worker ID you want to delete","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else{
            con.Open();
            SqlCommand sc = new SqlCommand("delete from Worker where WorkerID='"+textBox1.Text+"'",con);
            sc.ExecuteNonQuery();
            con.Close();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Worker", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow items in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = items["WorkerID"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = items["Name"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = items["Gender"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = items["Contact"].ToString();
                dataGridView1.Rows[n].Cells[5].Value = items["Address"].ToString();
                dataGridView1.Rows[n].Cells[6].Value = items["Salary"].ToString();
                dataGridView1.Rows[n].Cells[7].Value = items["Position"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = items["DOB"].ToString();
            }
            con.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You Sure You Want to Clear all the Records?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Truncate Table Worker",con);
                cmd.ExecuteNonQuery();
                con.Close();
                SqlDataAdapter sda = new SqlDataAdapter("select * from Worker", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.Rows.Clear();
                foreach (DataRow items in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = items["WorkerID"].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = items["Name"].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = items["Gender"].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = items["Contact"].ToString();
                    dataGridView1.Rows[n].Cells[5].Value = items["Address"].ToString();
                    dataGridView1.Rows[n].Cells[6].Value = items["Salary"].ToString();
                    dataGridView1.Rows[n].Cells[7].Value = items["Position"].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = items["DOB"].ToString();
                }
            }
            con.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from Worker where WorkerID='" + toolStripTextBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader mdr = cmd.ExecuteReader();
            if (mdr.Read())
            {
                linkLabel1.Text = mdr.GetInt32(0).ToString();
                linkLabel2.Text = mdr.GetString(1).ToString();
                linkLabel3.Text = mdr.GetString(5).ToString();
                linkLabel4.Text = mdr.GetValue(2).ToString();
                linkLabel5.Text = mdr.GetString(6).ToString();
                linkLabel6.Text = mdr.GetString(3).ToString();
                linkLabel7.Text = mdr.GetString(7).ToString();
                linkLabel8.Text = mdr.GetInt32(4).ToString();
            }
            else
            {
                MessageBox.Show("No such entry is Present in the List", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
