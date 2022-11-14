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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Clear();
                txtPassword.PasswordChar = '*';
            }
        }

        private void txtName_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtName.Text == "Username")
            {
                txtName.Clear();
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.; Initial Catalog=LibraryManagement; Integrated Security=True");

            conn.Open();

            string query = $"SELECT * FROM LoginTable WHERE UserName='{txtName.Text}' AND Password='{txtPassword.Text}'";

            SqlCommand cmd = new SqlCommand(query,conn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            conn.Close();

            if (ds.Tables[0].Rows.Count != 0)
            {
                this.Hide();
                Dashboard dsa = new Dashboard();
                dsa.Show();
            }
            else
            {
                MessageBox.Show("Wrong Id or Password","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewUser nu = new NewUser();
            nu.Show();
            this.Hide();
        }
    }
}
