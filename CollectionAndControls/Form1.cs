using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CollectionAndControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Emp.GetEmps();

            comboBox1.DataSource = Emp.GetEmps();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
        }
    }
}
