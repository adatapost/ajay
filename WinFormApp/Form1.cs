using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        EventHandler goHome = (sa,ea) => MessageBox.Show("Home!!!");
        EventHandler goOffice = (sa, ea) => MessageBox.Show("Office!!!");
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.MouseHover += (sa, ea) => button1.BackColor = System.Drawing.Color.Red;
            button1.MouseLeave += (sa, ea) => button1.BackColor = System.Drawing.Color.Gray;

            button2.Click += goHome;
            button1.Click += goHome;

            checkBox1.CheckedChanged += (sa, ea) =>
                {
                    if (checkBox1.Checked)
                    {
                        button2.Click -= goHome;
                        button1.Click -= goHome;
                        button2.Click += goOffice;
                        button1.Click += goOffice;
                    }
                };
        }
    }
}
