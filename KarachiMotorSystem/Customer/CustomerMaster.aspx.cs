using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KarachiMotorSystem
{
    public partial class CustomerMaster : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string current = Convert.ToString(this.getCustomerID());
                TbxCustomerId.Text = current;
            }
        }

        protected void BtnSave(object sender, EventArgs e)
        {
            string customer =  TbxCustomerId.Text;
            string customerName = TbxCustomerName.Text;
            string fatherName = TbxFatherName.Text;
            string dOB = TbxDOB.Text;
            string cNIC = TbxCNIC.Text;
            string hPASales = TbxHPASales.Text;
            string residentialNo = TbxResidentialNo.Text;
            string officeNo = TbxOfficeNo.Text;
            string cellNo1 = TbxCellNo1.Text;
         
            string driverNo = TbxDriverNo.Text;
            string emailAddress = TbxEmailAddress.Text;
            string homeAddress = TbxHomeAddress.Text;
            string nTNNo = TbxNTNNo.Text;
            string customerType = DdnListCustomerType.Text;
            string recoveryBy = TbxRecdoveryBy.Text;
            string insertedBy = TbxInsertedBy.Text;
            string UpdatedBy = TbxUpdatedBy.Text;
            string DOB = TbxDOB.Text;
            ConnectionStringClass myConnection = new ConnectionStringClass();
            SqlConnection sqlC = myConnection.getDatabaseConnection();
            string insertQuery = "insert into CustomerMaster (customerID,CustomerName, fatherName, cNIC, hPASales, residentialNo, officeNo, cellNo1, driverNo, emailAddress, homeAddress, nTNNo, customerType, recoveryBy, insertedBy, UpdatedBy, DOB) Values (  '"+customer+"','" + customerName + "', '" + fatherName + "', '" + cNIC + "', '" + hPASales + "', '" + residentialNo + "', '" + officeNo + "', '" + cellNo1 + "', '" + driverNo + "', '" + emailAddress + "','" + homeAddress + "', '" + nTNNo + "', '" + customerType + "', '" + insertedBy + "', '" + UpdatedBy + "' ,'"
            +UpdatedBy+"' , '"+ DOB +"')";
            SqlCommand mycommand = new SqlCommand(insertQuery, sqlC);
            try
            {
                sqlC.Open();
                var a = mycommand.ExecuteNonQuery();
              //  Response.Write(a);
                sqlC.Close();

            }
            catch (Exception ex) 
            {
                string script = "alert(\"Data Failed to Save!\");";
                ScriptManager.RegisterStartupScript(this, GetType(),
                                      "ServerControlScript", script, true);
            }            

        }

        protected void BtnUpdate(object sender, EventArgs e)
        {
            string customerId =        TbxCustomerId.Text;
            string customerName =    TbxCustomerName.Text;
            string fatherName =      TbxFatherName.Text;
            string dOB =             TbxDOB.Text;
            string cNIC =            TbxCNIC.Text;
            string hPASales =        TbxHPASales.Text;
            string residentialNo =   TbxResidentialNo.Text;
            string officeNo =        TbxOfficeNo.Text;
            string cellNo1 =         TbxCellNo1.Text;
   
            string driverNo =        TbxDriverNo.Text;
            string emailAddress =    TbxEmailAddress.Text;
            string homeAddress =     TbxHomeAddress.Text;
            string nTNNo =           TbxNTNNo.Text;
            string customerType = DdnListCustomerType.Text;
            string recoveryBy = TbxRecdoveryBy.Text;
            string insertedBy = TbxInsertedBy.Text;
            string UpdatedBy = TbxUpdatedBy.Text;
            string DOB = TbxDOB.Text;
            ConnectionStringClass myConnection = new ConnectionStringClass();
            SqlConnection sqlC = myConnection.getDatabaseConnection();
            string insertQuery = "Update CustomerMaster SET customerID = '" + customerId + "' , CustomerName = '" + customerName + "', fatherName = '" + fatherName + "' , cNIC = '" + cNIC + "', hPASales = '" + hPASales + "', residentialNo =  '" + residentialNo + "', officeNo = '" + officeNo + "' , cellNo1 = '" + cellNo1 + "', driverNo =  '" + driverNo + "' , emailAddress = '" + emailAddress + "', homeAddress = '" + homeAddress + "' , nTNNo = '" + nTNNo + "' , customerType = '" + customerType + "' , recoveryBy = '"+recoveryBy +"', insertedBy = '" + insertedBy + "' , UpdatedBy =  '" + UpdatedBy + "', DOB = '"+DOB +"' Where ( customerID = "+customerId+")";
            SqlCommand mycommand = new SqlCommand(insertQuery, sqlC);
            try
            {
                sqlC.Open();
                mycommand.ExecuteNonQuery();
                sqlC.Close();

            }
            catch (Exception ex)
            {
                string script = "alert(\"Record Does Not Update Successfully!\");";
                ScriptManager.RegisterStartupScript(this, GetType(),
                                      "ServerControlScript", script, true);
            }            
        }

        protected void BtnSearch_Click(object sender, EventArgs e)
        {
            string searchCustomerID = TbxSearchCustomerID.Text;
            ConnectionStringClass connectionString = new ConnectionStringClass();
            SqlConnection sc = connectionString.getDatabaseConnection();
            string Query = "Select * from CustomerMaster where customerID = '"+searchCustomerID+"'";
            SqlCommand updateCommand = new SqlCommand(Query, sc);
            SqlDataAdapter myadapter = new SqlDataAdapter(updateCommand);
            DataTable myTable = new DataTable();
            try
            {
                sc.Open();
                var a = updateCommand.ExecuteScalar();

                if (a != null)
                {
                    myadapter.Fill(myTable);

                    TbxCustomerId.Text = myTable.Rows[0]["customerID"].ToString();
                    TbxCustomerName.Text = myTable.Rows[0]["customerName"].ToString();
                    TbxFatherName.Text = myTable.Rows[0]["fatherName"].ToString();
                    TbxCNIC.Text = myTable.Rows[0]["cNIC"].ToString();
                    TbxHPASales.Text = myTable.Rows[0]["hPASales"].ToString();
                    TbxResidentialNo.Text = myTable.Rows[0]["residentialNo"].ToString();
                    TbxOfficeNo.Text = myTable.Rows[0]["officeNo"].ToString();
                    TbxCellNo1.Text = myTable.Rows[0]["cellNo1"].ToString();
                
                    TbxDriverNo.Text = myTable.Rows[0]["driverNo"].ToString();
                    TbxEmailAddress.Text = myTable.Rows[0]["emailAddress"].ToString();
                    TbxHomeAddress.Text = myTable.Rows[0]["homeAddress"].ToString();
                    TbxNTNNo.Text = myTable.Rows[0]["nTNNo"].ToString();
                    TbxRecdoveryBy.Text = myTable.Rows[0]["recoveryBy"].ToString();
                    TbxUpdatedBy.Text = myTable.Rows[0]["UpdatedBy"].ToString();
                    TbxInsertedBy.Text = myTable.Rows[0]["insertedBy"].ToString();
                    TbxDOB.Text = myTable.Rows[0]["DOB"].ToString();
                }
                else
                {

                    string script = "alert(\"Record Does Not Exist !\");";
                    ScriptManager.RegisterStartupScript(this, GetType(),
                                          "ServerControlScript", script, true);
                }
             
               sc.Close();
            }
            catch (Exception)
            {
                
                throw;
            }

           
        }

        protected void BtnDelete(object sender, EventArgs e)
        {

            string deleteCustomerID = TbxCustomerId.Text;
            ConnectionStringClass connectionString = new ConnectionStringClass();
            SqlConnection sc = connectionString.getDatabaseConnection();
            string Query = "Delete CustomerMaster where customerID = '" + deleteCustomerID + "'";
            SqlCommand deleteCommand = new SqlCommand(Query, sc);
            try
            {
                sc.Open();
                deleteCommand.ExecuteNonQuery();
                sc.Close();
            }
            catch (Exception ex)
            {

                string script = "alert(\"Does Not Delete Sucessfully!\");";
                ScriptManager.RegisterStartupScript(this, GetType(),
                                      "ServerControlScript", script, true);
            }
        }

        protected void BtnClear(object sender, EventArgs e)
        {
            TbxCustomerId.Text =    "";
            TbxCustomerName.Text =  "";
            TbxFatherName.Text =    "";
            TbxCNIC.Text =          "";
            TbxHPASales.Text =      "";
            TbxResidentialNo.Text = "";
            TbxOfficeNo.Text =      "";
            TbxCellNo1.Text =       "";
                                    
            TbxDriverNo.Text =      "";
            TbxEmailAddress.Text =  "";
            TbxHomeAddress.Text =   "";
            TbxNTNNo.Text =         "";
            TbxRecdoveryBy.Text =   "";
            TbxUpdatedBy.Text =     "";
            TbxInsertedBy.Text =    "";
            TbxDOB.Text =           "";
            TbxSearchCustomerID.Text = "";
            TbxSearchCName.Text = "";
            TbxSearchCNIC.Text = "";
            TbxSearchCellNo.Text = "";
            string current = Convert.ToString(this.getCustomerID());
            TbxCustomerId.Text = current;
        }

        protected void BtnBack(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }

        private int getCustomerID() {
            int customer = 0;
            ConnectionStringClass myConnection = new ConnectionStringClass();
            SqlConnection sqlConn = myConnection.getDatabaseConnection();

            string q = " select customerID from customerMaster order by customerID desc ";
            SqlCommand getIDCommand = new SqlCommand(q, sqlConn);
            try
            {
                sqlConn.Open();
                int id = Convert.ToInt32(getIDCommand.ExecuteScalar()) + 1;
                customer = id;
                sqlConn.Close();
            }
            catch (Exception)
            {
                
                throw;
            }

            return customer;
        }
    }
}