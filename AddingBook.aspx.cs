using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using System.Xml.Linq;
using System.Security.Cryptography;

public partial class Default3 : System.Web.UI.Page
{
    private SqlConnection con = new SqlConnection();
    private string conString = "Server=(local);Database=LMS;Integrated Security=True;";
    private SqlCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {
        gridView1.DataBind();
       
    }
    
    protected void Button1_Click(object sender, EventArgs e)
    {
        string bookId = tbId.Text;
        string bookName = tbAname.Text;
        string language = Dropdownlist1.SelectedValue.ToString();
        string publisherName = tbPname.Text;    
        string authorName = tbAname.Text;  
        string publishDate = tbPdate.Text;
        string genre = ListBox1.Text;
        string edition = tbedition.Text;
        string bookCost = tbBookCost.Text;
        string pages = tbPages.Text;

        try
        {
            con.ConnectionString = conString;
            cmd = con.CreateCommand();
            string query = "Insert into Add_book values('"
                + bookId + "','"
                + bookName + "','"
                + language + "','"
                + publisherName + "','"
                + authorName + "','"
                + publishDate + "','"
                + genre + "','"
                + edition + "','"
                + bookCost + "','"
                + pages + "')";
            cmd.CommandText = query;
            con.Open();
            cmd.ExecuteScalar();
            Response.Write("<script>alert('Book Added Successfully');</script>");
        }
        catch(Exception ex)
        {
            Response.Write("<script>alert('" + ex.Message + "');</script>");
        }
        finally
        {
            cmd.Dispose();
            con.Close();
        }

        gridView1.DataBind();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {

        string bookName = tbAname.Text;

        try
        {
            con.ConnectionString = conString;
            cmd = con.CreateCommand();
            string query = "Delete from Add_book where book_name='" + bookName + "'";
            cmd.CommandText = query;
            con.Open();
            cmd.ExecuteScalar();
            Response.Write("<script>alert('Book Deleted Successfully');</script>");
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

        //  SqlCommand cm = new SqlCommand("Delete from Add_book where Book_name='" + TextBox2.Text.Trim() + "'",cn);

        gridView1.DataBind(); 

    }



    protected void gridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }
}