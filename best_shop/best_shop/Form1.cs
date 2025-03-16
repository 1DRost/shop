using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace best_shop
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Order> orders = new List<Order>();
        private int nextOrderId = 1;

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 loginForm = new Form2();
            loginForm.Show();
        }

        private void accept_Click(object sender, EventArgs e)
        {
            Order newOrder = new Order(nextOrderId++, "Получатель " + nextOrderId, "Адрес " + nextOrderId, DateTime.Now.AddDays(nextOrderId));
            orders.Add(newOrder);
            UpdateDataGridView();
        }

        private void deliver_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int orderId = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                orders.RemoveAll(order => order.Id == orderId);
                UpdateDataGridView();
            }
            else
            {
                MessageBox.Show("Выберите заказ для доставки!");
            }
        }

        private void UpdateDataGridView()
        {
            dataGridView1.Rows.Clear();
            foreach (Order order in orders)
            {
                dataGridView1.Rows.Add(order.Id, order.Recipient, order.Address, order.DeliveryDate.ToShortDateString());
            }
        }
    }

    public class Order
    {
        public int Id { get; set; }
        public string Recipient { get; set; }
        public string Address { get; set; }
        public DateTime DeliveryDate { get; set; }

        public Order(int id, string recipient, string address, DateTime deliveryDate)
        {
            Id = id;
            Recipient = recipient;
            Address = address;
            DeliveryDate = deliveryDate;
        }
    }
}
