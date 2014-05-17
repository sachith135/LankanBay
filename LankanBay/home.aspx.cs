using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DOMAIN;


namespace LankanBay
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString.Count > 0 && Request.QueryString[0] != null)
                {
                    LankanBay.masterpages.sitemaster master = (LankanBay.masterpages.sitemaster)this.Master;
                    master.MessageBox(CommonParameterNames.MessageBoxType.InformationMessage, CommonUserMessages.InformationMessages.nodailyDeails); 
                }
            }
        }
              
    }
}