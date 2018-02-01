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
    public partial class Display_Student_Wise : Form
    {
        Libraryob ob = new Libraryob();
        SqlDataReader dr;
        DataSet ds = new DataSet();
        Home fa = new Home();
        public Display_Student_Wise()
        {
            InitializeComponent();
        }

        private void Display_Student_Wise_Load(object sender, EventArgs e)
        {
            ob.connectionOpen();
            dr = ob.displayComboBox("tbl_Student");
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["USN"]);
            }
            ob.connectionClose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ob.connectionOpen();
            ds = ob.displaystudentwise(comboBox1.SelectedItem.ToString());
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "tbl_BookIssue";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fa.Show();
            this.Hide();
        }
    }
}
