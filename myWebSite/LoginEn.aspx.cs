using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;

public partial class LoginEn : System.Web.UI.Page
{
     string s= (@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\hp\Documents\Visual Studio 2008\WebSites\myWebSite\App_Data\DB.mdf;Integrated Security=True;User Instance=True");
    SqlConnection connection;
    SqlCommand command;

    protected void Page_Load(object sender, EventArgs e)
    {


    }
protected void  Button1_Click(object sender, EventArgs e)
{
     try{
         connection = new SqlConnection(s);
         connection.Open();
         string selectA = "SELECT *FROM Admin WHERE name='"+txtusername.Text.Trim()+"'And password='"+txtpassword.Text.Trim()+"'" ;
         command = new SqlCommand(selectA , connection);
         SqlDataReader reader = command.ExecuteReader();
         if (reader.Read())
         {
             Label1.Visible = false;
                string AdminName = reader.GetString(0);
                Session.Add("aAdminNAme", AdminName);
                connection.Close();
                Response.Redirect("adminmain.aspx");
        }else {
              Label1.Visible=true;
              Label1.Text= "Please , Confirm Login Data ";
              connection.Close();
            }
     }
     catch(Exception ex)
     {
      Response.Write("Error :"+ ex.ToString());
     }

    try{
            connection = new SqlConnection(s);
            connection.Open();
            string select = "SELECT *FROM users WHERE  user_id='" + txtusername.Text.Trim() + "'AND password='" + txtpassword.Text.Trim() + "'";
            command = new SqlCommand(select, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                //session for Mine Page 
                Label1.Visible = false;
                string id = reader.GetString(0);
                string name = reader.GetString(3);
                string major = reader.GetString(4);
                string earn = reader.GetString(5);
                string gpa = reader.GetString(6);
                string gpah = reader.GetString(7);
                string rem = reader.GetString(8);
                Session.Add("sid", id);
                Session.Add("sname", name);
                Session.Add("smajor", major);
                Session.Add("searn", earn);
                Session.Add("sgpa", gpa);
                Session.Add("sgpah", gpah);
                Session.Add("sremander", rem);




                connection.Close();
                Response.Redirect("MainEn.aspx");
            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "Please , Confirm Login Data ";
                connection.Close();

            }
        }
     catch (Exception ex)
        {
            Response.Write("Error:" +ex.ToString());
            connection.Close();
        }

     }

}


