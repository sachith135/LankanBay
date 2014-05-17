using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DOMAIN;
using SERVICE;
using Telerik.Web.UI;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using DOMAIN;
using SERVICE;

namespace LankanBay
{
    public partial class userregistration : System.Web.UI.Page
    {
        AddressCatogoryDetails addressCatogoryDetails = new AddressCatogoryDetails();
        AddressCatogoryDetailsService addressCatogoryDetailsService = new AddressCatogoryDetailsService();

        PasswordResetQuestionsService passwordResetQuestionsService = new PasswordResetQuestionsService();

        UserDetails userDetails = new UserDetails();
        UserDetailsService userDetailsService = new UserDetailsService();

        BusinessPartnerReferenceDetails businessPartnerReferenceDetails = new DOMAIN.BusinessPartnerReferenceDetails();
        BusinessPartnerReferenceDetailsService businessPartnerReferenceDetailsService = new SERVICE.BusinessPartnerReferenceDetailsService();

        BusinessPartnerAddress businessPartnerAddress = new DOMAIN.BusinessPartnerAddress();
        BusinessPartnerAddressService businessPartnerAddressService = new SERVICE.BusinessPartnerAddressService();

        BusinessPartnerTypeDetails businessPartnerTypeDetails = new DOMAIN.BusinessPartnerTypeDetails();
        BusinessPartnerTypesService businessPartnerTypesService = new SERVICE.BusinessPartnerTypesService();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillUserType();
                FillAddressCategoryCombo();
                FillPasswordResetQuestions();
                chkIsActive.Checked = true;
                chkIsActive.Enabled = false;                
            }
        }

        private void FillUserType()
        {
            if (Convert.ToBoolean(Session[CommonParameterNames.URLParameters.IsFromLoginPage]))
            {
                cmbUserType.Items.Clear();
                cmbUserType.DataSource = businessPartnerTypesService.Select();
                cmbUserType.DataTextField = CommonParameterNames.CommonTableColumnName.Business_Partners.BusinessPartnerTypeDetails.Description;
                cmbUserType.DataValueField = CommonParameterNames.CommonTableColumnName.Business_Partners.BusinessPartnerTypeDetails.BSPTypeId;
                cmbUserType.DataBind();
                cmbUserType.SelectedIndex = 1;

                cmbUserType.Items.FindItemByValue("5").Remove();
            }
            
        }

        private void FillPasswordResetQuestions()
        {
            cmbSequrityQuestion.Items.Clear();
            cmbSequrityQuestion.DataSource = passwordResetQuestionsService.Select();
            cmbSequrityQuestion.DataTextField = CommonParameterNames.CommonTableColumnName.Business_Partners.PasswordResetQuestions.PasswordResetQuestion;
            cmbSequrityQuestion.DataValueField = CommonParameterNames.CommonTableColumnName.Business_Partners.PasswordResetQuestions.PasswordResetQuestionId;
            cmbSequrityQuestion.DataBind();
        }

        protected void cmbUserType_SelectedIndexChanged(object o, Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs e)
        {
            if (cmbUserType.SelectedValue == "S")
            {
                lblFirstName.Text = "Seller Name";
                lblLastName.Enabled = false;
                txtLname.Enabled = false;
                lblLastName.ForeColor = System.Drawing.Color.Silver;
                lblLastNameColon.ForeColor = System.Drawing.Color.Silver;

            }
            else
            {
                lblFirstName.Text = "First Name";
                lblLastName.Enabled = true;
                txtLname.Enabled = true;
                lblLastName.ForeColor = System.Drawing.Color.Black;
                lblLastNameColon.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void FillAddressCategoryCombo()
        {
            try
            {
                cmbAddressCategory.Items.Clear();
                cmbAddressCategory.DataSource = null;
                addressCatogoryDetails.IsActive = true;
                cmbAddressCategory.DataSource = addressCatogoryDetailsService.Select(addressCatogoryDetails);
                cmbAddressCategory.DataTextField = CommonParameterNames.CommonTableColumnName.Business_Partners.Address_Catogory_Details.AddressCategory;
                cmbAddressCategory.DataValueField = CommonParameterNames.CommonTableColumnName.Business_Partners.Address_Catogory_Details.AddressCatId;
                cmbAddressCategory.DataBind();

            }
            catch (Exception)
            {
                MessageBox(CommonParameterNames.MessageBoxType.ErrorMessage, CommonUserMessages.ErrorMessages.generalError);
            }
        }

        public void ResetInputs(bool reset)
        {
            if (reset)
            {
                cmbAddressCategory.SelectedIndex = 0;
                cmbSequrityQuestion.SelectedIndex = 0;
                cmbUserType.SelectedIndex = 0;

                txtAddressCity.Text = "";
                txtAddressLine01.Text = "";
                txtAddressLine02.Text = "";
                txtAddressState.Text = "";
                txtAddressState.Text = "";
                txtAddressZipCode.Text = "";
                txtAnswer.Text = "";
                txtConfirmPassword.Text = "";
                txtFax.Text = "";
                txtFname.Text = "";
                txtLname.Text = "";
                txtPassword.Text = "";
                txtPrimaryContactNo.Text = "";
                txtPrimaryEmail.Text = "";
                txtUsername.Text = "";

                radMale.Checked = true;
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                userDetails.Username = txtUsername.Text;
                if (userDetailsService.Select(userDetails).Rows.Count == 0)
                {
                    businessPartnerReferenceDetails.BSPCode = Guid.NewGuid().ToString();
                    businessPartnerReferenceDetails.BSPId = 1;
                    businessPartnerReferenceDetails.BSPTypeId = Convert.ToInt32(cmbUserType.SelectedValue);
                    businessPartnerReferenceDetails.Fax = txtFax.Text.Trim();
                    businessPartnerReferenceDetails.FirstName = txtFname.Text.Trim();
                    businessPartnerReferenceDetails.IsActive = chkIsActive.Checked;
                    businessPartnerReferenceDetails.LastName = txtLname.Text.Trim();
                    businessPartnerReferenceDetails.PrimaryContactNo = txtPrimaryContactNo.Text.Trim();
                    businessPartnerReferenceDetails.PrimaryEmail = txtPrimaryEmail.Text.Trim();
                    businessPartnerReferenceDetails.UserId = -999;

                    int bspId = Convert.ToInt32(businessPartnerReferenceDetailsService.Insert(businessPartnerReferenceDetails).Rows[0]["BSPId"]);

                    businessPartnerAddress.AddressCatId = Convert.ToInt32(cmbAddressCategory.SelectedValue);
                    businessPartnerAddress.AddressId = 1;
                    businessPartnerAddress.AddressLine01 = txtAddressLine01.Text.Trim();
                    businessPartnerAddress.AddressLine02 = txtAddressLine02.Text.Trim();
                    businessPartnerAddress.AddressLine03 = "";
                    businessPartnerAddress.BSPId = bspId;
                    businessPartnerAddress.City = txtAddressCity.Text.Trim();
                    businessPartnerAddress.ZipCode = txtAddressZipCode.Text.Trim();
                    businessPartnerAddress.IsCurrentMail = IsDefaltShippingAddess.Checked;
                    businessPartnerAddress.IsShippingMail = IsDefaltShippingAddess.Checked;
                    businessPartnerAddress.State = txtAddressState.Text.Trim();
                    businessPartnerAddress.UserId = -999;

                    businessPartnerAddressService.Insert(businessPartnerAddress);

                    userDetails.BSPId = bspId;
                    userDetails.CreatedorModifiedUserId = -999;
                    userDetails.IsActive = true;
                    userDetails.IsLocked = false;
                    userDetails.Password = userDetailsService.CalculateMD5Hash(txtUsername.Text.Trim() + txtPassword.Text.Trim());
                    userDetails.ResetPwQuestionAnswer = txtAnswer.Text.Trim();
                    userDetails.ResetPwQuestionId = Convert.ToInt32(cmbSequrityQuestion.SelectedValue);
                    userDetails.UserId = 1;
                    userDetails.Username = txtUsername.Text.Trim();

                    userDetailsService.Insert(userDetails);

                    DataBaseTransactionService.CommitTransactions();
                    SendEmail();
                    ResetInputs(true);
                    MessageBox(CommonParameterNames.MessageBoxType.SuccessMessage, CommonUserMessages.SuccessfulMessages.userRegistrationSuccessful);
                }
                else
                {
                    MessageBox(CommonParameterNames.MessageBoxType.WarnningMessage, CommonUserMessages.WarnningMessages.usenameralreadyexists);
                }
            }
            catch (Exception)
            {
                MessageBox(CommonParameterNames.MessageBoxType.ErrorMessage,CommonUserMessages.ErrorMessages.generalError);
            }
                                    
        }

        private void SendEmail()
        {
            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("lankanbay.com@gmail.com", "admin@lankanbay");

            string bsp = "cus001";
            string guid = Guid.NewGuid().ToString();
            string msg = "<div style='padding:20px; background-color:#F2F2F2;font-family:Trebuchet MS;'><img src='http://s30.postimg.org/n4n5y98gx/newlogo.png' width='300px'/><br><h1>Account varification from LankanBay.com</h1><p style='padding:10px; background-color:#5D9AFC;font-size:14px;'>This is to varify your LankanBay account before you begin to purchase from your own account.<br>This link will only valid for once.</p><br><h3 style='padding:10px; background-color:#9CFBE0;'>Click to verify .... <br>http://localhost:12345/home.aspx?bsp=" + bsp + "&guid=" + guid + "&confirm=1</h3><br><h3 style='padding:10px; background-color:#FA7878;'>If you did not create this click here ....<br>http://localhost:12345/home.aspx?bsp=" + bsp + "&guid=" + guid + "&confirm=0</h3><br>Visit us: http://192.168.1.85:1234<br>All in one place , Search .... Buy ..., The easiest way to purchase any item you want.</div>";
            MailMessage mm = new MailMessage("snk.testprojects@gmail.com", txtPrimaryEmail.Text, "Account varification email from LankanBay.com", msg);
            mm.IsBodyHtml = true;
            mm.BodyEncoding = System.Text.UTF8Encoding.UTF8;
            mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

            client.Send(mm);
        }
       
        protected void btnClose_Click(object sender, EventArgs e)
        {
            Page.ClientScript.RegisterClientScriptBlock(GetType(), "CloseScript", "Close()", true);
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

        protected void btnClear_Click(object sender, EventArgs e)
        {
            ResetInputs(true);
        }
    }
}