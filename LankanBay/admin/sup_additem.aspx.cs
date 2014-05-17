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
using System.Data;

namespace LankanBay.admin
{
    public partial class sup_additem : System.Web.UI.Page
    {
        ItemDetails itemDetails = new ItemDetails();
        ItemDetailsService itemDetailsService = new ItemDetailsService();

        DeleveryOptionsDetails deleveryOptionsDetails = new DeleveryOptionsDetails();
        DeleveryOptionDetailsService deleveryOptionDetailsService = new DeleveryOptionDetailsService();

        CategoryDetails categoryDetails = new CategoryDetails();
        CategoryDetailsService categoryDetailsService = new CategoryDetailsService();

        BusinessPartnerReferenceDetails businessPartnerReferenceDetails = new BusinessPartnerReferenceDetails();
        BusinessPartnerReferenceDetailsService businessPartnerReferenceDetailsService = new BusinessPartnerReferenceDetailsService();

        BusinessPartnerTypeDetails businessPartnerTypeDetails = new BusinessPartnerTypeDetails();

        SubCategoryDetails subCategoryDetails = new SubCategoryDetails();
        SubCategoryDetailsService subCategoryDetailsService = new SubCategoryDetailsService();

        ItemConditionDetails itemConditionDetails = new ItemConditionDetails();
        ItemConditionDetailsService itemConditionDetailsService = new ItemConditionDetailsService();

        PurchasingMethodDetails purchasingMethodDetails = new PurchasingMethodDetails();
        PurchasingMethodDetailsService purchasingMethodDetailsService = new PurchasingMethodDetailsService();

