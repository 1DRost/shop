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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace best_shop
{
    public partial class Form3: Form
    {
        public Form3()
        {
            InitializeComponent();
            LoadStatuses();
        }

        private void LoadStatuses()
        {
            DataTable statusesTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(@"Data Source = DESKTOP-QAHQ2NA;Initial Catalog = mdk111; Integrated Security=True"))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM OrderStatuses", connection);
                adapter.Fill(statusesTable);
            }
            dataGridView1.DataSource = statusesTable;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 loginForm = new Form2();
            loginForm.Show();
        }
    }
}
