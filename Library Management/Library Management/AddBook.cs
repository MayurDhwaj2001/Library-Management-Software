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

namespace Library_Management
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.; Initial Catalog=LibraryManagement; Integrated Security=True");

            conn.Open();

            string query = $"INSERT INTO AddBook (BName,BAuthor,BPurchaseDate,BPrice,BQuantity) VALUES('{txtBName.Text}','{txtAName.Text}','{PurchasePicker.Value}',{txtPrice.Text},{txtQuantity.Text})";

            SqlCommand cmd = new SqlCommand(query,conn);

            if (txtBName.Text != "" && txtAName.Text != "" && txtPrice.Text != "" && txtQuantity.Text != "")
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved!");
            }

            else
            {
                MessageBox.Show("Please fill the details","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conn.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
