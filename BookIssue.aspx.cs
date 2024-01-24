using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Security.Cryptography;

public partial class Default3 : System.Web.UI.Page
{

    private SqlConnection con = new SqlConnection();
    private string conString = "Server=(local);Database=LMS;Integrated Security=True;";
    private SqlCommand cmd;
    protected void Page_Init(object sender, EventArgs e)
    {
        loadbook();
      
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        /* SqlConnection cn = new SqlConnection("server=.;Database=LMS;Trusted_connection=true;");
         cn.Open();
         SqlCommand cm = new SqlCommand("Insert into issue_book(srno,Book_id,book_name,account_no,account_type,name,issue_date,due_date,return_date,reissue_date,Fine) values ((select isnull(max(srno),0)from Issue_book)+1," + TextBox2.Text + ",'" + DropDownList2.Text + "'," + TextBox3.Text + ",'" + TextBox8.Text + "','" + TextBox4.Text + "','" + TextBox1.Text + "','" + Convert.ToDateTime(TextBox6.Text).ToString("yyyy-MM-dd") + "','" + Convert.ToDateTime(TextBox5.Text).ToString("yyyy-MM-dd") + "','" + Convert.ToDateTime(TextBox10.Text).ToString("yyyy-MM-dd") + "','" + TextBox7.Text + "')", cn);
         cm.ExecuteNonQuery();
         cn.Close();*/

        try
        {
            con.ConnectionString = conString;
            cmd = con.CreateCommand();
            string query = "Insert into issue_book values('"
                + TextBox2.Text + "','"
                + DropDownList2.Text + "','"
                + TextBox3.Text + "','"
                + TextBox8.Text + "','"
                + TextBox4.Text + "','"
                + TextBox1.Text + "','"
                + TextBox6.Text + "','"
                + TextBox5.Text + "','"
                + TextBox10.Text+ "','"
                + TextBox7.Text + "')";
            cmd.CommandText = query;
            con.Open();
            cmd.ExecuteScalar();
            Response.Write("<script>alert('Book Issued Successfully');</script>");
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

    void loadbook()
    {
        /*SqlConnection cn = new SqlConnection("server=.;Database=LMS;Trusted_connection= true;");
        cn.Open();
        SqlCommand cm = new SqlCommand("select * from Add_book", cn);
        SqlDataReader dr;
        dr = cm.ExecuteReader();
        while (dr.Read())
        {
            DropDownList2.Items.Add(dr[2].ToString());
        }*/

        try
        {
            con.ConnectionString = conString;
            cmd = con.CreateCommand();
            string query = "select * from Add_book";
            cmd.CommandText = query;
            con.Open();
            cmd.ExecuteScalar();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DropDownList2.Items.Add(dr[2].ToString());
            }

        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('" + ex.Message + "');</script>");
        }

    }

    void loadAccountName()
    {

        try
        {
            con.ConnectionString = conString;
            cmd = con.CreateCommand();
            string query = "select book_Id from Add_book where book_name = '" + DropDownList2.Text + "'";
            cmd.CommandText = query;
            con.Open();
            cmd.ExecuteScalar();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                TextBox2.Text = dr[0].ToString();
            }

        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('" + ex.Message + "');</script>");
        }


    }

    void loadAccountTypeName()
    {


        try
        {
            con.ConnectionString = conString;
            cmd = con.CreateCommand();
            string query = "select name, Type_ from acc_book where Account_no = " + TextBox3.Text + "'";
            cmd.CommandText = query;
            con.Open();
            cmd.ExecuteScalar();
            SqlDataReader dr;

            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                TextBox8.Text = dr[2].ToString();
                TextBox4.Text = dr[1].ToString();
            }
            dr.Close();

        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('" + ex.Message + "');</script>");
        }
        finally
        {

            con.Dispose();
            con.Close();

        }

    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        /*SqlConnection cn = new SqlConnection("server=.;database=LMS;Trusted_connection=true;");
        cn.Open();
        SqlCommand cm = new SqlCommand("select Book_ID from Add_book where Book_name ='" + DropDownList2.Text + "'", cn);
        SqlDataReader dr;
        dr = cm.ExecuteReader();
        while (dr.Read())
        {
            TextBox2.Text = dr[0].ToString();
        }*/

        loadAccountName();

    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        /*TextBox6.Text = (Convert.ToDateTime(TextBox1.Text).AddDays(45).ToString("dd-MM-yyyy"));
        TextBox5.Text = (Convert.ToDateTime(TextBox1.Text).AddDays(30).ToString("dd-MM-yyyy"));
        TextBox10.Text = (Convert.ToDateTime(TextBox1.Text).AddMonths(2).ToString("dd-MM-yyyy"));
        TimeSpan ts = Convert.ToDateTime(DateTime.Now.ToString()) - Convert.ToDateTime(TextBox6.Text);
        int f = Convert.ToInt32(ts.Days) * 10;
        TextBox7.Text = f.ToString();*/

        // Assuming TextBox1.Text contains a valid date in the format "dd-MM-yyyy"

        try
        {
            // Convert TextBox1.Text to a DateTime object
            DateTime inputDate = Convert.ToDateTime(TextBox1.Text);

            // Calculate and set TextBox6.Text as the date 45 days from inputDate
            TextBox6.Text = inputDate.AddDays(45).ToString("dd-MM-yyyy");

            // Calculate and set TextBox5.Text as the date 30 days from inputDate
            TextBox5.Text = inputDate.AddDays(30).ToString("dd-MM-yyyy");

            // Calculate and set TextBox10.Text as the date 2 months from inputDate
            TextBox10.Text = inputDate.AddMonths(2).ToString("dd-MM-yyyy");

            // Calculate the difference in days between the current date and TextBox6.Text
            TimeSpan ts = DateTime.Now - Convert.ToDateTime(TextBox6.Text);

            // Multiply the days difference by 10 and set TextBox7.Text
            int f = Convert.ToInt32(ts.Days) * 10;
            TextBox7.Text = f.ToString();
        }
        catch (Exception ex)
        {
            // Handle any exceptions that may occur during the conversion or calculations
            // Display or log the error message as needed
            Response.Write("<script>alert('" + ex.Message + "');</script>");
        }

    }
    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {
        /*SqlConnection cn = new SqlConnection("server=.;Database=LMS;Trusted_connection= true;");
        cn.Open();
        SqlCommand cm = new SqlCommand("select Name, Type from Account_book where Account_no = " + TextBox3.Text + "", cn);
        SqlDataReader dr;
        dr = cm.ExecuteReader();
        while (dr.Read())
        {
            TextBox8.Text = dr[1].ToString();
            TextBox4.Text = dr[0].ToString();
        }
        dr.Close();
        cn.Close();*/
        loadAccountTypeName();

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        /*SqlConnection cn = new SqlConnection("server=.;Database=LMS;Trusted_connection= true;");
        cn.Open();
        SqlCommand cm = new SqlCommand("Delete from issue_book where Book_ID =" + TextBox2.Text + "", cn);
        cm.ExecuteNonQuery();
        //disp_data();
        cn.Close();*/

        try
        {
            con.ConnectionString = conString;
            cmd = con.CreateCommand();
            string query = "Delete from issue_book where book_Id = " + TextBox2.Text + "'";
            cmd.CommandText = query;
            con.Open();
            cmd.ExecuteScalar();
    

        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('" + ex.Message + "');</script>");
        }
        finally
        {
            con.Dispose();
            con.Close();
        }
    }
}