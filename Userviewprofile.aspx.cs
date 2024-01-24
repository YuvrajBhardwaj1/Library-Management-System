using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.IO;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Session["username"].ToString() == "" || Session["username"] == null)
            {
                Response.Write("<script>alert('Session expired login again');</script>");
                Response.Redirect("UserLogin.aspx");
            }
            else
            {
                getuserbookdata();
                if(!Page.IsPostBack)
                {
                    getuserpersonaldata();
                }
            }
        }
        catch
        {
            Response.Write("<script>alert('Session expired login again');</script>");
            Response.Redirect("UserLogin.aspx");
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Session["username"].ToString() == "" || Session["username"] == null)
        {
            Response.Write("<script>alert('Session expired login again');</script>");
            Response.Redirect("UserLogin.aspx");
        }
        else
        {
            updateuserpersonaldetails();
        }
    }
    void updateuserpersonaldetails()
    {
        string password = "";
        if (TextBox10.Text.Trim() == "")
        {
            password = TextBox9.Text.Trim();
        }
        else
        {
            password = TextBox10.Text.Trim();
        }
        try
        {
            SqlConnection con = new SqlConnection("server=ASUSZENBOOK//yb;database=LMS;trusted_connection=true;");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }


            SqlCommand cmd = new SqlCommand("update U_reg set full_name=@Fullname, dob=@DOB, contact_no=@Contact_no, email=@Email_ID, state=@State_, city=@City, pincode=@Pincode, full_address=@Fulladdress, password=@Password_, account_status=@Account_status WHERE Username='" + Session["username"].ToString().Trim() + "'", con);

            cmd.Parameters.AddWithValue("@Fullname", TextBox1.Text.Trim());
            cmd.Parameters.AddWithValue("@DOB", TextBox2.Text.Trim());
            cmd.Parameters.AddWithValue("@Contact_no", TextBox3.Text.Trim());
            cmd.Parameters.AddWithValue("@Email_ID", TextBox4.Text.Trim());
            cmd.Parameters.AddWithValue("@State_", DropDownList1.SelectedItem.Value);
            cmd.Parameters.AddWithValue("@City", TextBox6.Text.Trim());
            cmd.Parameters.AddWithValue("@Pincode", TextBox5.Text.Trim());
            cmd.Parameters.AddWithValue("@Fulladdress", TextBox7.Text.Trim());
            cmd.Parameters.AddWithValue("@Password_", password);
            cmd.Parameters.AddWithValue("@Account_status", "pending");

            int result = cmd.ExecuteNonQuery();
            con.Close();
            if (result > 0)
            {

                Response.Write("<script>alert('Your Details Updated Successfully');</script>");
                getuserpersonaldata();
                getuserbookdata();
            }
            else
            {
                Response.Write("<script>alert('Invalid entry');</script>");
            }

        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('" + ex.Message + "');</script>");
        }
    }

    void getuserpersonaldata()
    {
        try
        {
            SqlConnection cn = new SqlConnection("server=ASUSZENBOOK//yb;database=LMS;trusted_connection=true;");
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            SqlCommand cm = new SqlCommand("Select * from U_reg where Username='" + Session["username"].ToString() + "';", cn);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            TextBox1.Text = dt.Rows[0]["Fullname"].ToString();
            TextBox2.Text = dt.Rows[0]["DOB"].ToString();
            TextBox3.Text = dt.Rows[0]["Contact_no"].ToString();
            TextBox4.Text = dt.Rows[0]["Email_ID"].ToString();
            DropDownList1.SelectedValue = dt.Rows[0]["State_"].ToString();
            TextBox6.Text = dt.Rows[0]["City"].ToString();
            TextBox5.Text = dt.Rows[0]["Pincode"].ToString();
            TextBox7.Text = dt.Rows[0]["Fulladdress"].ToString();
            TextBox8.Text = dt.Rows[0]["Username"].ToString();
            TextBox9.Text = dt.Rows[0]["Password_"].ToString();


            Label1.Text = dt.Rows[0]["account_status"].ToString().Trim();

            if (dt.Rows[0]["account_status"].ToString().Trim() == "active")
            {
                Label1.Attributes.Add("class", "badge badge-pill badge-success");
            }
            else if (dt.Rows[0]["account_status"].ToString().Trim() == "pending")
            {
                Label1.Attributes.Add("class", "badge badge-pill badge-warning");
            }
            else if (dt.Rows[0]["account_status"].ToString().Trim() == "deactive")
            {
                Label1.Attributes.Add("class", "badge badge-pill badge-danger");
            }
            else
            {
                Label1.Attributes.Add("class", "badge badge-pill badge-info");
            }
        }
        catch(Exception ex)
        {
            Response.Write("<script>alert('" + ex.Message + "');</script>");
        }

    }

    void getuserbookdata()
    {
        try
        {
            SqlConnection cn = new SqlConnection("server=ASUSZENBOOK//yb;database=LMS;trusted_connection=true;");
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            SqlCommand cm = new SqlCommand("Select * from issue_book where Username='" + Session["username"].ToString() + "';", cn);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView2.DataSource = dt;
            GridView2.DataBind();
        }
        catch(Exception ex)
        {
            Response.Write("<script>alert('" + ex.Message + "');</script>");
        }

    }

    protected void GridView2_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        try
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //Check your condition here
                DateTime dt = Convert.ToDateTime(e.Row.Cells[5].Text);
                DateTime today = DateTime.Today;
                if (today > dt)
                {
                    e.Row.BackColor = System.Drawing.Color.PaleVioletRed;
                }
            }
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('" + ex.Message + "');</script>");
        }
    }
}