using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SiteMaster : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            
            if (Session["role"] != null && Session["role"].Equals("user"))
            {

                LinkButton1.Visible = false;
                LinkButton2.Visible = false;
                LinkButton3.Visible = true;
                LinkButton7.Visible = true;
                LinkButton7.Text = "Hello" + " " + Session["username"].ToString();
                LinkButton8.Visible = true;
                LinkButton11.Visible = true;
                LinkButton12.Visible = true;
            }
            else
            {

                LinkButton1.Visible = true;
                LinkButton2.Visible = true;
                LinkButton3.Visible = false;
                LinkButton7.Visible = false;
                LinkButton8.Visible = false;
                LinkButton11.Visible = false;
                LinkButton12.Visible = false;
            }

        }

        catch(Exception ex)
        { 
        
        
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("UserLogin.aspx");
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("SignUp.aspx");
    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        Session["username"] = "";
        Session["Fullname"] = "";
        Session["role"] = "";

        LinkButton1.Visible = true;
        LinkButton2.Visible = true;
        LinkButton3.Visible = false;
        LinkButton7.Visible = false;
        LinkButton8.Visible = true;
        LinkButton11.Visible = true;
        LinkButton12.Visible = true;
    }
    protected void LinkButton11_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddingBook.aspx");
    }
    protected void LinkButton12_Click(object sender, EventArgs e)
    {
        Response.Redirect("BookIssue.aspx");
    }
    protected void LinkButton8_Click(object sender, EventArgs e)
    {
        Response.Redirect("AccountBook.aspx");
    }
    protected void LinkButton7_Click(object sender, EventArgs e)
    {

    }
    protected void LinkButton4_Click(object sender, EventArgs e)
    {

    }

    protected void LinkButton7_Click1(object sender, EventArgs e)
    {
        Response.Redirect("Userviewprofile.aspx");
    }
}
