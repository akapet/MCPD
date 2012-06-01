using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Data;
using System.IO;

namespace Modelling2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ctx = new NorthwindDataContext();
            
            var sw = new StringWriter();

            ctx.Log = sw;
            var employees = from emp in ctx.Employees
                            where emp.LastName.StartsWith("D")
                            select emp;
            dg.ItemsSource = employees;
            MessageBox.Show(sw.GetStringBuilder().ToString());
        }              
    }
}
