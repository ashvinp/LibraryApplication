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
    public partial class Display_Course_Wise : Form
    {
        Libraryob ob = new Libraryob();
        SqlDataReader dr;
        DataSet ds = new DataSet();
        Home fa = new Home();
        public Display_Course_Wise()
        {
            InitializeComponent();
        }

        private void Display_Course_Wise_Load(object sender, EventArgs e)
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
            ds = ob.displaycoursewise(int.Parse((comboBox1.SelectedIndex) + 1.ToString()));
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "tbl_Book";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fa.Show();
            this.Hide();
        }
    }
}
