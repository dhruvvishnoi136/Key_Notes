using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Key_Notes
{
    public partial class Form1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=I:\VISUAL_STUDIO\Key_Notes\App_Data\Privateserver.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        { 
           if (Login_Username.Text == "" || Login_Password.Text == "")
           {
               Label2.Text = "Filled Can't Be Empty!!";
               Label2.Visible = true;
              
           }
            else
            {
                Boolean isValidUser = false; 
                con.Open();
                SqlCommand command;
                SqlDataReader dataReader;
                String sql = "Select Id from id where Username = '" + Login_Username.Text + "' and Password = '" + Login_Password.Text + "'";
                command = new SqlCommand(sql, con);

                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    if ((int)dataReader.GetValue(0) > 0)
                    {
                        Session["id"] = dataReader.GetValue(0);
                        isValidUser = true;
                    }
                }
                if (isValidUser == true)
                {
                    Session["Username"] = Login_Username.Text;
                    dataReader.Close();
                    command.Dispose();
                    con.Close();
                    Server.Transfer("afterlogin.aspx");
                }
                else
                {
                    Label3.Text = "Incorrect Username or Password";
                    Label3.Visible = true;
                    
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if(Signup_repass.Text != Signup_Password.Text)
            {
                Label3.Visible = true;
            }
            else if(Signup_Username.Text == "" || Signup_Password.Text == "")
            {
                Label3.Text = "Filled Can't Be Empty!!";
                Label3.Visible = true;
            }

            con.Open();
            Boolean usernameTaken = true;
            SqlDataReader dataReader;
            SqlCommand command;
            
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "Select Id from id where Username = '" + Signup_Username.Text + "'";
            command = new SqlCommand(sql, con);
            dataReader = command.ExecuteReader();
            if (!dataReader.Read())
            {
                usernameTaken = false;
            }
            else
            {
                Label3.Text = "Username is already taken";
                Label3.Visible = true;
            }
            dataReader.Close();
            if (!usernameTaken)
            {
                sql = "insert into id (Username, Password) values('" + Signup_Username.Text + "', '" + Signup_Password.Text + "')";
                command = new SqlCommand(sql, con);
                adapter.InsertCommand = new SqlCommand(sql, con);
                adapter.InsertCommand.ExecuteNonQuery();
                Label3.Text = "SignUp Successfull....Now You Can Login";
                Label3.Visible = true;
            }
            command.Dispose();
            con.Close();
        }

    }
}