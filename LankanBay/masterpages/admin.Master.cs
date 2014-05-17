using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DOMAIN;
using SERVICE;
using Telerik.Web.UI;
using System.Data;

namespace LankanBay.masterpages
{
    public partial class admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Timeout = 30;
            //Session[CommonParameterNames.LoggedUserDetails.userId] = "1";
            //Session[CommonParameterNames.LoggedUserDetails.username] = "Sachith";

            if (Session[CommonParameterNames.LoggedUserDetails.userId].ToString().Length != 0)
            {
                lnkBtnLogInOrLogOut.Text = "Hi, " + Session[CommonParameterNames.LoggedUserDetails.username].ToString() + " (Logout)";
            }
            else
            {
                Response.Redirect("../" + CommonParameterNames.PageURLs.LoginPage);
            }
        }

        //protected void CmdInsert_Click(object sender, EventArgs e)
        //{
        //    Type contentType = this.Page.GetType();
        //    System.Reflection.MethodInfo mi = contentType.GetMethod("MessageBox");
        //    if (mi == null) return;
        //    mi.Invoke(this.Page, null);
        //}

        public void MessageBox(string messegeBoxType, string messege)
        {
            RadWindow1.Width = 532;
            RadWindow1.Height = 95;
            RadWindow1.NavigateUrl = "~/admin/MessageBoxTemplete.aspx?msgtype=" + messegeBoxType + "&msg=" + messege;
            RadWindow1.VisibleOnPageLoad = true;
            RadWindow1.VisibleTitlebar = false;
            RadWindow1.VisibleStatusbar = false;
            RadWindow1.Modal = true;
            RadWindow1.AutoSize = false;
            RadWindowManager1.EnableViewState = false;
            RadWindowManager1.Windows.Add(RadWindow1);

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            btnInsert.Enabled = true;
            btnUpdate.Enabled = false;
            btnClear.Enabled = true;
            btnPrint.Enabled = true;

            Type contentType = this.Page.GetType();
            System.Reflection.MethodInfo mi = contentType.GetMethod("Insert");
            if (mi == null) return;
            mi.Invoke(this.Page, null);
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Type contentType = this.Page.GetType();
            System.Reflection.MethodInfo mi = contentType.GetMethod("Update");
            if (mi == null) return;
            mi.Invoke(this.Page, null);

            btnInsert.Enabled = true;
            btnUpdate.Enabled = false;
            btnClear.Enabled = true;
            btnPrint.Enabled = true;
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            Object[] para = new Object[1];
            para[0] = true;

            Type contentType = this.Page.GetType();
            System.Reflection.MethodInfo mi = contentType.GetMethod("ResetInputs");

            if (mi == null) return;
            mi.Invoke(this.Page, para);

            btnInsert.Enabled = true;
            btnUpdate.Enabled = false;
            btnClear.Enabled = true;
            btnPrint.Enabled = true;
        }

        protected void btnPrint_Click(object sender, EventArgs e)
        {
            Type contentType = this.Page.GetType();
            System.Reflection.MethodInfo mi = contentType.GetMethod("Print");
            if (mi == null) return;
            mi.Invoke(this.Page, null);

            btnInsert.Enabled = true;
            btnUpdate.Enabled = false;
            btnClear.Enabled = true;
            btnPrint.Enabled = true;
        }

        public void Update()
        {
            btnInsert.Enabled = false;
            btnUpdate.Enabled = true;
            btnClear.Enabled = true;
            btnPrint.Enabled = false;
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("../" + CommonParameterNames.PageURLs.LoginPage);
        }
    }
}
