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
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.; Database=LibraryManagement; Integrated Security=True");

            conn.Open();

            string query = $"INSERT INTO LoginTable (UserName,Password) VALUES ('{txtName.Text}','{txtPassword.Text}')";
            SqlCommand cmd = new SqlCommand(query,conn);
            cmd.ExecuteNonQuery();
            conn.Close();


            Dashboard d = new Dashboard();
            d.Show();
            this.Close();
        }

        private void txtName_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtName.Text == "Username")
            {
                txtName.Clear();
            }
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Clear();
                txtPassword.PasswordChar = '*';
            }
        }
    }
}
