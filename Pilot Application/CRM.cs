using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pilot_Application
{
    public struct OrderStatus
    {
        public int id;
        public string lastName;
        public string firstName;
        public string statusName;
        public string modelName;
        public string notes;
        public DateTime repairDate;
    }

    public struct OrderCost
    {
        public int id;
        public string partName;
        public string price;
        public float qty;
    }

    public partial class CRM : Form
    {
        public List<OrderStatus> orderStatuses;
        public List<OrderCost> orderCosts;

        public CRM()
        {
            InitializeComponent();
        }

        public void initData ()
        {
            // fill grids
            foreach (var order in this.orderStatuses)
            {
                statusGrid.Rows.Add(order.id, order.lastName, order.firstName, order.statusName, order.modelName, order.notes, order.repairDate.ToShortDateString());
            }

            foreach (var order in this.orderCosts)
            {
                costGrid.Rows.Add(order.id, order.partName, order.price, order.qty);
            }
        }
    }
}
