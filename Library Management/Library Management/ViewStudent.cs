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
    public partial class ViewStudent : Form
    {
        public ViewStudent()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be updated confirm?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                string name = txtName.Text;
                Int32 eno = Int32.Parse(txtENo.Text);
                string dep = txtDepartment.Text;
                string sem = (string)comboSem.SelectedItem;
                Int64 ph = Int64.Parse(txtContact.Text);
                string contact = txtContact.Text;
                string email = txtEmail.Text;

                SqlConnection conn = new SqlConnection("Data Source=.; Initial Catalog=LibraryManagement; Integrated Security= True");
                conn.Open();

                string query = $"UPDATE AddBook SET Name='{name}' , ENo={eno} , Department='{dep}' , Semester ='{sem}' , Contact={contact} , Email={email} WHERE SId='{rowid}' ";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("Saved");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtSearchBook.Clear();
            this.Size = new Size(746, 533);

            SqlConnection conn = new SqlConnection("Data Source=.; Database=LibraryManagement; Integrated Security=True");

            conn.Open();

            string query = $"SELECT * FROM NewStudent";

            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            conn.Close();

            // panel1.Visible = false;
        }

        private void ViewStudent_Load(object sender, EventArgs e)
        {            
            this.Size = new Size(746, 533);

            //panel1.Visible = false;

            SqlConnection conn = new SqlConnection("Data Source=.; Database=LibraryManagement; Integrated Security=True");

            conn.Open();

            string query = $"SELECT * FROM NewStudent";

            SqlCommand cmd = new SqlCommand(query, conn);

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
            this.Size = new Size(1117, 533);

            //panel1.Visible = true;

            SqlConnection conn = new SqlConnection("Data Source=.; Database=LibraryManagement; Integrated Security=True");
            conn.Open();

            string query = $"SELECT * FROM NewStudent WHERE SId={bid}";

            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            txtName.Text = ds.Tables[0].Rows[0][1].ToString();
            txtENo.Text = ds.Tables[0].Rows[0][2].ToString();
            txtDepartment.Text = ds.Tables[0].Rows[0][3].ToString();
            comboSem.SelectedItem = ds.Tables[0].Rows[0][4].ToString();
            txtContact.Text = ds.Tables[0].Rows[0][5].ToString();
            txtEmail.Text = ds.Tables[0].Rows[0][6].ToString();

            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Size = new Size(746, 533);

           // panel1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be deleted confirm?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {

                SqlConnection conn = new SqlConnection("Data Source=.; Initial Catalog=LibraryManagement; Integrated Security= True");
                conn.Open();

                string query = $"DELETE FROM NewStudent WHERE SId='{rowid}'";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("Saved");
            }
        }

        private void txtSearchBook_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchBook.Text != "")
            {

                SqlConnection conn = new SqlConnection("Data Source=.; Database=LibraryManagement; Integrated Security=True");
                conn.Open();

                string query = $"SELECT * FROM NewStudent WHERE ENo LIKE '{txtSearchBook.Text}%'";

                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                conn.Close();
            }
            }
    }
}
