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

public partial class CRNEN : System.Web.UI.Page
{
    string s = (@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\hp\Documents\Visual Studio 2008\WebSites\myWebSite\App_Data\DB.mdf;Integrated Security=True;User Instance=True");
    SqlConnection connection;
    SqlCommand command;
    protected void Page_Load(object sender, EventArgs e)
    {


    }

    //Response.Redirect("FinalPage.aspx");


    protected void Button1_Click1(object sender, EventArgs e)
    {
        try
        {
            connection = new SqlConnection(s);
            string sid = Session["sid"].ToString();

            if (txtcrn.Text.Trim() != "")
            {    //for txtcrn 1 in CRN Course 
                connection.Open();
                string insert = "insert into crntbl(Sid,CRN,CRNnum,semster,check1,check2) VALUES(@stid,@txtcrn ,@txtcrnnum,@DropDownListcrn,@text1,@text2)";
                command = new SqlCommand(insert, connection);
                command.Parameters.AddWithValue("@txtcrn", txtcrn.Text);
                command.Parameters.AddWithValue("@txtcrnnum", txtcrnnum.Text);
                command.Parameters.AddWithValue("@DropDownListcrn", DropDownListcrn.SelectedValue);
                command.Parameters.AddWithValue("@stid", sid);
                command.Parameters.AddWithValue("@text1", CheckBox1.Checked);
                command.Parameters.AddWithValue("@text2", CheckBox2.Checked);
                command.ExecuteNonQuery();

                connection.Close();

            }
            if (txtcrn2.Text.Trim() != "")
            {     //for txtcrn 2 in CRN Course 
                connection.Open();
                string insert = "insert into crntbl(Sid,CRN,CRNnum,semster,check1,check2) VALUES(@stid,@txtcrn ,@txtcrnnum,@DropDownListcrn,@text1,@text2)";
                command = new SqlCommand(insert, connection);
                command.Parameters.AddWithValue("@txtcrn", txtcrn2.Text);
                command.Parameters.AddWithValue("@txtcrnnum", txtcrnnum2.Text);
                command.Parameters.AddWithValue("@DropDownListcrn", DropDownListcrn.SelectedValue);
                command.Parameters.AddWithValue("@stid", sid);
                command.Parameters.AddWithValue("@text1", CheckBox3.Checked);
                command.Parameters.AddWithValue("@text2", CheckBox4.Checked);
                command.ExecuteNonQuery();

                connection.Close();

            }
            if (txtcrn3.Text.Trim() != "")
            {   //for txtcrn 3 in CRN Course 
                connection.Open();
                string insert = "insert into crntbl(Sid,CRN,CRNnum,semster,check1,check2) VALUES(@stid,@txtcrn ,@txtcrnnum,@DropDownListcrn,@text1,@text2)";
                command = new SqlCommand(insert, connection);
                command.Parameters.AddWithValue("@txtcrn", txtcrn3.Text);
                command.Parameters.AddWithValue("@txtcrnnum", txtcrnnum3.Text);
                command.Parameters.AddWithValue("@DropDownListcrn", DropDownListcrn.SelectedValue);
                command.Parameters.AddWithValue("@stid", sid);
                command.Parameters.AddWithValue("@text1", CheckBox5.Checked);
                command.Parameters.AddWithValue("@text2", CheckBox6.Checked);
                command.ExecuteNonQuery();

                connection.Close();

            }
            if (txtcrn4.Text.Trim() != "")
            {
                connection.Open();
                string insert = "insert into crntbl(Sid,CRN,CRNnum,semster,check1,check2) VALUES(@stid,@txtcrn ,@txtcrnnum,@DropDownListcrn,@text1,@text2)";
                command = new SqlCommand(insert, connection);
                command.Parameters.AddWithValue("@txtcrn", txtcrn4.Text);
                command.Parameters.AddWithValue("@txtcrnnum", txtcrnnum4.Text);
                command.Parameters.AddWithValue("@DropDownListcrn", DropDownListcrn.SelectedValue);
                command.Parameters.AddWithValue("@stid", sid);
                command.Parameters.AddWithValue("@text1", CheckBox7.Checked);
                command.Parameters.AddWithValue("@text2", CheckBox8.Checked);
                command.ExecuteNonQuery();

                connection.Close();

            }

            Response.Redirect("FinalPageEn.aspx");
            //Response.Write("Successful Enter");

            connection.Close();
        }
        catch (Exception ex)
        {
            Response.Write("Error :" + ex.ToString());
            connection.Close();
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("MainEn.aspx");
    }
    protected void DropDownListcrn_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void txtcrn_TextChanged(object sender, EventArgs e)
    {

    }
}