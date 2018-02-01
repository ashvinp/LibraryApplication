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
    public partial class Display_Date_Wise : Form
    {
        Libraryob ob = new Libraryob();
        SqlDataReader dr;
        DataSet ds = new DataSet();
        Home fa = new Home();
        public Display_Date_Wise()
        {
            InitializeComponent();
        }

        private void Display_Date_Wise_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ob.connectionOpen();
            ds = ob.displaydatewise(dateTimePicker1.Value.ToString("yyyy-MM-dd"));
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
