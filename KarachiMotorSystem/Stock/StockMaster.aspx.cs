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
    public partial class StockMaster : System.Web.UI.Page
    {

        private int getstockID()
        {

            int stock = 0;
            ConnectionStringClass myConnection = new ConnectionStringClass();
            SqlConnection sqlConn = myConnection.getDatabaseConnection();

            string q = "select stockid from stockmaster order by stockid desc";
            SqlCommand getIDCommand = new SqlCommand(q, sqlConn);

            try
            {
                sqlConn.Open();
                int id = Convert.ToInt32(getIDCommand.ExecuteScalar()) + 1;
                stock = id;
                sqlConn.Close();

            }
            catch (Exception)
            {

                throw;
            }

            return stock;

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string current = Convert.ToString(this.getstockID());
                TbxStockID.Text = current;
    
            }
            
        }

        protected void BtnSave(object sender, EventArgs e)
        {
            
            string stockId = TbxStockID.Text;
            string reg = TbxRegNo.Text;
            string make = TbxMake.Text;
            string frameNo = TbxFrameNo.Text;
            string engineNo = TbxEngineNo.Text;
            string variant = TbxVariant.Text;
            string modelYear = TbxModelYear.Text;
            string color = TbxColor.Text;

            /// Drop down List 
            string engineType = DdnEnginetype.Text;
            string transmissionType = DdnTransmissionType.Text;
            string powerWindow = DdnPowerWindow.Text;
            string powerLock = DdnPowerLock.Text;
            string ccontrol = DdnCruiseControl.Text;
            string aircondition = DdnAirCondition.Text;
            string radio = DdnRadio.Text;
            string player = DdnPlayer.Text;
            string sunroof = DdnSunRoof.Text;
            string wheelcover = DdnWheelCover.Text;
            string wheelChrome = DdnWheelChrome.Text;
            string wheelAluminium = DdnWheelAluminium.Text;
            string purchaseType = DdnType.Text;
            string others = TbxOther.Text;

            if(reg!="" && frameNo != "" && engineNo != ""){

            ConnectionStringClass myConnection = new ConnectionStringClass();
            SqlConnection sqlC = myConnection.getDatabaseConnection();

           


            String query = "insert into stockmaster (stockid,regno,make,frameno,engineno,variant,modelyear,color,enginetype,transmissiontype,powerwindow,powerlock,cruiseControl,aircondition,radio,player,sunroof,wheelcover,wheelchrome,wheelaluminium,type,other) values ('" + stockId + "', '" + reg + "','" + make + "','" + frameNo + "','" + engineNo + "','" + variant + "','" + modelYear + "',";
            query += "'" + color + "','" + engineType + "','" + transmissionType + "','" + powerWindow + "','" + powerLock + "',";
            query += "'" + ccontrol + "','" + aircondition + "','" + radio + "','" + player + "','" + sunroof + "',";
            query += "'" + wheelcover + "','" + wheelChrome + "','" + wheelAluminium + "','" + purchaseType + "','" + others + "')";

            SqlCommand saveInStockMaster = new SqlCommand(query, sqlC);
            try
            {
                sqlC.Open();
                saveInStockMaster.ExecuteNonQuery();
                sqlC.Close();



            }
            catch (Exception)
            {

                throw;
            }


            }else{

                string script = "alert(\" Must Enter Vehicle Registration No ,Engine No & Frame No !\");";
                ScriptManager.RegisterStartupScript(this, GetType(),
                                      "ServerControlScript", script, true);
            }

        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {

            string stockId = TbxStockID.Text;
            string reg = TbxRegNo.Text;
            string make = TbxMake.Text;
            string frameNo = TbxFrameNo.Text;
            string engineNo = TbxEngineNo.Text;
            string variant = TbxVariant.Text;
            string modelYear = TbxModelYear.Text;
            string color = TbxColor.Text;

            /// Drop down List 
            string engineType = DdnEnginetype.Text;
            string transmissionType = DdnTransmissionType.Text;
            string powerWindow = DdnPowerWindow.Text;
            string powerLock = DdnPowerLock.Text;
            string ccontrol = DdnCruiseControl.Text;
            string aircondition = DdnAirCondition.Text;
            string radio = DdnRadio.Text;
            string player = DdnPlayer.Text;
            string sunroof = DdnSunRoof.Text;
            string wheelcover = DdnWheelCover.Text;
            string wheelChrome = DdnWheelChrome.Text;
            string wheelAluminium = DdnWheelAluminium.Text;
            string purchaseType = DdnType.Text;
            string others = TbxOther.Text;

            if(reg != "" && frameNo != "" && engineNo != ""){
            ConnectionStringClass myConnection = new ConnectionStringClass();
            SqlConnection sqlC = myConnection.getDatabaseConnection();

           


            var myQuery = "UPDATE StockMaster SET  RegNo = '" + reg + "', Make = '" + make + "', FrameNo = '" + frameNo + "', EngineNo = '" + engineNo + "',";
            myQuery = myQuery + " Variant = '" + variant + "', ModelYear = '" + modelYear + "', Color = '" + color + "', EngineType = '" + engineType + "', TransmissionType = '" +transmissionType + "', PowerWindow = '" + powerWindow + "',";
            myQuery = myQuery + "PowerLock = '" + powerLock + "', CruiseControl = '" + ccontrol + "', AirCondition = '" + aircondition + "', Radio ='" + radio + "', Player = '" + player + "',";
            myQuery = myQuery + " Sunroof = '" + sunroof + "', Wheelcover = '" + wheelcover + "', WheelChrome = '" + wheelChrome + "', WheelAluminium = '" + wheelAluminium + "',Type = '" + purchaseType + "',";
            myQuery = myQuery + "Other = '" + others + "' WHERE (StockId = " + stockId + ")";


            SqlCommand saveInStockMaster = new SqlCommand(myQuery, sqlC);
            try
            {
                sqlC.Open();
                saveInStockMaster.ExecuteNonQuery();
                sqlC.Close();



            }
            catch (Exception)
            {

                throw;
            }

            }else{

                string script = "alert(\" Must Enter Vehicle Registration No ,Engine No & Frame No !\");";
                ScriptManager.RegisterStartupScript(this, GetType(),
                                      "ServerControlScript", script, true);
            
            }

        }

        private void getStockRecord(string searchBy, string columnName)
        {

            ConnectionStringClass connectionString = new ConnectionStringClass();
            SqlConnection sc = connectionString.getDatabaseConnection();
            string Query = "Select * from StockMaster where " + columnName + " = " + searchBy +"";
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

                    TbxStockID.Text = myTable.Rows[0]["StockID"].ToString();
                    TbxRegNo.Text = myTable.Rows[0]["RegNo"].ToString();
                    TbxMake.Text = myTable.Rows[0]["Make"].ToString();
                    TbxFrameNo.Text = myTable.Rows[0]["FrameNo"].ToString();
                    TbxEngineNo.Text = myTable.Rows[0]["EngineNo"].ToString();
                    TbxVariant.Text = myTable.Rows[0]["Variant"].ToString();
                    TbxModelYear.Text = myTable.Rows[0]["ModelYear"].ToString();
                    TbxColor.Text = myTable.Rows[0]["Color"].ToString();

                     DdnEnginetype.Text = myTable.Rows[0]["EngineType"].ToString();
                     DdnTransmissionType.Text = myTable.Rows[0]["TransmissionType"].ToString();
                     DdnPowerWindow.Text = myTable.Rows[0]["PowerWindow"].ToString();
                     DdnPowerLock.Text = myTable.Rows[0]["PowerLock"].ToString();
                     DdnCruiseControl.Text = myTable.Rows[0]["CruiseControl"].ToString();
                     DdnAirCondition.Text = myTable.Rows[0]["AirCondition"].ToString();
                     DdnRadio.Text = myTable.Rows[0]["Radio"].ToString();
                     DdnPlayer.Text = myTable.Rows[0]["Player"].ToString();
                     DdnSunRoof.Text = myTable.Rows[0]["SunRoof"].ToString();
                     DdnWheelCover.Text = myTable.Rows[0]["WheelCover"].ToString();
                     DdnWheelChrome.Text = myTable.Rows[0]["WheelChrome"].ToString();
                     DdnwheelAluminum.Text = myTable.Rows[0]["WheelAluminium"].ToString();
                     DdnType.Text = myTable.Rows[0]["type"].ToString();
                     TbxOther.Text = myTable.Rows[0]["Other"].ToString();
                    

                     
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

        protected void BtnSearch_Click(object sender, EventArgs e)
        {
            string stockID = TbxSearchStockID.Text;
            if (stockID == "")
            {

                string regNo = TbxSearchRegistrationNo.Text;
                if (regNo == "")
                {
                    string frameNo = TbxSearchChassisNo.Text;
                    if (frameNo != "")
                    {

                        this.getStockRecord(frameNo, "FrameNo");

                    }
                    else
                    {
                        string script = "alert(\"Please Enter Any Option\");";
                        ScriptManager.RegisterStartupScript(this, GetType(),
                                              "ServerControlScript", script, true);
                    }

                }
                else
                {
                    this.getStockRecord(regNo, "RegNo");

                }


            }
            else
            {

                this.getStockRecord(stockID, "stockID");

            }



        }

        protected void deleteRecord(object sender, EventArgs e)
        {
            if (TbxRegNo.Text != "")
            {
                string deleteStockId = TbxStockID.Text;

                ConnectionStringClass connectionString = new ConnectionStringClass();
                SqlConnection sc = connectionString.getDatabaseConnection();
                string Query = "Delete StockMaster where StockID = '" + deleteStockId + "'";
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
            else 
            {
                string script = "alert(\"Do Not Delete Empty Record!\");";
                ScriptManager.RegisterStartupScript(this, GetType(),
                                      "ServerControlScript", script, true);
                 
            
            }

        }

        private void clearallTextboxes() {



                  TbxStockID.Text            =  ""; 
                  TbxRegNo.Text             =   "";
                  TbxMake.Text               =  "";
                  TbxFrameNo.Text            =  "";
                  TbxEngineNo.Text           =  "";
                  TbxVariant.Text            =  "";
                  TbxModelYear.Text          =  "";
                  TbxColor.Text              =  "";


                  DdnEnginetype.SelectedValue  = "Select";
                  DdnTransmissionType.SelectedValue = "Select";
                  DdnPowerWindow.SelectedValue = "Select";
                  DdnPowerLock.SelectedValue = "Select";
                  DdnCruiseControl.SelectedValue = "Select";
                  DdnAirCondition.SelectedValue = "Select";
                  DdnRadio.SelectedValue = "Select";
                  DdnPlayer.SelectedValue = "Select";
                  DdnSunRoof.SelectedValue = "Select";
                  DdnWheelCover.SelectedValue = "Select";
                  DdnWheelChrome.SelectedValue = "Select";
                  DdnWheelAluminium.SelectedValue = "Select";
                  DdnType.SelectedValue = "Select";
                  TbxOther.Text              =  "";
                  string current = Convert.ToString(this.getstockID());
                  TbxStockID.Text = current;

        }

        protected void clear_pressed(object sender, EventArgs e)
        {
            this.clearallTextboxes();
        }

       

    }
}