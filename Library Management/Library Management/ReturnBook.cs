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
    public partial class ReturnBook : Form
    {
        public ReturnBook()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (txtSearchEnrol.Text != "")
            {

                SqlConnection conn = new SqlConnection("Data Source=.; Database=LibraryManagement; Integrated Security=True");

                conn.Open();

                string query = $"SELECT Id,Enroll,SName,BName,BIssueDate,BReturnDate FROM IRBook WHERE Enroll='{txtSearchEnrol.Text}' AND BReturnDate IS null";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count != 0)
                {
                    this.Size = new Size(946, 423);

                    dataGridView1.DataSource = ds.Tables[0];
                }
                else
                {
                    MessageBox.Show("No book issued","No record",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }

                conn.Close();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtSearchEnrol.Text = "";
            this.Size = new Size(304, 423);
        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryManagementDataSet.IRBook' table. You can move, or remove it, as needed.
            this.iRBookTableAdapter.Fill(this.libraryManagementDataSet.IRBook);
            this.Size = new Size(304, 423);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn= new SqlConnection("Data Source=.; Database=LibraryManagement;Integrated Security=True");
            conn.Open();

            string query = $"UPDATE IRBook SET BReturnDate='{optionReturnDate.Text}'WHERE Enroll = '{txtSearchEnrol.Text}' AND Id={rowid}";
            SqlCommand cmd = new SqlCommand(query,conn);        
            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Book returned","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        string bname;
        string bdate;
        Int32 rowid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Size = new Size(946, 516);

            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                rowid = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                bname = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                bdate = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            txtBokName.Text = bname;
            txtIssueDate.Text = bdate;
        }
    }
}
