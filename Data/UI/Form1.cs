using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using _70_516;
using System.Diagnostics;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //TestObjectStateEntry();
        }
        private void stToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var db = new NorthwindEntities();
            gv.DataSource = (from c in db.Customers
                             select new
                             {
                                 c.CustomerID,
                                 c.CompanyName
                             }).ToList();

            //Customer c2 = from c in db.Customers select new {c.CustomerID == ""};

            //label1.Text = "Object State Entry: " + db.ObjectStateManager.GetObjectStateEntry(EntityKey.NoEntitySetKey);
        }

        private void lazyLoadingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Don't forget to set the Lazy Loading Enabled " + " property on the EDMX file to true!");
            var db = new NorthwindEntities();
            var order = db.Orders.Where(o => o.CustomerID == "ALFKI").First();
            gv.DataSource = order.Order_Details.ToList();
        }

        private void eagerLoadingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Don't forget to set the Lazy Loading Enabled " + "property on the EDMX file to false!");
            var db = new NorthwindEntities();
            var order = db.Orders.Include("Order_Details").Where(o => o.CustomerID == "ALFKI").First();
            gv.DataSource = order.Order_Details.ToList();
        }

        private void explicitLoadingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Don't forget to set the Lazy Loading Enabled " + "property on the EDMX file to false!");
            var db = new NorthwindEntities();
            var order = db.Orders.Where(o => o.CustomerID == "ALFKI").First();
            order.Order_Details.Load();
            gv.DataSource = order.Order_Details.ToList();
        }

       
    }
}
