using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace KarachiMotorSystem
{
    public partial class SignUpFoam : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

           
        }
        protected void CreateAccount(object sender, EventArgs e)

        {
            string name = TbxFirstName.Text;
            string surname = TxtSurname.Text;
            string password = Txtpassword.Text;
            string email = TxtEmailAddress.Text;
            string homeAddress = TxthomeAddress.Text;
            string cellNo = Txtphoneno.Text;
            string dateOfBirth = DropDownDay.Text +"/"+ DropDownMonth.Text +"/"+ DropDownYear.Text;
            string gender = RdBtngender.Text;


            ConnectionStringClass myConnectionString = new ConnectionStringClass();
            SqlConnection sqlC = myConnectionString.getDatabaseConnection();
            String insertQuery = "insert into UserAccountDetails (firstName,surName,Password,emailAddress,homeAddress,CellNumber,dob,gender) Values ('"+name+"','"+surname+"','"+password+"','"+email+"','"+homeAddress+"','"+cellNo+"','"+dateOfBirth+"','"+gender+"')";
            SqlCommand mycommand = new SqlCommand(insertQuery, sqlC);
            try
            {
                sqlC.Open();
                mycommand.ExecuteNonQuery();
                sqlC.Close();
                FlagsVariables.accountCreate = true;
                Response.Redirect("LoginPage.aspx");
               
               

            }
            catch (Exception ex)
            {
                Response.Write("data not save OK");
                Response.Write(ex);
            }

        }

        protected void mailRadioButton_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ShowHideclickEvent(object sender, EventArgs e)
        {    
            if (this.BtnSearchHide.Text == "Show")
            {
                this.BtnSearchHide.Text = "Hide";
                string b = Txtpassword.Text;
                string c = TxtConformpassword.Text;
                Txtpassword.TextMode = TextBoxMode.SingleLine;
                TxtConformpassword.TextMode = TextBoxMode.SingleLine;
               
            }
            else
            { 
                this.BtnSearchHide.Text = "Show";
                string d = Txtpassword.Text;
                string f = TxtConformpassword.Text;
                Txtpassword.Attributes["type"] = "password";
                TxtConformpassword.Attributes["type"] = "password";
                Txtpassword.Text = d;
                TxtConformpassword.Text = f;
            }
        }
    }
}