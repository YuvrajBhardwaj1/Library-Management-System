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
        try
        {           
           
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            con.ConnectionString = conString;
            cmd = con.CreateCommand();
            string query = "Select * from U_reg where Username='" + tbUsername.Text.Trim() + "'AND Password_='" + tbPassword.Text.Trim() + "';";
            cmd.CommandText = query;
            con.Open();
            
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    
                    Session["Username"] = dr["Username"].ToString();
                    Session["Fullname"] = dr["FullName"].ToString();
                    Session["role"] = "user";
                    Response.Write("<script>alert('Login successful');</script>");

                }
                Response.Redirect("HomePage.aspx");
            }
            else
            {
                Response.Write("<script>alert('Invalid credentials');</script>");
            }
            dr.Close();
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