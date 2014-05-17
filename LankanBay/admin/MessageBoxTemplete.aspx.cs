using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DOMAIN;

namespace LankanBay.admin
{
    public partial class MessageBoxTemplete : System.Web.UI.Page
    {
        string msgType = "";
        string msg = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            msgType = Request.QueryString["msgtype"].ToString();
            msg = Request.QueryString["msg"].ToString();


            lblMessage.Text = msg;

            if (msgType == CommonParameterNames.MessageBoxType.SuccessMessage)
            {
                Image1.ImageUrl = "~/images/succsses.png";
            }
            else if (msgType == CommonParameterNames.MessageBoxType.ErrorMessage)
            {
                Image1.ImageUrl = "~/images/error.png";
            }
            else if (msgType == CommonParameterNames.MessageBoxType.InformationMessage)
            {
                Image1.ImageUrl = "~/images/information.png";
            }
            else if (msgType == CommonParameterNames.MessageBoxType.QuestionMessage)
            {
                Image1.ImageUrl = "~/images/question.png";
            }
            else if (msgType == CommonParameterNames.MessageBoxType.WarnningMessage)
            {
                Image1.ImageUrl = "~/images/warnning.png";
            }
            else
            {
                Image1.ImageUrl = "~/images/warnning.png";
            }

        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(this, GetType(), "close", "CloseModal();", true);
        }
    }
}