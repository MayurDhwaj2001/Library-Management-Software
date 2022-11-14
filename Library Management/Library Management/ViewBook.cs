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
    public partial class ViewBook : Form
    {
        public ViewBook()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ViewBook_Load(object sender, EventArgs e)
        {
            this.Size = new Size(655, 532);

          // panel1.Visible = false;

            SqlConnection conn = new SqlConnection("Data Source=.; Database=LibraryManagement; Integrated Security=True");

            conn.Open();

            string query = $"SELECT * FROM AddBook";

            SqlCommand cmd = new SqlCommand(query,conn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            conn.Close();

        }

            int bid;
        Int64 rowid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }

            this.Size = new Size(1108, 532);
          //  panel1.Visible = true;

            SqlConnection conn = new SqlConnection("Data Source=.; Database=LibraryManagement; Integrated Security=True");
            conn.Open();

            string query = $"SELECT * FROM AddBook WHERE BId={bid}";

            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            txtName.Text = ds.Tables[0].Rows[0][1].ToString();
            txtAuthor.Text = ds.Tables[0].Rows[0][2].ToString();
            txtDate.Text = ds.Tables[0].Rows[0][3].ToString();
            txtPrice.Text = ds.Tables[0].Rows[0][4].ToString();
            txtQuantity.Text = ds.Tables[0].Rows[0][5].ToString();
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Size = new Size(655, 532);
           // panel1.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchBook.Text != "")
            {

                SqlConnection conn = new SqlConnection("Data Source=.; Database=LibraryManagement; Integrated Security=True");
                conn.Open();

                string query = $"SELECT * FROM AddBook WHERE BName LIKE '{txtSearchBook.Text}%'";

                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                conn.Close();

            }
            else
            {

                SqlConnection conn = new SqlConnection("Data Source=.; Database=LibraryManagement; Integrated Security=True");
                conn.Open();

                string query = $"SELECT * FROM AddBook WHERE BId={bid}";

                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                conn.Close();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtSearchBook.Clear();
            this.Size = new Size(655, 532);

            SqlConnection conn = new SqlConnection("Data Source=.; Database=LibraryManagement; Integrated Security=True");

            conn.Open();

            string query = $"SELECT * FROM AddBook";

            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            conn.Close();
            // panel1.Visible = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be updated confirm?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            { 
            
            string bname = txtName.Text;
            string bauthor = txtAuthor.Text;
            string pdate = txtDate.Text;
            Int32 price = Int32.Parse(txtPrice.Text);
            Int32 quantity = Int32.Parse(txtQuantity.Text);

            SqlConnection conn = new SqlConnection("Data Source=.; Initial Catalog=LibraryManagement; Integrated Security= True");
            conn.Open();

            string query = $"UPDATE AddBook SET BName='{bname}' , BAuthor='{bauthor}' , BPurchaseDate='{pdate}' , BPrice ='{price}' , BQuantity='{quantity}' WHERE BId='{rowid}' ";

            SqlCommand cmd = new SqlCommand(query,conn);

            cmd.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Saved");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be deleted confirm?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {

                SqlConnection conn = new SqlConnection("Data Source=.; Initial Catalog=LibraryManagement; Integrated Security= True");
                conn.Open();

                string query = $"DELETE FROM AddBook WHERE BId='{rowid}'";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("Saved");
            }
            }
    }
}
