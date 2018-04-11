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

public partial class MainEn : System.Web.UI.Page
{
    string s = (@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\hp\Documents\Visual Studio 2008\WebSites\myWebSite\App_Data\DB.mdf;Integrated Security=True;User Instance=True");
    SqlConnection connection;
    SqlCommand command;


    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = Session["sname"].ToString();
        Label2.Text = Session["sid"].ToString();
        Label3.Text = Session["smajor"].ToString();
        Label4.Text = Session["sgpa"].ToString();
        Label5.Text = Session["searn"].ToString();
        Label6.Text = Session["sgpah"].ToString();
        Label7.Text = Session["sname"].ToString();
        Label10.Text= Session["sremander"].ToString();

        Label8.Text = DateTime.Now.DayOfWeek.ToString();
        Label9.Text = DateTime.Today.ToShortDateString();


    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (DropDownList1.Text == "Raise the number hours above 18 Hours" && int.Parse(Label10.Text) >= 24)
            {
                Response.Redirect("FinalPage2En.aspx");
            }
       else {
            try {
                connection = new SqlConnection(s);
                connection.Open();
                string update = "update users set email='" + txtemail.Text + "', mob ='" + txtmob.Text + "', note='" + Textnote.Text + "',problem='" + DropDownList1.Text + "' WHERE user_id ='" + Label2.Text + "' ";
                command = new SqlCommand(update, connection);
                command.ExecuteNonQuery();
                connection.Close();
                 }
             catch(Exception e1)
                {
                }
                    if (DropDownList1.Text == "Remove the Constraint")
                            {
                                Response.Redirect("FinalPageEn.aspx");
                            }
                    else if (DropDownList1.Text == "Remove the Constraint + Registration courses")
                            {
                                Response.Redirect("RemoveC.aspx");
                            }
                    else if (DropDownList1.Text == "Registration courses")
                            {
                                Response.Redirect("CRNEN.aspx");
                            }
                    else if (DropDownList1.Text == "Raise the number hours above 18 Hours")
                            {
                                Response.Redirect("FinalPageEn.aspx");
                            }

         }   
    
  }
}