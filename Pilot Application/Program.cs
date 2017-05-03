using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pilot_Application
{
    static class Program
    {
        private static SqlConnection conn;
        private static List<Part> parts;
        private static List<OrderStatus> orderStatuses;
        private static List<OrderCost> orderCosts;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // get data
            // set up connection
            conn = new SqlConnection();
            conn.ConnectionString = "Data Source=is371.bus.wisc.edu;Initial Catalog=2017_Boston_Parts;User ID=boston;Password=Scotch77";
            conn.Open();

            // get parts
            parts = getParts();
            orderStatuses = getOrderStatuses();
            orderCosts = getOrderCosts();

            // spawn forms
            var partForm = new Parts();
            var menuForm = new Menu();
            var crmForm = new CRM();

            // add data
            partForm.setParts(parts);

            crmForm.orderStatuses = orderStatuses;
            crmForm.orderCosts = orderCosts;
            crmForm.initData();


            menuForm.parts = partForm;
            menuForm.crm = crmForm;

            Application.Run(menuForm);
        }

        public static List<Part> getParts()
        {
            var query = "SELECT * FROM Parts;";
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable results = new DataTable();
            adapter.Fill(results);

            List<Part> parts = new List<Part>();

            foreach (DataRow row in results.Rows)
            {
                Part currPart = new Part();
                currPart.id = int.Parse(row[0].ToString());
                currPart.name = row[1].ToString();
                currPart.catName = row[2].ToString();
                currPart.labor = float.Parse(row[3].ToString());
                currPart.price = row[4].ToString();
                currPart.desc = row[5].ToString();

                parts.Add(currPart);
            }

            return parts;
        }

        public static List<OrderStatus> getOrderStatuses()
        {
            var query = "Select * FROM OrderStatus";
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable results = new DataTable();
            adapter.Fill(results);

            List<OrderStatus> orders = new List<OrderStatus>();

            foreach (DataRow row in results.Rows)
            {
                OrderStatus currStatus = new OrderStatus();
                currStatus.id = int.Parse(row[1].ToString());
                currStatus.lastName = row[2].ToString();
                currStatus.firstName = row[3].ToString();
                currStatus.statusName = row[4].ToString();
                currStatus.modelName = row[5].ToString();
                currStatus.notes = row[6].ToString();
                currStatus.repairDate = DateTime.Parse(row[7].ToString());

                orders.Add(currStatus);
            }

            return orders;
        }

        public static List<OrderCost> getOrderCosts ()
        {
            var query = "Select * FROM OrderCost";
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable results = new DataTable();
            adapter.Fill(results);

            List<OrderCost> orders = new List<OrderCost>();

            foreach (DataRow row in results.Rows)
            {
                OrderCost currCost = new OrderCost();
                currCost.id = int.Parse(row[0].ToString());
                currCost.partName = row[1].ToString();
                currCost.price = row[2].ToString();
                currCost.qty = float.Parse(row[3].ToString());

                orders.Add(currCost);
            }

            return orders;
        }
    }
}
