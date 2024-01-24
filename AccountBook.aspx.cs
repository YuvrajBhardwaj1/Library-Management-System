using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Default3 : System.Web.UI.Page
{
    private SqlConnection con = new SqlConnection();
    private string conString = "Server=(local);Database=LMS;Integrated Security=True;";
    private SqlCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        string name = tbname.Text;
        string Teachertype = RadioTeacher.Text;
        string StudentType = RadioStudent.Text;
        string date = tbDate.Text;
        string teacherID = tbTID.Text;
        string studentRollN = tbSRN.Text;
        string studentClass = tbClass.Text;
        string date1 = tbDate1.Text;

        if (RadioTeacher.Checked == true)
        {
            try
            {
                con.ConnectionString = conString;
                cmd = con.CreateCommand();
                string query = "Insert into acc_book values('"
                    + name + "','"
                    + Teachertype + "','"
                    + teacherID + "','"
                    + null + "','"
                    + null + "','"
                    + date + "')";
                cmd.CommandText = query;
                con.Open();
                cmd.ExecuteScalar();
                Response.Write("<script>alert('Account Added Successfully');</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
            finally 
            {
                cmd.Dispose();
                con.Close(); 
            }
        }
        else if (RadioStudent.Checked == true)
        {
            try
            {
                con.ConnectionString = conString;
                cmd = con.CreateCommand();
                string query = "Insert into acc_book values('"
                    + name + "','"
                    + StudentType + "','"
                    + null + "','"
                    + studentRollN + "','"
                    + studentClass + "','"
                    + date1 + "')";
                cmd.CommandText = query;
                con.Open();
                cmd.ExecuteScalar();
                Response.Write("<script>alert('Account Added Successfully');</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
        }
    }
    protected void Teacher_CheckedChanged(object sender, EventArgs e)
    {
        Panel2.Visible = true;
        Panel3.Visible = false;
    }
    protected void Student_CheckedChanged(object sender, EventArgs e)
    {
        Panel2.Visible = false;        
        Panel3.Visible = true;

    }
}