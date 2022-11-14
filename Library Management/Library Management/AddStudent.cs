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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {

        }

        private void txtENo_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.; Database=LibraryManagement; Integrated Security=True");

            conn.Open();

            string query = $"INSERT INTO NewStudent (Name,ENo,Department,Semester,Contact,Email) VALUES ('{txtName.Text}',{txtENo.Text},'{txtDepartment.Text}','{comboSem.SelectedItem}',{txtContact.Text},'{txtEmail.Text}')";
            SqlCommand cmd = new SqlCommand(query,conn);


            if (txtName.Text != "" && txtENo.Text != "" && txtDepartment.Text != "" && comboSem.SelectedItem!=null && txtContact.Text != "" && txtEmail.Text!="")
            {
                cmd.ExecuteNonQuery();

                txtName.Text = "";
                txtENo.Text = "";
                txtDepartment.Text = "";
                comboSem.SelectedItem = null;
                txtContact.Text = "";
                txtEmail.Text = "";

                MessageBox.Show("Saved!");
            }

            else
            {
                MessageBox.Show("Please fill the details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conn.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
