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
    class Libraryob
    {
        SqlConnection conn;
        SqlCommand cmd, cmd2,cmd3,cmd4,cmd5;
        SqlDataReader dr,dr1;
        SqlDataAdapter da;
        DataSet ds;

        public void connectionOpen()
        {
            conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=\"C:\\Users\\ashwinp\\Desktop\\mysql\\Part-B 3rd Program\\Library_Application\\Library_Application\\Library.mdf\";Integrated Security=True;User Instance=True");
            conn.Open();
        }

        public void connectionClose()
        {
            conn.Close();
        }
        public void insertCourse(String name)
        {
            cmd = new SqlCommand("insert into tbl_Course values('" + name + "') ", conn);
            cmd.ExecuteNonQuery();
        }
        public void insertBook(String title, String author, int courseid)
        {
            cmd2 = new SqlCommand("insert into tbl_Book values('" + title + "', '" + author + "', " + courseid + ") ", conn);
            cmd2.ExecuteNonQuery();
        }
        public void insertstudent(String usn, String name, int courseid)
        {
            cmd3 = new SqlCommand("insert into tbl_Student values('" + usn + "', '" + name + "', " + courseid + ") ", conn);
            cmd3.ExecuteNonQuery();
        }
        public void insertbookissue(String usn, int bookid, String date)
        {
            cmd4 = new SqlCommand("insert into tbl_BookIssue values('" + usn + "', " + bookid + ", '" + date + "') ", conn);
            cmd4.ExecuteNonQuery();
        }
        public SqlDataReader displayComboBox(String TableName)
        {
            cmd = new SqlCommand("select * from " + TableName, conn);
            dr = cmd.ExecuteReader();
            return dr;
        }
        public SqlDataReader displayComboBox1(String TableName)
        {
            cmd5 = new SqlCommand("select * from " + TableName, conn);
            dr1 = cmd5.ExecuteReader();
            return dr1;
        }
        public DataSet displaycoursewise(int courseid)
        {
            ds = new DataSet();
            da = new SqlDataAdapter("select * from tbl_Book where CourseID=" + courseid, conn);
            da.Fill(ds, "tbl_Book");
            return ds;
        }
        public DataSet displaydatewise(string date)
        {
            ds = new DataSet();
            da = new SqlDataAdapter("select * from tbl_BookIssue where IssueDate='" + date + "'", conn);
            da.Fill(ds, "tbl_BookIssue");
            return ds;
        }
        public DataSet displaystudentwise(string usn)
        {
            ds = new DataSet();
            da = new SqlDataAdapter("select * from tbl_BookIssue where USN='" + usn + "'", conn);
            da.Fill(ds, "tbl_BookIssue");
            return ds;
        }

    }
}
