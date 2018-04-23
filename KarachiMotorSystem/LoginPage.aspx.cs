using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;

namespace KarachiMotorSystem
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (FlagsVariables.accountCreate)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Insert is successfull')", true);
                FlagsVariables.accountCreate = false;
            }
        }
        protected void SignUp(object sender, EventArgs e)
        {
            Response.Redirect("SignUpFoam.aspx");
        }

        protected void Login(object sender, EventArgs e)
        {

            string email = TbxEmail.Text;
            string pass = TbxPass.Text;

            ConnectionStringClass connectionString = new ConnectionStringClass();

            SqlConnection sc = connectionString.getDatabaseConnection();
            string Query = "Select * from UserAccountDetails where emailAddress = '"+ email +"' and Password = '"+ pass +"'";
            SqlCommand loginCommand = new SqlCommand(Query, sc);
            try
            {
                sc.Open();
                var count = loginCommand.ExecuteScalar();
                if (count != null)
                {
                    FlagsVariables.userId = email;
                    Response.Redirect("HomePage.aspx");

                }
                else
                {

                    Response.Write("Karachi Motor does not recognize that credentails");
                }



            }
            catch (Exception ex )
            {

                Response.Write("Karachi Motor does not recognize that credentails");
                Response.Write(ex);
            }
            
            
            
            
            
        }

    }
}