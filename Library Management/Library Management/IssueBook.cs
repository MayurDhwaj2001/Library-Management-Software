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
    public partial class IssueBook : Form
    {
        public IssueBook()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtSearchEnrol.Text = "";
            this.Size = new Size(306, 480);
        }

        int count;
        private void button3_Click(object sender, EventArgs e)
        {
            if (txtSearchEnrol.Text != "")
            {

                SqlConnection conn = new SqlConnection("Data Source=.; Database=LibraryManagement; Integrated Security=True");

                conn.Open();

                string query = $"SELECT * FROM NewStudent WHERE ENo='{txtSearchEnrol.Text}'";
                SqlCommand cmd = new SqlCommand(query,conn);
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                //How  many book has been issued

                string query1 = $"SELECT COUNT(Enroll) FROM IRBook WHERE Enroll='{txtSearchEnrol.Text}' AND BReturnDate IS null";
                SqlCommand cmd1 = new SqlCommand(query1, conn);
                cmd.ExecuteNonQuery();

                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);

                count = int.Parse(ds1.Tables[0].Rows[0][0].ToString());

                //

                if (ds.Tables[0].Rows.Count != 0)
                {

                    this.Size = new Size(724, 480);


                    txtSName.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtENo.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtDepartment.Text = ds.Tables[0].Rows[0][3].ToString();
                    comboSem.SelectedItem = ds.Tables[0].Rows[0][4].ToString();
                    txtContact.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtEmail.Text = ds.Tables[0].Rows[0][6].ToString();
                }

                else
                {
                    MessageBox.Show("No data found");
                }

                conn.Close();
            }
            else if (txtSearchEnrol.Text == "")
            {
                MessageBox.Show("Please enter data","Filed Empty",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }


            else 
            {
                MessageBox.Show("Some Error Happened", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IssueBook_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryManagementDataSet.AddBook' table. You can move, or remove it, as needed.
            this.addBookTableAdapter.Fill(this.libraryManagementDataSet.AddBook);
            // TODO: This line of code loads data into the 'libraryManagementDataSet.NewStudent' table. You can move, or remove it, as needed.
            this.newStudentTableAdapter.Fill(this.libraryManagementDataSet.NewStudent);
            // TODO: This line of code loads data into the 'libraryDataSet.Book' table. You can move, or remove it, as needed.
            this.Size = new Size(306, 480);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtSearchEnrol.Text = "";
            this.Size = new Size(306, 480);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBook.SelectedIndex != -1 && count <= 2)
            {
                SqlConnection conn = new SqlConnection("Data Source=.; Database=LibraryManagement; Integrated Security=True");
                conn.Open();

                string query = $"INSERT INTO IRBook (Enroll,SName,Department,Semester,Contact,Email,BName,BIssueDate) VALUES ({txtENo.Text},'{txtSName.Text}','{txtDepartment.Text}','{comboSem.SelectedItem}',{txtContact.Text},'{txtEmail.Text}','{comboBook.SelectedItem}','{BookIssue.Value}')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Book Issued", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (count == 3)
            {
                MessageBox.Show("3 Book already issued","Limit Reached",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else 
            {
                MessageBox.Show("Unknown error");
            }
        }
    }
}
