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
    public partial class sitemaster : System.Web.UI.MasterPage
    {
        UserDetails userDetails = new UserDetails();
        UserDetailsService userDetailsService = new UserDetailsService();

        NotificationDetailsService notificationDetailsService = new NotificationDetailsService();
        NotificationsDetails notificationsDetails = new NotificationsDetails();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {

                    if (!string.IsNullOrEmpty(Session[CommonParameterNames.LoggedUserDetails.userId] as string))
                    {
                        lnkBtnLogInOrLogOut.Text = "Hi, " + Session[CommonParameterNames.LoggedUserDetails.username].ToString() + " (Logout)";

                    }

                    if (System.Web.HttpContext.Current.Session["dtCart"] != null)
                    {
                        btnYourCart.Text = "Your Cart (" + ((DataTable)Session["dtCart"]).Rows.Count + ")";
                    }
                }

                if (!string.IsNullOrEmpty(Session[CommonParameterNames.LoggedUserDetails.userId] as string))
                    {
                        notificationsDetails.ReceiverBSPId = Convert.ToInt32(Session[CommonParameterNames.LoggedUserDetails.bspId]);
                        lnkBtnNotification.Text = "Notifications ("+notificationDetailsService.SelectNotificationTypes(notificationsDetails).Rows[0]["AllUnread"].ToString()+")";
                    }
               
            }
            catch (Exception)
            {
                Response.Redirect(CommonParameterNames.PageURLs.Default);
            }


        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect(CommonParameterNames.PageURLs.LoginPage);
        }

        public void MessageBox(string messegeBoxType, string messege)
        {
            if (CommonParameterNames.MessageBoxType.MyCart == messegeBoxType)
            {
                RadWindow1.Width = 530;
                RadWindow1.Height = 390;
                RadWindow1.NavigateUrl = messege;
                RadWindow1.VisibleOnPageLoad = true;
                RadWindow1.VisibleTitlebar = false;
                RadWindow1.VisibleStatusbar = false;
                RadWindow1.Modal = true;
                RadWindow1.AutoSize = false;

                RadWindow1.Animation = Telerik.Web.UI.WindowAnimation.Fade;
                RadWindow1.AnimationDuration = 2000;
               
                RadWindowManager1.EnableViewState = false;
                RadWindowManager1.Windows.Add(RadWindow1);
            }
            if (CommonParameterNames.MessageBoxType.CusSupport == messegeBoxType)
            {
                RadWindow1.Width = 650;
                RadWindow1.Height = 500;
                RadWindow1.NavigateUrl = messege;
                RadWindow1.VisibleOnPageLoad = true;
                RadWindow1.VisibleTitlebar = false;
                RadWindow1.VisibleStatusbar = false;
                RadWindow1.Modal = true;
                RadWindow1.AutoSize = false;

                RadWindow1.Animation = Telerik.Web.UI.WindowAnimation.Fade;
                RadWindow1.AnimationDuration = 2000;
               

                RadWindowManager1.EnableViewState = false;
                RadWindowManager1.Windows.Add(RadWindow1);
            }
            else
            {
                RadWindow1.Width = 532;
                RadWindow1.Height = 95;
                RadWindow1.NavigateUrl = "~/admin/MessageBoxTemplete.aspx?msgtype=" + messegeBoxType + "&msg=" + messege;
                RadWindow1.VisibleOnPageLoad = true;
                RadWindow1.VisibleTitlebar = false;
                RadWindow1.VisibleStatusbar = false;
                RadWindow1.Modal = true;
                RadWindow1.AutoSize = false;

                RadWindow1.Animation = Telerik.Web.UI.WindowAnimation.Fade;
                RadWindow1.AnimationDuration = 2000;

                RadWindowManager1.EnableViewState = false;
                RadWindowManager1.Windows.Add(RadWindow1);
            }

        }

        protected void btnYourCart_Click(object sender, EventArgs e)
        {
            if (System.Web.HttpContext.Current.Session["dtCart"] != null)
            {
                MessageBox(CommonParameterNames.MessageBoxType.MyCart, "../yourcart.aspx");
            }
            else
            {
                MessageBox(CommonParameterNames.MessageBoxType.InformationMessage, CommonUserMessages.InformationMessages.noItemsInCart);
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            Response.Redirect(CommonParameterNames.PageURLs.ItemSearch + txtSearch.Text.Trim()+"&dailydeals=0");
        }

        protected void RadAjaxManager1_AjaxRequest(object sender, Telerik.Web.UI.AjaxRequestEventArgs e)
        {

        }

        protected void RadAjaxManager1_AjaxRequest1(object sender, Telerik.Web.UI.AjaxRequestEventArgs e)
        {
            if (e.Argument == "Rebind")
            {
                btnYourCart.Text = "Your Cart (" + ((DataTable)Session["dtCart"]).Rows.Count + ")";
            }
        }

        protected void lnkBtnMySrilankanBay_Click(object sender, EventArgs e)
        {
            if (System.Web.HttpContext.Current.Session[CommonParameterNames.LoggedUserDetails.bspId] != null)
            {
                if (Session[CommonParameterNames.LoggedUserDetails.bspShortCode].ToString() == "S")
                {
                    Response.Redirect(CommonParameterNames.PageURLs.BspSellerProfile + Session[CommonParameterNames.LoggedUserDetails.bspId].ToString()+"&next=");
                }
                else if (Session[CommonParameterNames.LoggedUserDetails.bspShortCode].ToString() == "C")
                {
                    Response.Redirect(CommonParameterNames.PageURLs.BspCustomerProfile + Session[CommonParameterNames.LoggedUserDetails.bspId].ToString() + "&next=");
                }
            }
            else
            {
                Session["FromMySrilankanBay"] = true;
                Response.Redirect(CommonParameterNames.PageURLs.LoginPage);
            }
        }

        protected void lnkBtnNotification_Click(object sender, EventArgs e)
        {
            if (System.Web.HttpContext.Current.Session[CommonParameterNames.LoggedUserDetails.bspId] != null)
            {
                if (Session[CommonParameterNames.LoggedUserDetails.bspShortCode].ToString() == "S")
                {
                    Response.Redirect(CommonParameterNames.PageURLs.BspSellerProfile + Session[CommonParameterNames.LoggedUserDetails.bspId].ToString() + "&next=");
                }
                else if (Session[CommonParameterNames.LoggedUserDetails.bspShortCode].ToString() == "C")
                {
                    Response.Redirect(CommonParameterNames.PageURLs.BspCustomerProfile + Session[CommonParameterNames.LoggedUserDetails.bspId].ToString() + "&next=");
                }
            }
            else
            {
                Session["FromMySrilankanBay"] = true;
                Response.Redirect(CommonParameterNames.PageURLs.LoginPage);
            }
        }

        protected void btnDailyDeals_Click(object sender, EventArgs e)
        {
            Response.Redirect(CommonParameterNames.PageURLs.ItemSearch + "&dailydeals=1");
        }

        protected void btnCustomerSupport_Click(object sender, EventArgs e)
        {
            MessageBox(CommonParameterNames.MessageBoxType.CusSupport, "../customer_support.aspx");
        }


    }
}