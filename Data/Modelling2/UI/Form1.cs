using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace UI
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
            dg.DataSource = employees;
            MessageBox.Show(sw.GetStringBuilder().ToString());
        }

        private void lazyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ctx = new NorthwindDataContext();
            var sw = new StringWriter();
            ctx.Log = sw;
            var employee = (from emp in ctx.Employees
                            where emp.LastName.StartsWith("Davolio")
                            select emp).First();
            MessageBox.Show(sw.GetStringBuilder().ToString());
            sw = new StringWriter();
            ctx.Log = sw;
            employee.Photo.ToArray();
            //var photo = new MemoryStream(employee.Photo.ToArray());
            MessageBox.Show(sw.GetStringBuilder().ToString());
        }
    }
}
