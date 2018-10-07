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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\Anum\Documents\Stock Management.mdf"";Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("select Role from Login where Username='"+textBox1.Text+"'and Password='"+textBox2.Text+"' ", con);
            DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count==1)
            {
                this.Hide();
                Form2 obj = new Form2();
                obj.Show();
            }
            else
            {
                MessageBox.Show("Invalid User Name and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
