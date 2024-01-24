using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Activities.Statements;

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
        if (Checkmemberexist())
        {
            Response.Write("<script>alert('Member exist with this ID. Try another ID');</script>");
        }
        else
        {
            Signupnewuser(); 
        }        
    }


    bool Checkmemberexist()
    {

        try
        {

            con.ConnectionString = conString;
            cmd = con.CreateCommand();

            
            string query = "Select * from U_reg where Username = '" + tbUsername.Text + "'";
            con.Open();
            cmd.CommandText = query;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count >= 1)
            {
                return true;

            }
            else
            {
                return false;
            }
                       
            Response.Write("<script>alert('Sign Up successfully. Go back to Login page to Log in');</script>"); 
            

        
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
        return false;
    
    
    }

    void Signupnewuser()
    {
        

            string fullname = Full_name.Text;
            string date_of_birth = DOB.Text;
            string contactNo = Contactno.Text;
            string emailId = Email_id.Text;
            string state = DropDownList1.SelectedIndex.ToString();
            string city = tbCity.Text;
            string Pincode = tbPincode.Text;
            string Fulladdress = tbFA.Text;
            string Username  = tbUsername.Text;
            string password = tbPassword.Text;

        if (fullname == "" || date_of_birth == "" || contactNo == "" || emailId == "" || state == "" || city == "" || Pincode == "" || Fulladdress == "" || Username == "" || password == "")
        {
            Response.Write("<script>alert('Enter the Full Details. Not submitted!');</script>");
        }
        else
        {
            
            try
            {
                con.ConnectionString = conString;
                cmd = con.CreateCommand();
                string query = "Insert into U_reg values('"
                        + fullname + "','"
                        + date_of_birth + "','"
                        + contactNo + "','"
                        + emailId + "','"
                        + state + "','"
                        + city + "','"
                        + Pincode + "','"
                        + Fulladdress + "','"
                        + Username + "','"
                        + password + "')";

                cmd.CommandText = query;
                con.Open();
                cmd.ExecuteScalar();
                Response.Write("<script>alert('Sign Up successfully. Go back to Login page to Log in');</script>");

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

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
}