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
    public partial class SalesPerson : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\Anum\Documents\Stock Management.mdf"";Integrated Security=True;Connect Timeout=30");
        public SalesPerson()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand sc = new SqlCommand("insert into Supplier(SupplierID,Name,Contact,Gender,Address)values(@SupplierID,@Name,@Contact,@Gender,@Address)",con);
            sc.Parameters.AddWithValue("@SupplierID",textBox1.Text);
            sc.Parameters.AddWithValue("@Name", textBox2.Text);
            sc.Parameters.AddWithValue("@Contact", textBox4.Text);
            sc.Parameters.AddWithValue("@Gender", comboBox1.SelectedItem.ToString());
            sc.Parameters.AddWithValue("@Address", textBox3.Text);
            sc.ExecuteNonQuery();
            con.Close();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Supplier",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow items in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = items["SupplierID"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = items["Name"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = items["Contact"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = items["Gender"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = items["Address"].ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand sc = new SqlCommand("delete from Supplier where SupplierID='" + textBox1.Text + "'", con);
            sc.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Supplier", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow items in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = items["SupplierID"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = items["Name"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = items["Contact"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = items["Gender"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = items["Address"].ToString();
            }
            con.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Supplier", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow items in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = items["SupplierID"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = items["Name"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = items["Contact"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = items["Gender"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = items["Address"].ToString();
            }
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form2 home = new Form2();
            this.Hide();
            home.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand sc = new SqlCommand("update Supplier set Gender='" + comboBox1.Text + "',Name='" + textBox2.Text + "',Contact='" + textBox4.Text + "',Address='" + textBox3.Text + "'where SupplierID='" + textBox1.Text + "'", con);

            sc.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Supplier", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow items in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = items["SupplierID"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = items["Name"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = items["Contact"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = items["Gender"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = items["Address"].ToString();
            }
            con.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from Supplier where SupplierID='" + toolStripTextBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader mdr = cmd.ExecuteReader();
            if (mdr.Read())
            {
                linkLabel1.Text = mdr.GetString(0).ToString();
                linkLabel2.Text = mdr.GetString(1).ToString();
                linkLabel3.Text = mdr.GetValue(2).ToString();
                linkLabel4.Text = mdr.GetString(3).ToString();
                linkLabel5.Text = mdr.GetString(4).ToString();
            }
            else
            {
                MessageBox.Show("No such entry is Present in the List", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label11.Text = DateTime.Now.ToString("dd-MM-yyy");
            label12.Text = DateTime.Now.ToString("HH:mm:ss");
            label13.Text = DateTime.Now.ToString("dddd");
        }

        private void SalesPerson_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
