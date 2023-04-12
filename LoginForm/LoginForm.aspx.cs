using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace LoginForm
{
    public partial class LoginForm : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\User.mdf;Integrated Security = True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataReader dr;
            String str = "Select * from Login where Name='" + Name.Text + "' and Password='" + Password.Text + "'";
            SqlCommand cmd = new SqlCommand(str, con);
            dr = cmd.ExecuteReader();
            if(dr.HasRows)
            {
                LblMsg.Text = "Login Successful";
            }
            else
            {
                LblMsg.Text = "Invalid User";
            }
        }
    }
}