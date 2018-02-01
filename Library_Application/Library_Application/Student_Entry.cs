using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library_Application
{
    public partial class Student_Entry : Form
    {
        Libraryob ob = new Libraryob();
        SqlDataReader dr;
        Home fa = new Home();
        public Student_Entry()
        {
            InitializeComponent();
        }

        private void Student_Entry_Load(object sender, EventArgs e)
        {
            ob.connectionOpen();
            dr = ob.displayComboBox("tbl_Course");
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["CourseName"]);
            }
            ob.connectionClose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ob.connectionOpen();
            ob.insertstudent(textBox1.Text.ToString(), textBox2.Text.ToString(), int.Parse((comboBox1.SelectedIndex) + 1.ToString()));
            ob.connectionClose();
            MessageBox.Show("Data Added Successfully");
            fa.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fa.Show();
            this.Hide();
        }
    }
}
