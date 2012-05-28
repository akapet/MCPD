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
using EFCode.TablePerHierarchy;

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
            var d = new NorthwindEntities();
            Customer c = null;
            c.StartTracking();
            c.StopTracking();

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

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void executeStoredProcedureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var db = new NorthwindEntities();
            gv.DataSource = db.CustOrderHist("ALFKI");
        }

        private void orderDetailsWoCustomMethodToolStripMenuItem_Click(object sender, EventArgs e)
        {
           var db = new NorthwindEntities();
            gv.DataSource = (from od in db.Order_Details.AsEnumerable()
            where od.Order.CustomerID == "ALFKI"
            select new
            {
                od.OrderID,
                od.ProductID,
                od.Quantity,
                od.Discount,
                DetailTotal = (1 - (decimal)od.Discount) * (od.Quantity * od.UnitPrice)
            }).ToList();
        }

        private void orderDetailsWithCustomMethodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var db = new NorthwindEntities();
            gv.DataSource = (from od in db.Order_Details.AsEnumerable()
                             where od.Order.CustomerID == "ALFKI"
                             select new
                             {
                                 od.OrderID,
                                 od.ProductID,
                                 od.Quantity,
                                 od.Discount,
                                 od.DetailTotal,
                             }).ToList();
        }

        private void tPHDisplayCarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var db = new VehicleRepairsEntities();
            gv.DataSource = (from c in db.Vehicles.OfType<Car>()
                             select c).ToList();
        }
       
    }
}
