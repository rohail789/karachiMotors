using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace KarachiMotorSystem
{
    public partial class ForgetPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //TbxConformPassword.Enabled = false;
            //TbxNewPassword.Enabled = false;
            //BtnSumit.Enabled = false;
        }

        protected void btncheck(object sender, EventArgs e)
        {
            string email = TbxEmail.Text;
            string cellNo = TbxCellNo.Text;

            if (email != "" && cellNo != "")
            {

                ConnectionStringClass connectionString = new ConnectionStringClass();
                SqlConnection sc = connectionString.getDatabaseConnection();
                string Query = "Select * from UserAccountDetails where emailAddress = '" + email + "' and CellNumber = '" + cellNo + "'";
                SqlCommand loginCommand = new SqlCommand(Query, sc);
                try
                {
                    sc.Open();
                    var count = loginCommand.ExecuteScalar();
                    Response.Write(count);
                    if (count != null)
                    {
                        //TbxConformPassword.Enabled = true;
                        //TbxNewPassword.Enabled = true;
                        //BtnSumit.Enabled = true;

                    }
                    else
                    {

                        Response.Write("Karachi Motor does not recognize that credentails");
                    }



                }
                catch (Exception ex)
                {

                    Response.Write("Karachi Motor does not recognize that credentails");
                    Response.Write(ex);
                }
            
            
            }

        }

        protected void btnSubmit(object sender, EventArgs e)
        {
            string newPass = TbxNewPassword.Text;
            string conformPass = TbxConformPassword.Text;
            string email = TbxEmail.Text;
            string cellNo = TbxCellNo.Text;
            if (newPass != "" && conformPass != "")
            {
                ConnectionStringClass connectionString = new ConnectionStringClass();
                SqlConnection sc = connectionString.getDatabaseConnection();
                string Query = "Update UserAccountDetails Set Password = '"+newPass+"' where emailAddress = '" + email + "' and CellNumber = '" + cellNo + "'";
                SqlCommand updateCommand = new SqlCommand(Query, sc);
                try
                {
                    sc.Open();
                    updateCommand.ExecuteNonQuery();
                    sc.Close();
                    Response.Redirect("LoginPage.aspx");
                }
                catch (Exception ex)
                {
                    Response.Write(ex);          
                }
            }
        }
    }
}