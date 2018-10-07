using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Stock_Management
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Stock st = new Stock();
            st.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Workers wo = new Workers();
            wo.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalesPerson sp = new SalesPerson();
            sp.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        
    }
}
