using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBook ab = new AddBook();
            ab.Show();
        }

        private void addStudentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddStudent ass= new AddStudent();
            ass.Show();
        }

        private void viewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBook vb= new ViewBook();
            vb.Show();
        }

        private void viewStudentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewStudent vs = new ViewStudent();
            vs.Show();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void issueBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueBook ib = new IssueBook();
            ib.Show();
        }

        private void returnBookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReturnBook rb = new ReturnBook();
            rb.Show();
        }
    }
}
