using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library_Application
{
    public partial class Course_Entry : Form
    {
        Home fa = new Home();

        public Course_Entry()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Libraryob ob = new Libraryob();
            ob.connectionOpen();
            ob.insertCourse(textBox1.Text.ToString());
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
