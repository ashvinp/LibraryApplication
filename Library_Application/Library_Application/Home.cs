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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Course_Entry fa = new Course_Entry();
            fa.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Book_Entry fa = new Book_Entry();
            fa.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Student_Entry fa = new Student_Entry();
            fa.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Issue_Of_Books fa = new Issue_Of_Books();
            fa.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Display_Course_Wise fa = new Display_Course_Wise();
            fa.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Display_Date_Wise fa = new Display_Date_Wise();
            fa.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Display_Student_Wise fa = new Display_Student_Wise();
            fa.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
