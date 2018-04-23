using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KarachiMotorSystem
{
    public partial class MainForm1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CustomerMaster(object sender, EventArgs e)
        {
            Response.Redirect("CustomerMaster.aspx"); 
        }

        protected void Home(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }

        protected void StockMasterClick(object sender, EventArgs e)
        {
            Response.Redirect("StockMaster.aspx");
        }

        protected void Sale(object sender, EventArgs e)
        {
            Response.Redirect("Sale.aspx");
        }

        protected void BtnPurchase_Click(object sender, EventArgs e)
        {
            Response.Redirect("Purchase.aspx");
        }

       
    }
}