using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace best_shop
{
    public partial class Form1: Form
    {
        private DataTable ordersTable;
        public Form1()
        {
            InitializeComponent();
            LoadOrders();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 loginForm = new Form2();
            loginForm.Show();
        }

        private void LoadOrders()
        {
            ordersTable = new DataTable();

            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-QAHQ2NA;Initial Catalog=mdk111;Integrated Security=True"))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT OrderId, Recipient, Address, DeliveryDate, Status FROM Orders WHERE Status IN ('Pending', 'In Delivery')", connection);
                adapter.Fill(ordersTable);
            }

            dataGridView1.DataSource = ordersTable;
        }


        private void accept_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var orderId = dataGridView1.SelectedRows[0].Cells["OrderId"].Value;

                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-QAHQ2NA;Initial Catalog=mdk111;Integrated Security=True"))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("UPDATE Orders SET Status='In Delivery' WHERE OrderId=@orderId", connection);
                    command.Parameters.AddWithValue("@orderId", orderId);
                    command.ExecuteNonQuery();
                }

                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-QAHQ2NA;Initial Catalog=mdk111;Integrated Security=True"))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO OrderStatuses (OrderId, Status) VALUES (@orderId, 'Заказ у курьера')", connection);
                    command.Parameters.AddWithValue("@orderId", orderId);
                    command.ExecuteNonQuery();
                }

                LoadOrders();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите заказ для принятия.");
            }
        }

        private void deliver_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var orderId = dataGridView1.SelectedRows[0].Cells["OrderId"].Value;

                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-QAHQ2NA;Initial Catalog=mdk111;Integrated Security=True"))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("UPDATE Orders SET Status='Delivered' WHERE OrderId=@orderId", connection);
                    command.Parameters.AddWithValue("@orderId", orderId);
                    command.ExecuteNonQuery();
                }

                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-QAHQ2NA;Initial Catalog=mdk111;Integrated Security=True"))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO OrderStatuses (OrderId, Status) VALUES (@orderId, 'Заказ доставлен')", connection);
                    command.Parameters.AddWithValue("@orderId", orderId);
                    command.ExecuteNonQuery();
                }

                LoadOrders();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите заказ для доставки.");
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
