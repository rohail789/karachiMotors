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
    public partial class Sale : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string sale = Convert.ToString(this.GetSaleID());
                TbxSaleID.Text = sale;
                TbxDate.Text = DateTime.Now.ToString("dd-MM-yyyy");
                TbxSalePerson.Text = FlagsVariables.userId;
            }



        }

        protected void CNICTextChangeEvent(object sender, EventArgs e)
        {
            string CNIC = TbxCNIC.Text;
            ConnectionStringClass myConnection = new ConnectionStringClass();
            SqlConnection myDataBaseConnection = myConnection.getDatabaseConnection();
            string Query = " Select customerID, customerName, cellNo1, emailaddress, homeAddress, driverNo From CustomerMaster Where cNIC = '"+CNIC+"'";
            SqlCommand myCommand = new SqlCommand(Query, myDataBaseConnection);
            SqlDataAdapter myAdaptor = new SqlDataAdapter(myCommand);
            DataTable datatable = new DataTable();

            try
            {
                myDataBaseConnection.Open();
                var record = myCommand.ExecuteScalar();

                if (record != null)
                {
                    myAdaptor.Fill(datatable);
                    TbxCustomerID.Text = datatable.Rows[0]["customerID"].ToString();
                    TbxCustomerName.Text = datatable.Rows[0]["customerName"].ToString();
                    TbxEmail.Text = datatable.Rows[0]["emailAddress"].ToString();
                    TbxCellNo.Text = datatable.Rows[0]["cellNo1"].ToString();
                    TbxDriverNo.Text = datatable.Rows[0]["driverNo"].ToString();
                    TbxHomeAddress.Text = datatable.Rows[0]["homeAddress"].ToString();
                    myDataBaseConnection.Close();
                }
                else
                {
                    string script = "alert(\"Record Does Not Found  !\");";
                    ScriptManager.RegisterStartupScript(this, GetType(),
                                          "ServerControlScript", script, true);
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        protected void RegistrationTextchangeEvent(object sender, EventArgs e)
        {
            string RegistrationNo = TbxRegNo.Text;
            ConnectionStringClass myConnection = new ConnectionStringClass();
            SqlConnection myDBConnection = myConnection.getDatabaseConnection();
            string Query = "Select StockID, Make, FrameNo, EngineNo, Variant, Other from StockMaster Where RegNo = '" + RegistrationNo + "' ";
            SqlCommand myCommand = new SqlCommand(Query, myDBConnection);
            SqlDataAdapter myAdaptor = new SqlDataAdapter(myCommand);
            DataTable datatable = new DataTable();
            
            try
            {
                myDBConnection.Open();
                var record = myCommand.ExecuteScalar();

                if (record != null)
                {
                    myAdaptor.Fill(datatable);
                    TbxStockID.Text = datatable.Rows[0]["StockID"].ToString();
                    TbxMake.Text = datatable.Rows[0]["Make"].ToString();
                    TbxFrameNo.Text = datatable.Rows[0]["FrameNo"].ToString();
                    TbxEngineNo.Text = datatable.Rows[0]["EngineNo"].ToString();
                    TbxVariant.Text = datatable.Rows[0]["Variant"].ToString();
                    TbxAmount.Text = datatable.Rows[0]["Other"].ToString();
                    myDBConnection.Close();
                }
                else
                {
                    string script = "alert(\"Record Does Not Found  !\");";
                    ScriptManager.RegisterStartupScript(this, GetType(),
                                          "ServerControlScript", script, true);
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private int GetSaleID() 
        {
            int Sale = 0;
            ConnectionStringClass myConnection = new ConnectionStringClass();
            SqlConnection Sqlconnection = myConnection.getDatabaseConnection();
            String Query = "Select saleID from Sale order by saleID desc ";
            SqlCommand GetIDCommand = new SqlCommand(Query, Sqlconnection);
            try
            {
                Sqlconnection.Open();
                int id =Convert.ToInt32(GetIDCommand.ExecuteScalar()) + 1;
                Sale = id;
                Sqlconnection.Close();
            }
            catch (Exception)
            {
                
                throw;
            }
            return Sale;
        }

        protected void BtnOPenCustomerMasterEvent(object sender, EventArgs e)
        {
            Response.Redirect("CustomerMaster.aspx");
        }

        protected void BtnOpenStockMasterEvent(object sender, EventArgs e)
        {
            Response.Redirect("StockMaster.aspx");
        }

        protected void Save_event(object sender, EventArgs e)
        {
            string saleid = TbxSaleID.Text;
            string saleperson = TbxSalePerson.Text;
            string trade = trade_DropDownList.Text;
            string date = TbxDate.Text;
            string cnic = TbxCNIC.Text;
            string regNo = TbxRegNo.Text;
            string cust_name = TbxCustomerName.Text;
            Int64 sal_amount =Convert.ToInt64( TbxSaleAmount.Text);
            
            if(sal_amount != 0 && trade != ""){

            ConnectionStringClass conn = new ConnectionStringClass();
            SqlConnection dataConn = conn.getDatabaseConnection();

            string query = "insert into sale (saleID, salePerson, trade, date, saleAmount, CNIC, RegNo,customerName) values";
            query += "('" + saleid + "','" + saleperson + "','" + trade + "','" + date + "','" + sal_amount + "','" + cnic + "','" + regNo + "','" + cust_name + "')";
            SqlCommand myCommand = new SqlCommand(query, dataConn);
            try
            {
                dataConn.Open();
                myCommand.ExecuteNonQuery();
                dataConn.Close();
            }
            catch (Exception)
            {
                string script = "alert(\" Data Not save !\");";
                ScriptManager.RegisterStartupScript(this, GetType(),
                                      "ServerControlScript", script, true);
            }
            }

        }

        protected void SalePageSearchEvent(object sender, EventArgs e)
        {
            string UInput = TbxSearch.Text;
            string CName = "saleID";
            string table = "Sale";
            this.GetSaleRecord(table,CName, UInput);
        }

        private void GetSaleRecord(string tableName,string ColumnName, string Userinput)
        {
            if (Userinput != "")
            {
                ConnectionStringClass myConn = new ConnectionStringClass();
               SqlConnection dbConnec = myConn.getDatabaseConnection();

               string Query = "Select * from "+tableName+" Where "+ ColumnName +" = '"+ Userinput +"'";
               SqlCommand myCommand = new SqlCommand(Query, dbConnec);
               SqlDataAdapter myAdapter = new SqlDataAdapter(myCommand);
               DataTable myTable = new DataTable();
               try
               {
                   dbConnec.Open();

                   myAdapter.Fill(myTable);
                  
                   var record = myCommand.ExecuteScalar();
                   dbConnec.Close();
                   if (record != null)
                   {

                       TbxSaleID.Text = myTable.Rows[0]["saleID"].ToString();
                       TbxSalePerson.Text = myTable.Rows[0]["SalePerson"].ToString();
                       trade_DropDownList.Text = myTable.Rows[0]["trade"].ToString();
                       TbxDate.Text = myTable.Rows[0]["date"].ToString();
                       TbxSaleAmount.Text = myTable.Rows[0]["saleAmount"].ToString();
                       TbxCNIC.Text = myTable.Rows[0]["CNIC"].ToString();
                       TbxRegNo.Text = myTable.Rows[0]["RegNo"].ToString();
                       TbxCustomerName.Text = myTable.Rows[0]["customerName"].ToString();
                       this.GetCustomerRecord("CustomerMaster", "cNIC", TbxCNIC.Text);
                       this.GetStockMasterRecord("StockMaster", "RegNo", TbxRegNo.Text);

                   }
               }
               catch (Exception ex )
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

        protected void SearchByCustomerCNICEvent(object sender, EventArgs e)
        {
            string UInput = TbxSearch.Text;
            string CName = "CNIC";
            string table = "Sale";
            this.GetSaleRecord(table,CName, UInput);
        }

        protected void SearchByVehicleStockNoEvent(object sender, EventArgs e)
        {
            string UInput = TbxSearch.Text;
            string CName = "RegNo";
            string table = "Sale";
            this.GetSaleRecord(table,CName, UInput);

        }

        protected void ClearButtonEvent(object sender, EventArgs e)
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
            TbxSaleID.Text = "";
            trade_DropDownList.SelectedValue = "Select";
            TbxSaleAmount.Text = "";
            TbxSearch.Text = "";
            string current = Convert.ToString(this.GetSaleID());
            TbxSaleID.Text = current;
        }
    }
    }
