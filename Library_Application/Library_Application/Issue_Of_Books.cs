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
    public partial class Issue_Of_Books : Form
    {
        Libraryob ob = new Libraryob();
        SqlDataReader dr;
        SqlDataReader dr1;
        Home fa = new Home();
        public Issue_Of_Books()
        {
            InitializeComponent();
        }

        private void Issue_Of_Books_Load(object sender, EventArgs e)
        {
            ob.connectionOpen();
            dr = ob.displayComboBox("tbl_Student");
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["USN"]);
            }
            ob.connectionClose();
            ob.connectionOpen();
            dr1 = ob.displayComboBox1("tbl_Book");
            while (dr1.Read())
            {
                comboBox2.Items.Add(dr1["BookTitle"]);
            }
            ob.connectionClose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ob.connectionOpen();
            ob.insertbookissue(comboBox1.SelectedItem.ToString(), int.Parse((comboBox2.SelectedIndex)+1.ToString()), dateTimePicker1.Value.ToString("yyyy-MM-dd"));
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
