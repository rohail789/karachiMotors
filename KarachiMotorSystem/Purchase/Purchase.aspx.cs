using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace KarachiMotorSystem
{
    public partial class Purchase : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Purchase =Convert.ToString(this.GetPurchaseID());
            TbxPurchaseID.Text = Purchase;
            TbxDate.Text = DateTime.Now.ToString("dd-MM-yy");
            TbxPurchasePerson.Text = FlagsVariables.userId;
        }

        private int GetPurchaseID()
        {   int Purchase= 0;
            ConnectionStringClass myConnection = new ConnectionStringClass();
            SqlConnection dbconnection = myConnection.getDatabaseConnection();
            string query = "Select purchaseID from Purchase order by purchaseID desc";
            SqlCommand GetIDCommand = new SqlCommand(query, dbconnection);
            try
            {
                dbconnection.Open();
                int id  = Convert.ToInt32(GetIDCommand.ExecuteScalar()) + 1;
                Purchase = id;
                dbconnection.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return Purchase;
        }

        protected void GoCustomerPageEvent(object sender, EventArgs e)
        {
            Response.Redirect("CustomerMaster.aspx");
        }

        protected void GoStockMasterPageEvent(object sender, EventArgs e)
        {
            Response.Redirect("StockMaster.aspx");
        }

        protected void Save_Event(object sender, EventArgs e)
        {
            string purchaseID = TbxPurchaseID.Text;
            string purchasePerson = TbxPurchasePerson.Text;
            string trade = ddnTrade.Text;
            string date = TbxDate.Text;
            string cnic = TbxCNIC.Text;
            string regNo = TbxRegNo.Text;
            string cName = TbxCustomerName.Text;

            ConnectionStringClass myConnection = new ConnectionStringClass();
            SqlConnection dbConnection = myConnection.getDatabaseConnection();

            string query = "insert into Purchase (purchaseID, purchasePerson, trade, date, cnic, regNo, customerName) values ";
            query += "('" + purchaseID + "', '" + purchasePerson + "', '" + trade + "', '" + date + "', '" + cnic + "', '" + regNo + "', '" + cName + "')";
            SqlCommand myCommand = new SqlCommand(query, dbConnection);
            try
            {
                dbConnection.Open();
                myCommand.ExecuteNonQuery();
                dbConnection.Close();
            }
            catch (Exception)
            {
                string script = "alert(\" Data Not save !\");";
                ScriptManager.RegisterStartupScript(this, GetType(),
                                      "ServerControlScript", script, true);
            }
        }

        protected void GetCustomerDetailByCnic(object sender, EventArgs e)
        {
            string cnic = TbxCNIC.Text;
            this.GetCustomerData("CustomerMaster", "cNIC", cnic);

        }

        private void GetCustomerData(string TableName, string columnName, string desiredValue)
        {
            string cnic = TbxCNIC.Text;
            ConnectionStringClass myConnecion = new ConnectionStringClass();
            SqlConnection dbConnection = myConnecion.getDatabaseConnection();

            string query = "Select customerID, customerName, cellNo1, emailAddress, homeAddress, driverNo from "+ TableName +" Where "+columnName+" = '"+ desiredValue +"'";
            SqlCommand myCommand = new SqlCommand(query, dbConnection);
            SqlDataAdapter myAdaptor = new SqlDataAdapter(myCommand);
            DataTable mytable = new DataTable();
            try
            {
                myAdaptor.Fill(mytable);
                dbConnection.Open();
               var record =  myCommand.ExecuteScalar();
               if (record != null)
               {
                   TbxCustomerID.Text = mytable.Rows[0]["customerID"].ToString();
                   TbxCustomerName.Text = mytable.Rows[0]["customerName"].ToString();
                   TbxCellNo.Text = mytable.Rows[0]["cellNo1"].ToString();
                   TbxEmail.Text = mytable.Rows[0]["emailAddress"].ToString();
                   TbxHomeAddress.Text = mytable.Rows[0]["homeAddress"].ToString();
                   TbxDriverNo.Text = mytable.Rows[0]["driverNo"].ToString();     
               }
               else
               {
                   string script = "alert(\" Customer Not Found !\");";
                   ScriptManager.RegisterStartupScript(this, GetType(),
                                         "ServerControlScript", script, true);
               }
                dbConnection.Close();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void GetStockData(string TableName, string columnName, string desiredValue)
        {
            string regNo = TbxRegNo.Text;
            ConnectionStringClass myConnecion = new ConnectionStringClass();
            SqlConnection dbConnection = myConnecion.getDatabaseConnection();

            string query = "Select StockID, Make, FrameNo, EngineNo, Variant, Other from "+ TableName +" Where "+columnName+" = '"+ desiredValue +"'";
            SqlCommand myCommand = new SqlCommand(query, dbConnection);
            SqlDataAdapter myAdaptor = new SqlDataAdapter(myCommand);
            DataTable mytable = new DataTable();
            try
            {
                myAdaptor.Fill(mytable);
                dbConnection.Open();
               var record =  myCommand.ExecuteScalar();
               if (record != null)
               {
                   TbxStockID.Text = mytable.Rows[0]["StockID"].ToString();
               
                   TbxMake.Text = mytable.Rows[0]["Make"].ToString();
                   TbxFrameNo.Text = mytable.Rows[0]["FrameNo"].ToString();
                   TbxEngineNo.Text = mytable.Rows[0]["EngineNo"].ToString();
                   TbxVariant.Text = mytable.Rows[0]["Variant"].ToString();
                   TbxAmount.Text = mytable.Rows[0]["Other"].ToString();     

               }
               else
               {
                   string script = "alert(\" Stock Not Found !\");";
                   ScriptManager.RegisterStartupScript(this, GetType(),
                                         "ServerControlScript", script, true);
               }
                dbConnection.Close();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        protected void GetStockDetailByRegNo(object sender, EventArgs e)
         {
             string regNo = TbxRegNo.Text;
             this.GetStockData("StockMaster", "RegNo", regNo);
         }

        protected void ClearallTextboxesEvent(object sender, EventArgs e)
        {
            TbxCNIC.Text = "";
            TbxCustomerID.Text = "";
            TbxCustomerName.Text = "";
            TbxCellNo.Text = "";
            TbxEmail.Text = "";
            TbxHomeAddress.Text = "";
            TbxDriverNo.Text = "";
            TbxRegNo.Text = "";
            TbxStockID.Text = "";
            TbxMake.Text = "";
            TbxFrameNo.Text = "";
            TbxEngineNo.Text = "";
            TbxVariant.Text = "";
            TbxAmount.Text = "";
            TbxPurchaseID.Text = "";
            TbxPurchasePerson.Text = "";
            ddnTrade.SelectedValue = "Select";
            TbxDate.Text = "";
            TbxSearch.Text = "";
            string Purchase = Convert.ToString(this.GetPurchaseID());
            TbxPurchaseID.Text = Purchase;
            TbxDate.Text = DateTime.Now.ToString("dd-MM-yy");
            TbxPurchasePerson.Text = FlagsVariables.userId;
        }

        protected void PurchasePageSearchEvent(object sender, EventArgs e)
        {
            string uInput = TbxSearch.Text;
            string cName = "purchaseID";
            string tableName = "Purchase";
            this.SaleRecord(tableName, cName, uInput);
        }

        private void SaleRecord(string tableName, string ColumnName, string UserInput)
        {
            ConnectionStringClass myConnection = new ConnectionStringClass();
            SqlConnection dbConnection =  myConnection.getDatabaseConnection();
            string query = " Select purchaseID, cnic, regNo, purchasePerson, trade, date, customerName from "+tableName +" where "+ColumnName +" = '" +UserInput +"' ";
            SqlCommand mycommand = new SqlCommand(query, dbConnection);
            SqlDataAdapter myAdapter = new SqlDataAdapter(mycommand);
            DataTable myTable = new DataTable();
            try
            {
                dbConnection.Open();
                myAdapter.Fill(myTable);
                var record = mycommand.ExecuteScalar();
                if (record != null )
                {
                 TbxPurchaseID.Text = myTable.Rows[0]["purchaseID"].ToString();
                  TbxPurchasePerson.Text = myTable.Rows[0]["purchasePerson"].ToString();
                  ddnTrade.Text = myTable.Rows[0]["trade"].ToString();
                  TbxDate.Text = myTable.Rows[0]["date"].ToString();
                  TbxCNIC.Text = myTable.Rows[0]["cnic"].ToString();
                  TbxRegNo.Text = myTable.Rows[0]["regNo"].ToString();
                  TbxCustomerName.Text = myTable.Rows[0]["customerName"].ToString();
                    this.GetCustomerRecord("CustomerMaster", "cNIC", TbxCNIC.Text);
                    this.GetStockMasterRecord("StockMaster", "RegNo", TbxRegNo.Text);
                }
                else
                {
                    string script = "alert(\" Sale Data Not Found !\");";
                    ScriptManager.RegisterStartupScript(this, GetType(),
                                          "ServerControlScript", script, true);
                }

            }
            catch (Exception )
            {
                throw;
                
            }
        }

        protected void SearchByCnicEvent(object sender, EventArgs e)
        {
            string uInput = TbxSearch.Text;
            string cName = "cnic";
            string tableName = "Purchase";
            this.SaleRecord(tableName, cName, uInput);
        }

        protected void SearchByRegNoEvent(object sender, EventArgs e)
        {
            string uInput = TbxSearch.Text;
            string cName = "regNo";
            string tableName = "Purchase";
            this.SaleRecord(tableName, cName, uInput);
        }

        private void GetCustomerRecord(string tableName, string ColumnName, string Userinput)
        {
            if (Userinput != "")
            {
                ConnectionStringClass myConn = new ConnectionStringClass();
                SqlConnection dbConnec = myConn.getDatabaseConnection();

                string Query = "Select customerID,emailAddress,cellNo1,homeAddress,driverNo from " + tableName + " Where " + ColumnName + " = '" + Userinput + "'";
                SqlCommand myCommand = new SqlCommand(Query, dbConnec);
                SqlDataAdapter myAdapter = new SqlDataAdapter(myCommand);
                DataTable myTable = new DataTable();
                try
                {
                    dbConnec.Open();

                    myAdapter.Fill(myTable);

                    var record = myCommand.ExecuteReader();
                    dbConnec.Close();
                    if (record != null)
                    {

                        TbxCustomerID.Text = myTable.Rows[0]["customerID"].ToString();
                        TbxEmail.Text = myTable.Rows[0]["emailAddress"].ToString();
                        TbxCellNo.Text = myTable.Rows[0]["cellNo1"].ToString();
                        TbxHomeAddress.Text = myTable.Rows[0]["homeAddress"].ToString();
                        TbxDriverNo.Text = myTable.Rows[0]["driverNo"].ToString();

                    }
                }
                catch (Exception ex)
                {

                    Response.Write(ex);
                }

            }
        }

        private void GetStockMasterRecord(string tableName, string ColumnName, string Userinput)
        {
            if (Userinput != "")
            {
                ConnectionStringClass myConn = new ConnectionStringClass();
                SqlConnection dbConnec = myConn.getDatabaseConnection();

                string Query = "Select Stockid,Make,FrameNo,EngineNo,Variant, Other from " + tableName + " Where " + ColumnName + " = '" + Userinput + "'";
                SqlCommand myCommand = new SqlCommand(Query, dbConnec);
                SqlDataAdapter myAdapter = new SqlDataAdapter(myCommand);
                DataTable myTable = new DataTable();
                try
                {
                    dbConnec.Open();

                    myAdapter.Fill(myTable);

                    var record = myCommand.ExecuteReader();
                    dbConnec.Close();
                    if (record != null)
                    {

                        TbxStockID.Text = myTable.Rows[0]["Stockid"].ToString();
                        TbxMake.Text = myTable.Rows[0]["Make"].ToString();
                        TbxFrameNo.Text = myTable.Rows[0]["FrameNo"].ToString();
                        TbxEngineNo.Text = myTable.Rows[0]["EngineNo"].ToString();
                        TbxVariant.Text = myTable.Rows[0]["Variant"].ToString();
                        TbxAmount.Text = myTable.Rows[0]["Other"].ToString();
                    }
                }
                catch (Exception ex)
                {

                    Response.Write(ex);
                }

            }
        }
 
    }
}