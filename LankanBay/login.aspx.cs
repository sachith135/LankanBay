using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DOMAIN;
using SERVICE;
using System.Data;

namespace LankanBay
{
    public partial class login : System.Web.UI.Page
    {
        UserDetails userDetails = new UserDetails();
        UserDetailsService userDetailsService = new UserDetailsService();

        DataTable dtUserDetails = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Clear();
                Session["dtCart"] = "";              
                
                Session[CommonParameterNames.LoggedUserDetails.loggingAttempts] = 0;
                Session[CommonParameterNames.LoggedUserDetails.userId] = "";
                Session[CommonParameterNames.LoggedUserDetails.username] = "";
                Session[CommonParameterNames.URLParameters.IsFromLoginPage] ="";                                
            }

            Session[CommonParameterNames.LoggedUserDetails.userId] = null;
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                userDetails = new UserDetails();
                userDetails.Username = txtUsername.Text.Trim();
                userDetails.IsActive = true;
                dtUserDetails = userDetailsService.Select(userDetails);

                if (Convert.ToInt32(Session[CommonParameterNames.LoggedUserDetails.loggingAttempts]) < 3)
                {
                    if (dtUserDetails.Rows.Count > 0)
                    {
                        if (!Convert.ToBoolean(dtUserDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Business_Partners.UserDetails.IsLocked]))
                        {
                            if (userDetailsService.CalculateMD5Hash(txtUsername.Text.Trim() + txtPassword.Text.Trim()).ToLower() == dtUserDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Business_Partners.UserDetails.Password].ToString().ToLower())
                            {
                                DataTable dtCart = new DataTable();
                                dtCart.Columns.Add("ImagePath");
                                dtCart.Columns.Add("ItemId");
                                dtCart.Columns.Add("ItemName");
                                dtCart.Columns.Add("Description");
                                dtCart.Columns.Add("Qty");
                                dtCart.Columns.Add("QtyInHand");
                                dtCart.Columns.Add("UnitPrice");
                                dtCart.Columns.Add("DeliveryChargers");
                                dtCart.Columns.Add("Total");
                                Session["dtCart"] = dtCart;

                                Session[CommonParameterNames.LoggedUserDetails.bspShortCode] = dtUserDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Business_Partners.UserDetails.BSPShortCode].ToString().Trim();

                                if (System.Web.HttpContext.Current.Session["ItemId"] != null)
                                {  
                                    Session[CommonParameterNames.LoggedUserDetails.loggingAttempts] = 0;
                                    Session[CommonParameterNames.LoggedUserDetails.userId] = dtUserDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Business_Partners.UserDetails.UserId].ToString();
                                    Session[CommonParameterNames.LoggedUserDetails.username] = dtUserDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Business_Partners.UserDetails.Username].ToString();
                                    Session[CommonParameterNames.LoggedUserDetails.bspId] = dtUserDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Business_Partners.UserDetails.BSPId].ToString();
                                    Response.Redirect(CommonParameterNames.PageURLs.ViewItemPageWithParameters + Session["ItemId"].ToString());
                                }
                                else if(Convert.ToBoolean(Session["FromMySrilankanBay"]))
                                {                                   
                                    if (dtUserDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Business_Partners.UserDetails.BSPShortCode].ToString().Trim() == "S")
                                    {
                                        Session[CommonParameterNames.LoggedUserDetails.loggingAttempts] = 0;
                                        Session[CommonParameterNames.LoggedUserDetails.userId] = dtUserDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Business_Partners.UserDetails.UserId].ToString();
                                        Session[CommonParameterNames.LoggedUserDetails.username] = dtUserDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Business_Partners.UserDetails.Username].ToString();
                                        Session[CommonParameterNames.LoggedUserDetails.bspId] = dtUserDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Business_Partners.UserDetails.BSPId].ToString();
                                        Response.Redirect(CommonParameterNames.PageURLs.BspCustomerProfile + Session[CommonParameterNames.LoggedUserDetails.bspId].ToString()+"&next=");
                                    }
                                    else if (dtUserDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Business_Partners.UserDetails.BSPShortCode].ToString().Trim() == "C")
                                    {
                                        Session[CommonParameterNames.LoggedUserDetails.loggingAttempts] = 0;
                                        Session[CommonParameterNames.LoggedUserDetails.userId] = dtUserDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Business_Partners.UserDetails.UserId].ToString();
                                        Session[CommonParameterNames.LoggedUserDetails.username] = dtUserDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Business_Partners.UserDetails.Username].ToString();
                                        Session[CommonParameterNames.LoggedUserDetails.bspId] = dtUserDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Business_Partners.UserDetails.BSPId].ToString();
                                        Response.Redirect(CommonParameterNames.PageURLs.BspCustomerProfile + Session[CommonParameterNames.LoggedUserDetails.bspId].ToString() + "&next=");
                                    }
                                }

                                else if (dtUserDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Business_Partners.BusinessPartnerTypeDetails.BSPShortCode].ToString().Trim() == "C")
                                {                                   
                                    Session[CommonParameterNames.LoggedUserDetails.loggingAttempts] = 0;
                                    Session[CommonParameterNames.LoggedUserDetails.userId] = dtUserDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Business_Partners.UserDetails.UserId].ToString();
                                    Session[CommonParameterNames.LoggedUserDetails.username] = dtUserDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Business_Partners.UserDetails.Username].ToString();
                                    Session[CommonParameterNames.LoggedUserDetails.bspId] = dtUserDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Business_Partners.UserDetails.BSPId].ToString();
                                    Response.Redirect(CommonParameterNames.PageURLs.HomePage);
                                }
                                else if (dtUserDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Business_Partners.BusinessPartnerTypeDetails.BSPShortCode].ToString().Trim() == "S")
                                {
                                    
                                    Session[CommonParameterNames.LoggedUserDetails.loggingAttempts] = 0;
                                    Session[CommonParameterNames.LoggedUserDetails.userId] = dtUserDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Business_Partners.UserDetails.UserId].ToString();
                                    Session[CommonParameterNames.LoggedUserDetails.username] = dtUserDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Business_Partners.UserDetails.Username].ToString();
                                    Session[CommonParameterNames.LoggedUserDetails.bspId] = dtUserDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Business_Partners.UserDetails.BSPId].ToString();
                                    Response.Redirect(CommonParameterNames.PageURLs.AdminMainPage);
                                }                               
                                
                            }
                            else
                            {
                                MessageBox(CommonParameterNames.MessageBoxType.ErrorMessage, CommonUserMessages.WarnningMessages.passwordIncorrect);
                            }
                        }
                        else
                        {
                            MessageBox(CommonParameterNames.MessageBoxType.WarnningMessage, CommonUserMessages.WarnningMessages.yourAccountIsLocked);
                        }
                    }
                    else
                    {
                        MessageBox(CommonParameterNames.MessageBoxType.ErrorMessage, CommonUserMessages.WarnningMessages.usernameNotExists);
                    }
                }
                else
                {
                    userDetails.Username = txtUsername.Text.Trim();
                    userDetails.IsLocked = true;
                    userDetailsService.LockOrUnlockUserAccount(userDetails);

                    MessageBox(CommonParameterNames.MessageBoxType.WarnningMessage, CommonUserMessages.WarnningMessages.yourAccountIsLocked);
                }

                Session[CommonParameterNames.LoggedUserDetails.loggingAttempts] = Convert.ToInt32(Session[CommonParameterNames.LoggedUserDetails.loggingAttempts]) + 1;

            }
            catch (Exception)
            {
                MessageBox(CommonParameterNames.MessageBoxType.ErrorMessage, CommonUserMessages.ErrorMessages.generalError);
            }
        }

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

            RadWindow1.Animation = Telerik.Web.UI.WindowAnimation.Fade;
            RadWindow1.AnimationDuration = 1000;           

            RadWindowManager1.EnableViewState = false;
            RadWindowManager1.Windows.Add(RadWindow1);

        }

        public void UserRegistration()
        {
            RadWindow1.Width = 695;
            RadWindow1.Height = 515;
            RadWindow1.NavigateUrl = "~/userregistration.aspx";
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

        public void ForgotPassword()
        {
            RadWindow1.Width = 650;
            RadWindow1.Height = 430;
            RadWindow1.NavigateUrl = "~/forgot_password.aspx";
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

        protected void lnkBtnUserRegistration_Click(object sender, EventArgs e)
        {
            Session[CommonParameterNames.URLParameters.IsFromLoginPage] = true;
            UserRegistration();            
        }

        protected void btnForgotPassword_Click(object sender, EventArgs e)
        {
            ForgotPassword();
        }
    }
}