
namespace Library_Management
{
    partial class IssueBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboSem = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.txtENo = new System.Windows.Forms.TextBox();
            this.txtSName = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtSearchEnrol = new System.Windows.Forms.TextBox();
            this.BookIssue = new System.Windows.Forms.DateTimePicker();
            this.comboBook = new System.Windows.Forms.ComboBox();
            this.libraryManagementDataSet = new Library_Management.LibraryManagementDataSet();
            this.newStudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newStudentTableAdapter = new Library_Management.LibraryManagementDataSetTableAdapters.NewStudentTableAdapter();
            this.addBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addBookTableAdapter = new Library_Management.LibraryManagementDataSetTableAdapters.AddBookTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newStudentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addBookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboSem
            // 
            this.comboSem.DataSource = this.newStudentBindingSource;
            this.comboSem.DisplayMember = "Semester";
            this.comboSem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSem.Enabled = false;
            this.comboSem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSem.FormattingEnabled = true;
            this.comboSem.Location = new System.Drawing.Point(469, 199);
            this.comboSem.Name = "comboSem";
            this.comboSem.Size = new System.Drawing.Size(220, 27);
            this.comboSem.TabIndex = 8;
            this.comboSem.ValueMember = "Semester";
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(469, 274);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(220, 27);
            this.txtEmail.TabIndex = 10;
            // 
            // txtContact
            // 
            this.txtContact.Enabled = false;
            this.txtContact.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.Location = new System.Drawing.Point(469, 236);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(220, 27);
            this.txtContact.TabIndex = 9;
            // 
            // txtDepartment
            // 
            this.txtDepartment.Enabled = false;
            this.txtDepartment.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartment.Location = new System.Drawing.Point(469, 160);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(220, 27);
            this.txtDepartment.TabIndex = 7;
            // 
            // txtENo
            // 
            this.txtENo.Enabled = false;
            this.txtENo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtENo.Location = new System.Drawing.Point(469, 123);
            this.txtENo.Name = "txtENo";
            this.txtENo.Size = new System.Drawing.Size(220, 27);
            this.txtENo.TabIndex = 6;
            // 
            // txtSName
            // 
            this.txtSName.Enabled = false;
            this.txtSName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSName.Location = new System.Drawing.Point(469, 86);
            this.txtSName.Name = "txtSName";
            this.txtSName.Size = new System.Drawing.Size(220, 27);
            this.txtSName.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(219)))), ((int)(((byte)(148)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(594, 390);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 35);
            this.button2.TabIndex = 23;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(304, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 19);
            this.label7.TabIndex = 27;
            this.label7.Text = "Email";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(219)))), ((int)(((byte)(148)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(469, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 35);
            this.button1.TabIndex = 22;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(304, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 19);
            this.label6.TabIndex = 28;
            this.label6.Text = "Contact";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(304, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 29;
            this.label5.Text = "Semester";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(304, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 19);
            this.label4.TabIndex = 30;
            this.label4.Text = "Department";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(304, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 19);
            this.label3.TabIndex = 31;
            this.label3.Text = "Enrolment No.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(304, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 32;
            this.label2.Text = "Student Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(396, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 36);
            this.label1.TabIndex = 26;
            this.label1.Text = "Issue Book";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Library_Management.Properties.Resources.book_removebg_preview_1_;
            this.pictureBox2.Location = new System.Drawing.Point(301, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 72);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(304, 319);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 19);
            this.label8.TabIndex = 32;
            this.label8.Text = "Book Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(304, 357);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 19);
            this.label9.TabIndex = 32;
            this.label9.Text = "Book Issue Date";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(219)))), ((int)(((byte)(148)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.txtSearchEnrol);
            this.panel1.Location = new System.Drawing.Point(21, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 343);
            this.panel1.TabIndex = 33;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Library_Management.Properties.Resources.Id;
            this.pictureBox1.Location = new System.Drawing.Point(84, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(26, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(187, 23);
            this.label10.TabIndex = 26;
            this.label10.Text = "Enter Enrollement No.";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(228)))), ((int)(((byte)(175)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(131, 289);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 35);
            this.button5.TabIndex = 4;
            this.button5.Text = "Exit";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(228)))), ((int)(((byte)(175)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(17, 289);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 35);
            this.button4.TabIndex = 3;
            this.button4.Text = "Refresh";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(149)))), ((int)(((byte)(131)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(56, 204);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 54);
            this.button3.TabIndex = 2;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtSearchEnrol
            // 
            this.txtSearchEnrol.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchEnrol.Location = new System.Drawing.Point(30, 151);
            this.txtSearchEnrol.Name = "txtSearchEnrol";
            this.txtSearchEnrol.Size = new System.Drawing.Size(183, 27);
            this.txtSearchEnrol.TabIndex = 1;
            // 
            // BookIssue
            // 
            this.BookIssue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookIssue.Location = new System.Drawing.Point(469, 351);
            this.BookIssue.Name = "BookIssue";
            this.BookIssue.Size = new System.Drawing.Size(220, 27);
            this.BookIssue.TabIndex = 12;
            // 
            // comboBook
            // 
            this.comboBook.DataSource = this.addBookBindingSource;
            this.comboBook.DisplayMember = "BName";
            this.comboBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBook.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBook.FormattingEnabled = true;
            this.comboBook.Location = new System.Drawing.Point(469, 313);
            this.comboBook.Name = "comboBook";
            this.comboBook.Size = new System.Drawing.Size(220, 27);
            this.comboBook.TabIndex = 34;
            this.comboBook.ValueMember = "BName";
            // 
            // libraryManagementDataSet
            // 
            this.libraryManagementDataSet.DataSetName = "LibraryManagementDataSet";
            this.libraryManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // newStudentBindingSource
            // 
            this.newStudentBindingSource.DataMember = "NewStudent";
            this.newStudentBindingSource.DataSource = this.libraryManagementDataSet;
            // 
            // newStudentTableAdapter
            // 
            this.newStudentTableAdapter.ClearBeforeFill = true;
            // 
            // addBookBindingSource
            // 
            this.addBookBindingSource.DataMember = "AddBook";
            this.addBookBindingSource.DataSource = this.libraryManagementDataSet;
            // 
            // addBookTableAdapter
            // 
            this.addBookTableAdapter.ClearBeforeFill = true;
            // 
            // IssueBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(228)))), ((int)(((byte)(175)))));
            this.ClientSize = new System.Drawing.Size(713, 441);
            this.Controls.Add(this.comboBook);
            this.Controls.Add(this.BookIssue);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboSem);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.txtENo);
            this.Controls.Add(this.txtSName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "IssueBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issue Book";
            this.Load += new System.EventHandler(this.IssueBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newStudentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addBookBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboSem;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.TextBox txtENo;
        private System.Windows.Forms.TextBox txtSName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtSearchEnrol;
        private System.Windows.Forms.DateTimePicker BookIssue;
        private System.Windows.Forms.ComboBox comboBook;
        private LibraryManagementDataSet libraryManagementDataSet;
        private System.Windows.Forms.BindingSource newStudentBindingSource;
        private LibraryManagementDataSetTableAdapters.NewStudentTableAdapter newStudentTableAdapter;
        private System.Windows.Forms.BindingSource addBookBindingSource;
        private LibraryManagementDataSetTableAdapters.AddBookTableAdapter addBookTableAdapter;
    }
}