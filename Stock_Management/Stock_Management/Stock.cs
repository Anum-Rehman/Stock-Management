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
    public partial class Stock : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\Anum\Documents\Stock Management.mdf"";Integrated Security=True;Connect Timeout=30");
        public Stock()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox6.Clear();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Food Items")
            {
                con.Open();
                SqlCommand sc = new SqlCommand("insert into FoodItems(ProductCode,Category,Brand,Price,Measurement,Type,Date,Time) values (@ProductCode,@Category,@Brand,@Price,@Measurement,@Type,@Date,@Time)", con);
                sc.Parameters.AddWithValue("@ProductCode", textBox1.Text);
                sc.Parameters.AddWithValue("@Category", comboBox1.SelectedItem.ToString());
                sc.Parameters.AddWithValue("@Brand", textBox2.Text);
                sc.Parameters.AddWithValue("@Price", textBox3.Text);
                sc.Parameters.AddWithValue("@Measurement", textBox4.Text);
                sc.Parameters.AddWithValue("@Type", textBox6.Text);
                sc.Parameters.AddWithValue("@Date", label15.Text);
                sc.Parameters.AddWithValue("@Time", label16.Text);
                sc.ExecuteNonQuery();
                con.Close();
                SqlDataAdapter sda = new SqlDataAdapter("select * from FoodItems", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.Rows.Clear();
                foreach (DataRow items in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = items["ProductCode"].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = items["Category"].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = items["Brand"].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = items["Price"].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = items["Measurement"].ToString();
                    dataGridView1.Rows[n].Cells[6].Value = items["Date"].ToString();
                    dataGridView1.Rows[n].Cells[5].Value = items["Type"].ToString();
                    dataGridView1.Rows[n].Cells[7].Value = items["Time"].ToString();
                }
            }
            if (comboBox1.Text == "Cosmetics")
            {
                con.Open();
                SqlCommand sc = new SqlCommand("insert into Cosmetics(ProductCode,Category,Brand,Price,Measurement,Type,Date,Time) values (@ProductCode,@Category,@Brand,@Price,@Measurement,@Type,@Date,@Time)", con);
                sc.Parameters.AddWithValue("@ProductCode", textBox1.Text);
                sc.Parameters.AddWithValue("@Category", comboBox1.SelectedItem.ToString());
                sc.Parameters.AddWithValue("@Brand", textBox2.Text);
                sc.Parameters.AddWithValue("@Price", textBox3.Text);
                sc.Parameters.AddWithValue("@Measurement", textBox4.Text);
                sc.Parameters.AddWithValue("@Type", textBox6.Text);
                sc.Parameters.AddWithValue("@Date", label15.Text);
                sc.Parameters.AddWithValue("@Time", label16.Text);
                sc.ExecuteNonQuery();
                con.Close();
                SqlDataAdapter sda = new SqlDataAdapter("select * from Cosmetics", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView2.Rows.Clear();
                foreach (DataRow items in dt.Rows)
                {
                    int n = dataGridView2.Rows.Add();
                    dataGridView2.Rows[n].Cells[0].Value = items["ProductCode"].ToString();
                    dataGridView2.Rows[n].Cells[1].Value = items["Category"].ToString();
                    dataGridView2.Rows[n].Cells[2].Value = items["Brand"].ToString();
                    dataGridView2.Rows[n].Cells[3].Value = items["Price"].ToString();
                    dataGridView2.Rows[n].Cells[4].Value = items["Measurement"].ToString();
                    dataGridView2.Rows[n].Cells[6].Value = items["Date"].ToString();
                    dataGridView2.Rows[n].Cells[5].Value = items["Type"].ToString();
                    dataGridView2.Rows[n].Cells[7].Value = items["Time"].ToString();
                }

            }
            if (comboBox1.Text == "Clothes")
            {
                con.Open();
                SqlCommand sc = new SqlCommand("insert into Clothes(ProductCode,Category,Brand,Price,Measurement,Type,Date,Time) values (@ProductCode,@Category,@Brand,@Price,@Measurement,@Type,@Date,@Time)", con);
                sc.Parameters.AddWithValue("@ProductCode", textBox1.Text);
                sc.Parameters.AddWithValue("@Category", comboBox1.SelectedItem.ToString());
                sc.Parameters.AddWithValue("@Brand", textBox2.Text);
                sc.Parameters.AddWithValue("@Price", textBox3.Text);
                sc.Parameters.AddWithValue("@Measurement", textBox4.Text);
                sc.Parameters.AddWithValue("@Type", textBox6.Text);
                sc.Parameters.AddWithValue("@Date", label15.Text);
                sc.Parameters.AddWithValue("@Time", label16.Text);
                sc.ExecuteNonQuery();
                con.Close();
                SqlDataAdapter sda = new SqlDataAdapter("select * from Clothes", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView3.Rows.Clear();
                foreach (DataRow items in dt.Rows)
                {
                    int n = dataGridView3.Rows.Add();
                    dataGridView3.Rows[n].Cells[0].Value = items["ProductCode"].ToString();
                    dataGridView3.Rows[n].Cells[1].Value = items["Category"].ToString();
                    dataGridView3.Rows[n].Cells[2].Value = items["Brand"].ToString();
                    dataGridView3.Rows[n].Cells[3].Value = items["Price"].ToString();
                    dataGridView3.Rows[n].Cells[4].Value = items["Measurement"].ToString();
                    dataGridView3.Rows[n].Cells[6].Value = items["Date"].ToString();
                    dataGridView3.Rows[n].Cells[5].Value = items["Type"].ToString();
                    dataGridView3.Rows[n].Cells[7].Value = items["Time"].ToString();
                }

            }
            if (comboBox1.Text == "Appliances")
            {
                con.Open();
                SqlCommand sc = new SqlCommand("insert into Appliances(ProductCode,Category,Brand,Price,Measurement,Type,Date,Time) values (@ProductCode,@Category,@Brand,@Price,@Measurement,@Type,@Date,@Time)", con);
                sc.Parameters.AddWithValue("@ProductCode", textBox1.Text);
                sc.Parameters.AddWithValue("@Category", comboBox1.SelectedItem.ToString());
                sc.Parameters.AddWithValue("@Brand", textBox2.Text);
                sc.Parameters.AddWithValue("@Price", textBox3.Text);
                sc.Parameters.AddWithValue("@Measurement", textBox4.Text);
                sc.Parameters.AddWithValue("@Type", textBox6.Text);
                sc.Parameters.AddWithValue("@Date", label15.Text);
                sc.Parameters.AddWithValue("@Time", label16.Text);
                sc.ExecuteNonQuery();
                con.Close();
                SqlDataAdapter sda = new SqlDataAdapter("select * from Appliances", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView4.Rows.Clear();
                foreach (DataRow items in dt.Rows)
                {
                    int n = dataGridView4.Rows.Add();
                    dataGridView4.Rows[n].Cells[0].Value = items["ProductCode"].ToString();
                    dataGridView4.Rows[n].Cells[1].Value = items["Category"].ToString();
                    dataGridView4.Rows[n].Cells[2].Value = items["Brand"].ToString();
                    dataGridView4.Rows[n].Cells[3].Value = items["Price"].ToString();
                    dataGridView4.Rows[n].Cells[4].Value = items["Measurement"].ToString();
                    dataGridView4.Rows[n].Cells[6].Value = items["Date"].ToString();
                    dataGridView4.Rows[n].Cells[5].Value = items["Type"].ToString();
                    dataGridView4.Rows[n].Cells[7].Value = items["Time"].ToString();
                }
            }
            if (comboBox1.Text == "Stationary")
            {
                con.Open();
                SqlCommand sc = new SqlCommand("insert into Stationary(ProductCode,Category,Brand,Price,Measurement,Type,Date,Time) values (@ProductCode,@Category,@Brand,@Price,@Measurement,@Type,@Date,@Time)", con);
                sc.Parameters.AddWithValue("@ProductCode", textBox1.Text);
                sc.Parameters.AddWithValue("@Category", comboBox1.SelectedItem.ToString());
                sc.Parameters.AddWithValue("@Brand", textBox2.Text);
                sc.Parameters.AddWithValue("@Price", textBox3.Text);
                sc.Parameters.AddWithValue("@Measurement", textBox4.Text);
                sc.Parameters.AddWithValue("@Type", textBox6.Text);
                sc.Parameters.AddWithValue("@Date", label15.Text);
                sc.Parameters.AddWithValue("@Time", label16.Text);
                sc.ExecuteNonQuery();
                con.Close();
                SqlDataAdapter sda = new SqlDataAdapter("select * from Stationary", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView5.Rows.Clear();
                foreach (DataRow items in dt.Rows)
                {
                    int n = dataGridView5.Rows.Add();
                    dataGridView5.Rows[n].Cells[0].Value = items["ProductCode"].ToString();
                    dataGridView5.Rows[n].Cells[1].Value = items["Category"].ToString();
                    dataGridView5.Rows[n].Cells[2].Value = items["Brand"].ToString();
                    dataGridView5.Rows[n].Cells[3].Value = items["Price"].ToString();
                    dataGridView5.Rows[n].Cells[4].Value = items["Measurement"].ToString();
                    dataGridView5.Rows[n].Cells[6].Value = items["Date"].ToString();
                    dataGridView5.Rows[n].Cells[5].Value = items["Type"].ToString();
                    dataGridView5.Rows[n].Cells[7].Value = items["Time"].ToString();
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from FoodItems", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow items in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = items["ProductCode"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = items["Category"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = items["Brand"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = items["Price"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = items["Measurement"].ToString();
                dataGridView1.Rows[n].Cells[6].Value = items["Date"].ToString();
                dataGridView1.Rows[n].Cells[5].Value = items["Type"].ToString();
                dataGridView1.Rows[n].Cells[7].Value = items["Time"].ToString();
            }
            sda = new SqlDataAdapter("select * from Cosmetics", con);
            DataTable dt1 = new DataTable();
            sda.Fill(dt1);
            dataGridView2.Rows.Clear();
            foreach (DataRow items in dt1.Rows)
            {
                int n = dataGridView2.Rows.Add();
                dataGridView2.Rows[n].Cells[0].Value = items["ProductCode"].ToString();
                dataGridView2.Rows[n].Cells[1].Value = items["Category"].ToString();
                dataGridView2.Rows[n].Cells[2].Value = items["Brand"].ToString();
                dataGridView2.Rows[n].Cells[3].Value = items["Price"].ToString();
                dataGridView2.Rows[n].Cells[4].Value = items["Measurement"].ToString();
                dataGridView2.Rows[n].Cells[6].Value = items["Date"].ToString();
                dataGridView2.Rows[n].Cells[5].Value = items["Type"].ToString();
                dataGridView2.Rows[n].Cells[7].Value = items["Time"].ToString();
            }
            sda = new SqlDataAdapter("select * from Clothes", con);
            DataTable dt2 = new DataTable();
            sda.Fill(dt2);
            dataGridView3.Rows.Clear();
            foreach (DataRow items in dt2.Rows)
            {
                int n = dataGridView3.Rows.Add();
                dataGridView3.Rows[n].Cells[0].Value = items["ProductCode"].ToString();
                dataGridView3.Rows[n].Cells[1].Value = items["Category"].ToString();
                dataGridView3.Rows[n].Cells[2].Value = items["Brand"].ToString();
                dataGridView3.Rows[n].Cells[3].Value = items["Price"].ToString();
                dataGridView3.Rows[n].Cells[4].Value = items["Measurement"].ToString();
                dataGridView3.Rows[n].Cells[6].Value = items["Date"].ToString();
                dataGridView3.Rows[n].Cells[5].Value = items["Type"].ToString();
                dataGridView3.Rows[n].Cells[7].Value = items["Time"].ToString();
            }
            sda = new SqlDataAdapter("select * from Appliances", con);
            DataTable dt3 = new DataTable();
            sda.Fill(dt3);
            dataGridView4.Rows.Clear();
            foreach (DataRow items in dt3.Rows)
            {
                int n = dataGridView4.Rows.Add();
                dataGridView4.Rows[n].Cells[0].Value = items["ProductCode"].ToString();
                dataGridView4.Rows[n].Cells[1].Value = items["Category"].ToString();
                dataGridView4.Rows[n].Cells[2].Value = items["Brand"].ToString();
                dataGridView4.Rows[n].Cells[3].Value = items["Price"].ToString();
                dataGridView4.Rows[n].Cells[4].Value = items["Measurement"].ToString();
                dataGridView4.Rows[n].Cells[6].Value = items["Date"].ToString();
                dataGridView4.Rows[n].Cells[5].Value = items["Type"].ToString();
                dataGridView4.Rows[n].Cells[7].Value = items["Time"].ToString();
            }
            sda = new SqlDataAdapter("select * from Stationary", con);
            DataTable dt4 = new DataTable();
            sda.Fill(dt4);
            dataGridView5.Rows.Clear();
            foreach (DataRow items in dt4.Rows)
            {
                int n = dataGridView5.Rows.Add();
                dataGridView5.Rows[n].Cells[0].Value = items["ProductCode"].ToString();
                dataGridView5.Rows[n].Cells[1].Value = items["Category"].ToString();
                dataGridView5.Rows[n].Cells[2].Value = items["Brand"].ToString();
                dataGridView5.Rows[n].Cells[3].Value = items["Price"].ToString();
                dataGridView5.Rows[n].Cells[4].Value = items["Measurement"].ToString();
                dataGridView5.Rows[n].Cells[6].Value = items["Date"].ToString();
                dataGridView5.Rows[n].Cells[5].Value = items["Type"].ToString();
                dataGridView5.Rows[n].Cells[7].Value = items["Time"].ToString();
            }
            con.Close();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            con.Open();
            if (comboBox1.Text == "Food Items")
            {
                SqlCommand sc = new SqlCommand("update FoodItems set Brand='" + textBox2.Text + "',Price='" + textBox3.Text + "',Measurement='" + textBox4.Text + "',Type='" + textBox6.Text + "',Date='" + label15.Text + "',Time='" + label16.Text + "'where ProductCode='" + textBox1.Text + "'and Category='" + comboBox1.Text + "'", con);

                sc.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter("select * from FoodItems", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.Rows.Clear();
                foreach (DataRow items in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = items["ProductCode"].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = items["Category"].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = items["Brand"].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = items["Price"].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = items["Measurement"].ToString();
                    dataGridView1.Rows[n].Cells[6].Value = items["Date"].ToString();
                    dataGridView1.Rows[n].Cells[5].Value = items["Type"].ToString();
                    dataGridView1.Rows[n].Cells[7].Value = items["Time"].ToString();
                }
            }
            if (comboBox1.Text == "Cosmetics")
            {
                SqlCommand sc = new SqlCommand("update Cosmetics set Brand='" + textBox2.Text + "',Price='" + textBox3.Text + "',Measurement='" + textBox4.Text + "',Type='" + textBox6.Text + "',Date='" + label15.Text + "',Time='" + label16 + "'where ProductCode='" + textBox1.Text + "'and Category='" + comboBox1.Text + "'", con);

                sc.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter("select * from Cosmetics", con);
                DataTable dt1 = new DataTable();
                sda.Fill(dt1);
                dataGridView2.Rows.Clear();
                foreach (DataRow items in dt1.Rows)
                {
                    int n = dataGridView2.Rows.Add();
                    dataGridView2.Rows[n].Cells[0].Value = items["ProductCode"].ToString();
                    dataGridView2.Rows[n].Cells[1].Value = items["Category"].ToString();
                    dataGridView2.Rows[n].Cells[2].Value = items["Brand"].ToString();
                    dataGridView2.Rows[n].Cells[3].Value = items["Price"].ToString();
                    dataGridView2.Rows[n].Cells[4].Value = items["Measurement"].ToString();
                    dataGridView2.Rows[n].Cells[6].Value = items["Date"].ToString();
                    dataGridView2.Rows[n].Cells[5].Value = items["Type"].ToString();
                    dataGridView2.Rows[n].Cells[7].Value = items["Time"].ToString();
                }
            }
            if (comboBox1.Text == "Clothes")
            {
                SqlCommand sc = new SqlCommand("update Clothes set Brand='" + textBox2.Text + "',Price='" + textBox3.Text + "',Measurement='" + textBox4.Text + "',Type='" + textBox6.Text + "',Date='" + label15.Text + "',Time='" + label16.Text + "'where ProductCode='" + textBox1.Text + "'and Category='" + comboBox1.Text + "'", con);

                sc.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter("select * from Clothes", con);
                DataTable dt2 = new DataTable();
                sda.Fill(dt2);
                dataGridView3.Rows.Clear();
                foreach (DataRow items in dt2.Rows)
                {
                    int n = dataGridView3.Rows.Add();
                    dataGridView3.Rows[n].Cells[0].Value = items["ProductCode"].ToString();
                    dataGridView3.Rows[n].Cells[1].Value = items["Category"].ToString();
                    dataGridView3.Rows[n].Cells[2].Value = items["Brand"].ToString();
                    dataGridView3.Rows[n].Cells[3].Value = items["Price"].ToString();
                    dataGridView3.Rows[n].Cells[4].Value = items["Measurement"].ToString();
                    dataGridView3.Rows[n].Cells[6].Value = items["Date"].ToString();
                    dataGridView3.Rows[n].Cells[5].Value = items["Type"].ToString();
                    dataGridView3.Rows[n].Cells[7].Value = items["Time"].ToString();
                }
            }
            if (comboBox1.Text == "Appliances")
            {
                SqlCommand sc = new SqlCommand("update Appliances set Brand='" + textBox2.Text + "',Price='" + textBox3.Text + "',Measurement='" + textBox4.Text + "',Type='" + textBox6.Text + "',Date='" + label15.Text + "',Time='" + label16.Text + "'where ProductCode='" + textBox1.Text + "'and Category='" + comboBox1.Text + "'", con);

                sc.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter("select * from Appliances", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView4.Rows.Clear();
                foreach (DataRow items in dt.Rows)
                {
                    int n = dataGridView4.Rows.Add();
                    dataGridView4.Rows[n].Cells[0].Value = items["ProductCode"].ToString();
                    dataGridView4.Rows[n].Cells[1].Value = items["Category"].ToString();
                    dataGridView4.Rows[n].Cells[2].Value = items["Brand"].ToString();
                    dataGridView4.Rows[n].Cells[3].Value = items["Price"].ToString();
                    dataGridView4.Rows[n].Cells[4].Value = items["Measurement"].ToString();
                    dataGridView4.Rows[n].Cells[6].Value = items["Date"].ToString();
                    dataGridView4.Rows[n].Cells[5].Value = items["Type"].ToString();
                    dataGridView4.Rows[n].Cells[7].Value = items["Time"].ToString();
                }
            }
            if (comboBox1.Text == "Stationary")
            {
                SqlCommand sc = new SqlCommand("update Stationary set Brand='" + textBox2.Text + "',Price='" + textBox3.Text + "',Measurement='" + textBox4.Text + "',Type='" + textBox6.Text + "',Date='" + label15.Text + "',Time='" + label16.Text + "'where ProductCode='" + textBox1.Text + "'and Category='" + comboBox1.Text + "'", con);

                sc.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter("select * from Stationary", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView5.Rows.Clear();
                foreach (DataRow items in dt.Rows)
                {
                    int n = dataGridView5.Rows.Add();
                    dataGridView5.Rows[n].Cells[0].Value = items["ProductCode"].ToString();
                    dataGridView5.Rows[n].Cells[1].Value = items["Category"].ToString();
                    dataGridView5.Rows[n].Cells[2].Value = items["Brand"].ToString();
                    dataGridView5.Rows[n].Cells[3].Value = items["Price"].ToString();
                    dataGridView5.Rows[n].Cells[4].Value = items["Measurement"].ToString();
                    dataGridView5.Rows[n].Cells[6].Value = items["Date"].ToString();
                    dataGridView5.Rows[n].Cells[5].Value = items["Type"].ToString();
                    dataGridView5.Rows[n].Cells[7].Value = items["Time"].ToString();
                }
            }
            con.Close();

        }

        private void button7_Click(object sender, EventArgs e)
        {
             con.Open();
            if (comboBox1.Text == "Food Items")
            {
                SqlCommand sc = new SqlCommand("delete from FoodItems where ProductCode='" + textBox1.Text + "'and Category='" + comboBox1.Text + "'", con);
                sc.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter("select * from FoodItems", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.Rows.Clear();
                foreach (DataRow items in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = items["ProductCode"].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = items["Category"].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = items["Brand"].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = items["Price"].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = items["Measurement"].ToString();
                    dataGridView1.Rows[n].Cells[6].Value = items["Date"].ToString();
                    dataGridView1.Rows[n].Cells[5].Value = items["Type"].ToString();
                    dataGridView1.Rows[n].Cells[7].Value = items["Time"].ToString();
                }
            }
            if (comboBox1.Text == "Cosmetics")
            {
                SqlCommand sc = new SqlCommand("delete from Cosmetics where ProductCode='" + textBox1.Text + "'and Category='" + comboBox1.Text + "'", con);
                sc.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter("select * from Cosmetics", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView2.Rows.Clear();
                foreach (DataRow items in dt.Rows)
                {
                    int n = dataGridView2.Rows.Add();
                    dataGridView2.Rows[n].Cells[0].Value = items["ProductCode"].ToString();
                    dataGridView2.Rows[n].Cells[1].Value = items["Category"].ToString();
                    dataGridView2.Rows[n].Cells[2].Value = items["Brand"].ToString();
                    dataGridView2.Rows[n].Cells[3].Value = items["Price"].ToString();
                    dataGridView2.Rows[n].Cells[4].Value = items["Measurement"].ToString();
                    dataGridView2.Rows[n].Cells[6].Value = items["Date"].ToString();
                    dataGridView2.Rows[n].Cells[5].Value = items["Type"].ToString();
                    dataGridView2.Rows[n].Cells[7].Value = items["Time"].ToString();
                }
            }
            if (comboBox1.Text == "Clothes")
            {
                SqlCommand sc = new SqlCommand("delete from Clothes where ProductCode='" + textBox1.Text + "'and Category='" + comboBox1.Text + "'", con);
                sc.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter("select * from Clothes", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView3.Rows.Clear();
                foreach (DataRow items in dt.Rows)
                {
                    int n = dataGridView3.Rows.Add();
                    dataGridView3.Rows[n].Cells[0].Value = items["ProductCode"].ToString();
                    dataGridView3.Rows[n].Cells[1].Value = items["Category"].ToString();
                    dataGridView3.Rows[n].Cells[2].Value = items["Brand"].ToString();
                    dataGridView3.Rows[n].Cells[3].Value = items["Price"].ToString();
                    dataGridView3.Rows[n].Cells[4].Value = items["Measurement"].ToString();
                    dataGridView3.Rows[n].Cells[6].Value = items["Date"].ToString();
                    dataGridView3.Rows[n].Cells[5].Value = items["Type"].ToString();
                    dataGridView3.Rows[n].Cells[7].Value = items["Time"].ToString();
                }
            }
            if (comboBox1.Text == "Appliances")
            {
                SqlCommand sc = new SqlCommand("delete from Appliances where ProductCode='" + textBox1.Text + "'and Category='" + comboBox1.Text + "'", con);
                sc.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter("select * from Appliances", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView4.Rows.Clear();
                foreach (DataRow items in dt.Rows)
                {
                    int n = dataGridView4.Rows.Add();
                    dataGridView4.Rows[n].Cells[0].Value = items["ProductCode"].ToString();
                    dataGridView4.Rows[n].Cells[1].Value = items["Category"].ToString();
                    dataGridView4.Rows[n].Cells[2].Value = items["Brand"].ToString();
                    dataGridView4.Rows[n].Cells[3].Value = items["Price"].ToString();
                    dataGridView4.Rows[n].Cells[4].Value = items["Measurement"].ToString();
                    dataGridView4.Rows[n].Cells[6].Value = items["Date"].ToString();
                    dataGridView4.Rows[n].Cells[5].Value = items["Type"].ToString();
                    dataGridView4.Rows[n].Cells[7].Value = items["Time"].ToString();
                }
            }
            if (comboBox1.Text == "Stationary")
            {
                SqlCommand sc = new SqlCommand("delete from Stationary where ProductCode='" + textBox1.Text + "'and Category='" + comboBox1.Text + "'", con);
                sc.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter("select * from Stationary", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView5.Rows.Clear();
                foreach (DataRow items in dt.Rows)
                {
                    int n = dataGridView5.Rows.Add();
                    dataGridView5.Rows[n].Cells[0].Value = items["ProductCode"].ToString();
                    dataGridView5.Rows[n].Cells[1].Value = items["Category"].ToString();
                    dataGridView5.Rows[n].Cells[2].Value = items["Brand"].ToString();
                    dataGridView5.Rows[n].Cells[3].Value = items["Price"].ToString();
                    dataGridView5.Rows[n].Cells[4].Value = items["Measurement"].ToString();
                    dataGridView5.Rows[n].Cells[6].Value = items["Date"].ToString();
                    dataGridView5.Rows[n].Cells[5].Value = items["Type"].ToString();
                    dataGridView5.Rows[n].Cells[7].Value = items["Time"].ToString();
                }
            }
            con.Close();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form2 home = new Form2();
            this.Hide();
            home.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            if (toolStripComboBox1.Text == "Food Items")
            {
                if (toolStripTextBox1.Text == "")
                {
                    MessageBox.Show("Please Enter the Search Item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    con.Open();
                    string query = "select * from FoodItems where ProductCode='" + toolStripTextBox1.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader mdr = cmd.ExecuteReader();
                    if (mdr.Read())
                    {
                        label9.Text = "Food Item";
                        ProductCode.Text = "Product Code";
                        Brand.Text = "Brand";
                        Type.Text = "Type";
                        Measurement.Text = "Measurement";
                        Price.Text = "Price";
                        Date.Text = "Date";
                        Time.Text = "Time";
                        PI.Text = mdr.GetInt32(0).ToString();
                        Br.Text = mdr.GetString(2);
                        Ty.Text = mdr.GetString(5);
                        Mea.Text = mdr.GetString(4);
                        Pr.Text = mdr.GetDouble(3).ToString();
                        Da.Text = mdr.GetString(6).ToString();
                        Ti.Text = mdr.GetTimeSpan(7).ToString();
                        if (mdr.GetString(2) == "Food Items")
                        {
                            SqlDataAdapter sda = new SqlDataAdapter("select * from Clothes", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            foreach (DataRow items in dt.Rows)
                            {
                                int n = dataGridView1.Rows.Add();
                                dataGridView1.Rows[n].Cells[0].Value = items["ProductCode"].ToString();
                                dataGridView1.Rows[n].Cells[1].Value = items["Category"].ToString();
                                dataGridView1.Rows[n].Cells[2].Value = items["Brand"].ToString();
                                dataGridView1.Rows[n].Cells[3].Value = items["Price"].ToString();
                                dataGridView1.Rows[n].Cells[4].Value = items["Measurement"].ToString();
                                dataGridView1.Rows[n].Cells[6].Value = items["Date"].ToString();
                                dataGridView1.Rows[n].Cells[5].Value = items["Type"].ToString();
                                dataGridView1.Rows[n].Cells[7].Value = items["Time"].ToString();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No such entry is Present in the List", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                con.Close();
            }
            if (toolStripComboBox1.Text == "Cosmetics")
            {
                if (toolStripTextBox1.Text == "")
                {
                    MessageBox.Show("Please Enter the Search Item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    con.Open();
                    string query = "select * from Cosmetics where ProductCode='" + toolStripTextBox1.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader mdr = cmd.ExecuteReader();
                    if (mdr.Read())
                    {
                        label9.Text = "Cosmetics";
                        ProductCode.Text = "Product Code";
                        Brand.Text = "Brand";
                        Type.Text = "Type";
                        Measurement.Text = "Measurement";
                        Price.Text = "Price";
                        Date.Text = "Date";
                        Time.Text = "Time";
                        PI.Text = mdr.GetInt32(0).ToString();
                        Br.Text = mdr.GetString(2);
                        Ty.Text = mdr.GetString(5);
                        Mea.Text = mdr.GetString(4);
                        Pr.Text = mdr.GetDouble(3).ToString();
                        Da.Text = mdr.GetString(6).ToString();
                        Ti.Text = mdr.GetTimeSpan(7).ToString();
                    }
                    else
                    {
                        MessageBox.Show("No such entry is Present in the List", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                con.Close();
            }
            if (toolStripComboBox1.Text == "Clothes")
            {
                if (toolStripTextBox1.Text == "")
                {
                    MessageBox.Show("Please Enter the Search Item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    con.Open();
                    string query = "select * from Clothes where ProductCode='" + toolStripTextBox1.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader mdr = cmd.ExecuteReader();
                    if (mdr.Read())
                    {
                        label9.Text = "Clothes";
                        ProductCode.Text = "Product Code";
                        Brand.Text = "Brand";
                        Type.Text = "Type";
                        Measurement.Text = "Measurement";
                        Price.Text = "Price";
                        Date.Text = "Date";
                        Time.Text = "Time";
                        PI.Text = mdr.GetInt32(0).ToString();
                        Br.Text = mdr.GetString(2);
                        Ty.Text = mdr.GetString(5);
                        Mea.Text = mdr.GetString(4);
                        Pr.Text = mdr.GetDouble(3).ToString();
                        Da.Text = mdr.GetString(6).ToString();
                        Ti.Text = mdr.GetTimeSpan(7).ToString();
                    }
                    else
                    {
                        MessageBox.Show("No such entry is Present in the List", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                con.Close();
            }
            if (toolStripComboBox1.Text == "Appliances")
            {
                if (toolStripTextBox1.Text == "")
                {
                    MessageBox.Show("Please Enter the Search Item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    con.Open();
                    string query = "select * from Appliances where ProductCode='" + toolStripTextBox1.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader mdr = cmd.ExecuteReader();
                    if (mdr.Read())
                    {
                        label9.Text = "Appliances";
                        ProductCode.Text = "Product Code";
                        Brand.Text = "Brand";
                        Type.Text = "Type";
                        Measurement.Text = "Measurement";
                        Price.Text = "Price";
                        Date.Text = "Date";
                        Time.Text = "Time";
                        PI.Text = mdr.GetInt32(0).ToString();
                        Br.Text = mdr.GetString(2);
                        Ty.Text = mdr.GetString(5);
                        Mea.Text = mdr.GetString(4);
                        Pr.Text = mdr.GetDouble(3).ToString();
                        Da.Text = mdr.GetString(6).ToString();
                        Ti.Text = mdr.GetTimeSpan(7).ToString();
                    }
                    else
                    {
                        MessageBox.Show("No such entry is Present in the List", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                con.Close();

            }
            if (toolStripComboBox1.Text == "Stationary")
            {
                if (toolStripTextBox1.Text == "")
                {
                    MessageBox.Show("Please Enter the Search Item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    con.Open();
                    string query = "select * from Stationary where ProductCode='" + toolStripTextBox1.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader mdr = cmd.ExecuteReader();
                    if (mdr.Read())
                    {
                        label9.Text = "Stationary";
                        ProductCode.Text = "Product Code";
                        Brand.Text = "Brand";
                        Type.Text = "Type";
                        Measurement.Text = "Measurement";
                        Price.Text = "Price";
                        Date.Text = "Date";
                        Time.Text = "Time";
                        PI.Text = mdr.GetInt32(0).ToString();
                        Br.Text = mdr.GetString(2);
                        Ty.Text = mdr.GetString(5);
                        Mea.Text = mdr.GetString(4);
                        Pr.Text = mdr.GetDouble(3).ToString();
                        Da.Text = mdr.GetString(6).ToString();
                        Ti.Text = mdr.GetTimeSpan(7).ToString();
                    }
                    else
                    {
                        MessageBox.Show("No such entry is Present in the List", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                con.Close();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text=="Food Items")
            {
                if(MessageBox.Show("Are you sure you want to delete all the records of selected category", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes){
                con.Open();
                string query = "Truncate table FoodItems";
                SqlCommand cmd = new SqlCommand(query,con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter("select * from FoodItems", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.Rows.Clear();
                foreach (DataRow items in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = items["ProductCode"].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = items["Category"].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = items["Brand"].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = items["Price"].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = items["Measurement"].ToString();
                    dataGridView1.Rows[n].Cells[6].Value = items["Date"].ToString();
                    dataGridView1.Rows[n].Cells[5].Value = items["Type"].ToString();
                    dataGridView1.Rows[n].Cells[7].Value = items["Time"].ToString();
                }
                con.Close();
                }
            }
            else if (comboBox1.Text == "Cosmetics")
            {
                con.Open();
                string query = "Truncate table Cosmetics";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter("select * from Cosmetics", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView2.Rows.Clear();
                foreach (DataRow items in dt.Rows)
                {
                    int n = dataGridView2.Rows.Add();
                    dataGridView2.Rows[n].Cells[0].Value = items["ProductCode"].ToString();
                    dataGridView2.Rows[n].Cells[1].Value = items["Category"].ToString();
                    dataGridView2.Rows[n].Cells[2].Value = items["Brand"].ToString();
                    dataGridView2.Rows[n].Cells[3].Value = items["Price"].ToString();
                    dataGridView2.Rows[n].Cells[4].Value = items["Measurement"].ToString();
                    dataGridView2.Rows[n].Cells[6].Value = items["Date"].ToString();
                    dataGridView2.Rows[n].Cells[5].Value = items["Type"].ToString();
                    dataGridView2.Rows[n].Cells[7].Value = items["Time"].ToString();
                }
                con.Close();
            }
            else if (comboBox1.Text == "Clothes")
            {
                con.Open();
                string query = "Truncate table Clothes";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter("select * from Clothes", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView3.Rows.Clear();
                foreach (DataRow items in dt.Rows)
                {
                    int n = dataGridView3.Rows.Add();
                    dataGridView3.Rows[n].Cells[0].Value = items["ProductCode"].ToString();
                    dataGridView3.Rows[n].Cells[1].Value = items["Category"].ToString();
                    dataGridView3.Rows[n].Cells[2].Value = items["Brand"].ToString();
                    dataGridView3.Rows[n].Cells[3].Value = items["Price"].ToString();
                    dataGridView3.Rows[n].Cells[4].Value = items["Measurement"].ToString();
                    dataGridView3.Rows[n].Cells[6].Value = items["Date"].ToString();
                    dataGridView3.Rows[n].Cells[5].Value = items["Type"].ToString();
                    dataGridView3.Rows[n].Cells[7].Value = items["Time"].ToString();
                }
                con.Close();
            }
            else if (comboBox1.Text == "Appliances")
            {
                con.Open();
                string query = "Truncate table Appliances";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter("select * from Appliances", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView4.Rows.Clear();
                foreach (DataRow items in dt.Rows)
                {
                    int n = dataGridView4.Rows.Add();
                    dataGridView4.Rows[n].Cells[0].Value = items["ProductCode"].ToString();
                    dataGridView4.Rows[n].Cells[1].Value = items["Category"].ToString();
                    dataGridView4.Rows[n].Cells[2].Value = items["Brand"].ToString();
                    dataGridView4.Rows[n].Cells[3].Value = items["Price"].ToString();
                    dataGridView4.Rows[n].Cells[4].Value = items["Measurement"].ToString();
                    dataGridView4.Rows[n].Cells[6].Value = items["Date"].ToString();
                    dataGridView4.Rows[n].Cells[5].Value = items["Type"].ToString();
                    dataGridView4.Rows[n].Cells[7].Value = items["Time"].ToString();
                }
                con.Close();
            }
            else if (comboBox1.Text == "Stationary")
            {
                con.Open();
                string query = "Truncate table Stationary";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter("select * from Stationary", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView5.Rows.Clear();
                foreach (DataRow items in dt.Rows)
                {
                    int n = dataGridView5.Rows.Add();
                    dataGridView5.Rows[n].Cells[0].Value = items["ProductCode"].ToString();
                    dataGridView5.Rows[n].Cells[1].Value = items["Category"].ToString();
                    dataGridView5.Rows[n].Cells[2].Value = items["Brand"].ToString();
                    dataGridView5.Rows[n].Cells[3].Value = items["Price"].ToString();
                    dataGridView5.Rows[n].Cells[4].Value = items["Measurement"].ToString();
                    dataGridView5.Rows[n].Cells[6].Value = items["Date"].ToString();
                    dataGridView5.Rows[n].Cells[5].Value = items["Type"].ToString();
                    dataGridView5.Rows[n].Cells[7].Value = items["Time"].ToString();
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Choose a Category to Dispose the List","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label15.Text = DateTime.Now.ToString("dd-MM-yyyy");
            label16.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