        ErrorLogDetails errorLogDetails = new ErrorLogDetails();
        ErrorLogDetailsService errorLogDetailsService = new ErrorLogDetailsService();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {                    
                    FillSupplierDetailsCombo();
                    FillGrid();
                    FillCategoryDetailsCombo();
                    FillSubCategoryDetailsCombo();
                    FillItemConditionDetailsCombo();
                    FillDeleveryOptionCombo();
                    FillPurchasingMethodDetails();         
                    ResetInputs(true);
                }
            }
            catch (Exception)
            {
                LankanBay.masterpages.admin master = (LankanBay.masterpages.admin)this.Master;
                master.MessageBox(CommonParameterNames.MessageBoxType.ErrorMessage, CommonUserMessages.ErrorMessages.generalError);
            }
        }

        #region FillGrid
        private void FillGrid()
        {
            try
            {
                itemDetails.BSPId = Convert.ToInt32(cmbSupplier.SelectedValue.Length==0 ? "0" : cmbSupplier.SelectedValue);
                itemDetails.ItemId = 0;

                dgSellersItems.DataSource = null;
                dgSellersItems.DataSource = itemDetailsService.SelectSellersItems(itemDetails);
                dgSellersItems.DataBind();
            }
            catch (Exception)
            {

            }
        }
        #endregion

        #region FillCombo Boxes

        private void FillSupplierDetailsCombo()
        {
            try
            {
                cmbSupplier.Items.Clear();
                cmbSupplier.DataSource = null;

                businessPartnerReferenceDetails.IsActive = true;
                businessPartnerTypeDetails.BSPShortCode = "S";

                cmbSupplier.DataSource = businessPartnerReferenceDetailsService.Select(businessPartnerReferenceDetails, businessPartnerTypeDetails);
                cmbSupplier.DataTextField = CommonParameterNames.CommonTableColumnName.Business_Partners.BusinessPartnerReference.FullName;
                cmbSupplier.DataValueField = CommonParameterNames.CommonTableColumnName.Business_Partners.BusinessPartnerReference.BSPId;
                cmbSupplier.DataBind();
            }
            catch (Exception)
            {
                LankanBay.masterpages.admin master = (LankanBay.masterpages.admin)this.Master;
                master.MessageBox(CommonParameterNames.MessageBoxType.ErrorMessage, CommonUserMessages.ErrorMessages.generalError);
            }
        }

        private void FillCategoryDetailsCombo()
        {
            try
            {
                cmbCategory.Items.Clear();
                cmbCategory.DataSource = null;

                categoryDetails = new CategoryDetails();
                categoryDetails.IsActive = true;
                cmbCategory.DataSource = categoryDetailsService.Select(categoryDetails);
                cmbCategory.DataTextField = CommonParameterNames.CommonTableColumnName.Inventory.CatrgoryDetails.Name;
                cmbCategory.DataValueField = CommonParameterNames.CommonTableColumnName.Inventory.CatrgoryDetails.CategoryId;
                cmbCategory.DataBind();
            }
            catch (Exception)
            {
                LankanBay.masterpages.admin master = (LankanBay.masterpages.admin)this.Master;
                master.MessageBox(CommonParameterNames.MessageBoxType.ErrorMessage, CommonUserMessages.ErrorMessages.generalError);
            }
        }

        private void FillSubCategoryDetailsCombo()
        {
            try
            {
                if (cmbCategory.SelectedValue.Length != 0)
                {
                    cmbSubCategory.Items.Clear();
                    cmbSubCategory.DataSource = null;

                    subCategoryDetails = new SubCategoryDetails();
                    subCategoryDetails.IsActive = true;
                    subCategoryDetails.CategoryId = Convert.ToInt32(cmbCategory.SelectedValue);

                    cmbSubCategory.DataSource = subCategoryDetailsService.Select(subCategoryDetails);
                    cmbSubCategory.DataTextField = CommonParameterNames.CommonTableColumnName.Inventory.SubCategoryDetails.Name;
                    cmbSubCategory.DataValueField = CommonParameterNames.CommonTableColumnName.Inventory.SubCategoryDetails.SubCategoryId;
                    cmbSubCategory.DataBind();
                }
            }
            catch (Exception)
            {
                LankanBay.masterpages.admin master = (LankanBay.masterpages.admin)this.Master;
                master.MessageBox(CommonParameterNames.MessageBoxType.ErrorMessage, CommonUserMessages.ErrorMessages.generalError);
            }
        }

        private void FillDeleveryOptionCombo()
        {
            try
            {
                cmbDeleveryOption.Items.Clear();
                cmbDeleveryOption.DataSource = null;

                deleveryOptionsDetails.IsActive = true;
                cmbDeleveryOption.DataSource = deleveryOptionDetailsService.Select(deleveryOptionsDetails);
                cmbDeleveryOption.DataTextField = CommonParameterNames.CommonTableColumnName.Inventory.DeleveryOptionDetails.DeleveryOption;
                cmbDeleveryOption.DataValueField = CommonParameterNames.CommonTableColumnName.Inventory.DeleveryOptionDetails.DeleveryOptionId;
                cmbDeleveryOption.DataBind();
            }
            catch (Exception)
            {
                LankanBay.masterpages.admin master = (LankanBay.masterpages.admin)this.Master;
                master.MessageBox(CommonParameterNames.MessageBoxType.ErrorMessage, CommonUserMessages.ErrorMessages.generalError);
            }
        }

        private void FillItemConditionDetailsCombo()
        {
            try
            {
                cmbItemCondition.Items.Clear();
                cmbItemCondition.DataSource = null;

                itemConditionDetails = new ItemConditionDetails();
                itemConditionDetails.IsActive = true;

                cmbItemCondition.DataSource = itemConditionDetailsService.Select(itemConditionDetails);
                cmbItemCondition.DataTextField = CommonParameterNames.CommonTableColumnName.Inventory.ItemConditionDetails.ItemCondition;
                cmbItemCondition.DataValueField = CommonParameterNames.CommonTableColumnName.Inventory.ItemConditionDetails.ItemConditionId;
                cmbItemCondition.DataBind();
            }
            catch (Exception)
            {
                LankanBay.masterpages.admin master = (LankanBay.masterpages.admin)this.Master;
                master.MessageBox(CommonParameterNames.MessageBoxType.ErrorMessage, CommonUserMessages.ErrorMessages.generalError);

            }
        }

        private void FillPurchasingMethodDetails()
        {
            try
            {
                cmbPurchasingMethod.Items.Clear();
                cmbPurchasingMethod.DataSource = null;

                purchasingMethodDetails = new PurchasingMethodDetails();
                purchasingMethodDetails.IsActive = true;

                cmbPurchasingMethod.DataSource = purchasingMethodDetailsService.Select(purchasingMethodDetails);
                cmbPurchasingMethod.DataTextField = CommonParameterNames.CommonTableColumnName.Inventory.ItemPurchasingMethodDetails.ItemPurchasingMethod;
                cmbPurchasingMethod.DataValueField = CommonParameterNames.CommonTableColumnName.Inventory.ItemPurchasingMethodDetails.ItemPurchasingMethodId;
                cmbPurchasingMethod.DataBind();
            }
            catch (Exception)
            {
                LankanBay.masterpages.admin master = (LankanBay.masterpages.admin)this.Master;
                master.MessageBox(CommonParameterNames.MessageBoxType.ErrorMessage, CommonUserMessages.ErrorMessages.generalError);
            }
        }

        #endregion

        #region ResetInputs
        public void ResetInputs(bool reset)
        {
            try
            {
                if (reset)
                {
                    txtDeleveryChargers.Text = "0";
                    txtItemDescrption.Text = "";
                    txtItemName.Text = "";
                    txtReturnDescription.Text = "";
                    txtUnitPrice.Text = "0";
                    txtWarrentyDescription.Text = "";

                    txtReOrderLevel.Text = "0";
                    txtQtyInHand.Text = "0";

                    cmbCategory.SelectedIndex = 0;
                    cmbDeleveryOption.SelectedIndex = 0;
                    cmbItemCondition.SelectedIndex = 0;
                    cmbPurchasingMethod.SelectedIndex = 0;
                    cmbSubCategory.SelectedIndex = 0;
                    cmbSupplier.SelectedIndex = 0;

                    chkIsActive.Checked = true;
                    chkIsViewInNavigationBar.Checked = false;

                    radYes.Checked = true;
                    txtDeleveryChargers.Enabled = false;                
                }
            }
            catch (Exception)
            {
                LankanBay.masterpages.admin master = (LankanBay.masterpages.admin)this.Master;
                master.MessageBox(CommonParameterNames.MessageBoxType.ErrorMessage, CommonUserMessages.ErrorMessages.generalError);            
            }
        }
        #endregion ResetInputs

        #region Insert
        public void Insert()
        {
            try
            {
                itemDetails.AlertQty = Convert.ToDecimal(txtReOrderLevel.Text.Trim());
                itemDetails.BSPId = Convert.ToInt32(cmbSupplier.SelectedValue.Trim());
                itemDetails.DeleveryOptionId = Convert.ToInt32(cmbDeleveryOption.SelectedValue.Trim());
                itemDetails.DelivaryDescription = txtDeliveryDescription.Text.Trim();
                itemDetails.DeliveryChargers = Convert.ToDecimal(txtDeleveryChargers.Text.Trim());
                itemDetails.Description = txtItemDescrption.Text.Trim();
                itemDetails.IsActive = chkIsActive.Checked;
                itemDetails.IsBuyerProtection = radYes.Checked = true ? true : false;
                itemDetails.IsViewInNavBar = chkIsViewInNavigationBar.Checked;
                itemDetails.ItemConditionId = Convert.ToInt32(cmbItemCondition.SelectedValue.Trim());
                itemDetails.ItemId = 1;
                itemDetails.ItemName = txtItemName.Text.Trim();
                itemDetails.PurchasingMethodId = Convert.ToInt32(cmbPurchasingMethod.SelectedValue);
                itemDetails.QtyInHand = Convert.ToDecimal(txtQtyInHand.Text.Trim());
                itemDetails.ReturnsDescription = txtReturnDescription.Text.Trim();
                itemDetails.SubCategoryId = Convert.ToInt32(cmbSubCategory.SelectedValue.Trim());
                itemDetails.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text.Trim());
                itemDetails.UserId = Convert.ToInt32(Session[CommonParameterNames.LoggedUserDetails.userId]);
                itemDetails.WarrantyDescription = txtWarrentyDescription.Text.Trim();
                itemDetails.WebPageURL = txtItemWebPageURL.Text.Trim();

                itemDetailsService.Insert(itemDetails);
                DataBaseTransactionService.CommitTransactions();                

                FillGrid();               
                //SendEmail();
                ResetInputs(true);
                LankanBay.masterpages.admin master = (LankanBay.masterpages.admin)this.Master;
                master.MessageBox(CommonParameterNames.MessageBoxType.SuccessMessage, CommonUserMessages.SuccessfulMessages.insertionSuccessful);

            }
            catch (Exception ex)
            {
                errorLogDetails.ClassNamePlusFunctionName = "admin/sup_additem.aspx.cs -> Insert()";
                errorLogDetails.ErrorMessage = ex.Message; 
                errorLogDetails.UserId = Convert.ToInt32(Session[CommonParameterNames.LoggedUserDetails.userId]);
                errorLogDetailsService.Insert(errorLogDetails);

                LankanBay.masterpages.admin master = (LankanBay.masterpages.admin)this.Master;
                master.MessageBox(CommonParameterNames.MessageBoxType.ErrorMessage, CommonUserMessages.ErrorMessages.generalError);
            }
        }
        #endregion

        private void SendEmail()
        {
            DataTable dtCustomerDetails = new DataTable();
            string email = "";
            string sub="";

            businessPartnerTypeDetails = new DOMAIN.BusinessPartnerTypeDetails();
            businessPartnerTypeDetails.BSPShortCode="C";
            dtCustomerDetails= businessPartnerReferenceDetailsService.Select(businessPartnerReferenceDetails, businessPartnerTypeDetails);

            for (int i = 0; i < dtCustomerDetails.Rows.Count; i++)
            {
                email = dtCustomerDetails.Rows[i][CommonParameterNames.CommonTableColumnName.Business_Partners.BusinessPartnerReference.PrimaryEmail].ToString();
                sub = "Just added " + txtItemName.Text + " on in LankanBay.Com";
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
                string msg = "<div style='padding:20px; background-color:#F2F2F2;font-family:Trebuchet MS;'><img src='http://s30.postimg.org/n4n5y98gx/newlogo.png' width='300px'/><br><h1>Just added " + txtItemName.Text + " in LankanBay.Com. </h1><p style='padding:10px; background-color:#5D9AFC;font-size:14px;'>" + txtDeliveryDescription.Text + "</p><br><hr><h1>Now just for LKR" + txtUnitPrice.Text + "</h1><h3>Visit : </h3>http://localhost:12345/home.aspx</div>";
                MailMessage mm = new MailMessage("lankanbay.com@gmail.com", email, sub, msg);
                mm.IsBodyHtml = true;
                mm.BodyEncoding = System.Text.UTF8Encoding.UTF8;
                mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

                client.Send(mm); 
            }
        }

        protected void cmbDeleveryOption_SelectedIndexChanged(object o, RadComboBoxSelectedIndexChangedEventArgs e)
        {
            try
            {
                deleveryOptionsDetails = new DeleveryOptionsDetails();

                if (cmbDeleveryOption.SelectedValue != null)
                {
                    deleveryOptionsDetails.IsActive = false;
                    deleveryOptionsDetails.DeleveryOptionId = Convert.ToInt32(cmbDeleveryOption.SelectedValue);

                    if (Convert.ToBoolean(deleveryOptionDetailsService.Select(deleveryOptionsDetails).Rows[0][CommonParameterNames.CommonTableColumnName.Inventory.DeleveryOptionDetails.DeleveryChargersApply]))
                    {
                        txtDeleveryChargers.Enabled = true;
                        txtDeleveryChargers.Text = "0";
                    }
                    else
                    {
                        txtDeleveryChargers.Enabled = false;
                        txtDeleveryChargers.Text = "0";
                    }
                }
            }
            catch (Exception)
            {
                LankanBay.masterpages.admin master = (LankanBay.masterpages.admin)this.Master;
                master.MessageBox(CommonParameterNames.MessageBoxType.ErrorMessage, CommonUserMessages.ErrorMessages.generalError);
            }
        }

        protected void cmbCategory_SelectedIndexChanged(object o, RadComboBoxSelectedIndexChangedEventArgs e)
        {
            FillSubCategoryDetailsCombo();
        }
    }
}