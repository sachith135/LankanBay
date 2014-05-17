using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DOMAIN;
using SERVICE;
using Telerik.Web.UI;

namespace LankanBay.admin
{
    public partial class admin_add_subcatrgory : System.Web.UI.Page
    {
        CategoryDetails categoryDetails = new CategoryDetails();
        CategoryDetailsService categoryDetailsService = new CategoryDetailsService();

        SubCategoryDetails subCategoryDetails = new SubCategoryDetails();
        SubCategoryDetailsService subCategoryDetailsService = new SubCategoryDetailsService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ResetInputs(true);
                FillCategoryCombo();
                FillGrid();
            }
        }

        private void FillCategoryCombo()
        {
            try
            {
                categoryDetails = new CategoryDetails();
                categoryDetails.CategoryId = 0;
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

        private void FillGrid()
        {
            try
            {
                dgSubcategories.DataSource = null;
                subCategoryDetails = new SubCategoryDetails();
                dgSubcategories.DataSource = subCategoryDetailsService.Select(subCategoryDetails);
                dgSubcategories.DataBind();
            }
            catch (Exception)
            {
                LankanBay.masterpages.admin master = (LankanBay.masterpages.admin)this.Master;
                master.MessageBox(CommonParameterNames.MessageBoxType.ErrorMessage, CommonUserMessages.ErrorMessages.generalError);
            }
        }

        public void Insert()
        {
            try
            {
                subCategoryDetails = new SubCategoryDetails();
                subCategoryDetails.CategoryId = Convert.ToInt32(cmbCategory.SelectedValue);
                subCategoryDetails.Description = txtDescription.Text.Trim();
                subCategoryDetails.IsActive = chkIsActive.Checked;
                subCategoryDetails.IsViewInNavBar = chkIsViewInNavBar.Checked;
                subCategoryDetails.Name = txtSubCategory.Text.Trim();
                subCategoryDetails.SubCategoryId = 1;
                subCategoryDetails.UserId = Convert.ToInt32(Session[CommonParameterNames.LoggedUserDetails.userId]);
                subCategoryDetails.OrderId = Convert.ToInt32(txtOrderId.Text.Trim());
                subCategoryDetailsService.Insert(subCategoryDetails);
                DataBaseTransactionService.CommitTransactions();

                LankanBay.masterpages.admin master = (LankanBay.masterpages.admin)this.Master;
                master.MessageBox(CommonParameterNames.MessageBoxType.SuccessMessage, CommonUserMessages.SuccessfulMessages.insertionSuccessful);
                ResetInputs(true);
                FillGrid();
           
            }
            catch (Exception)
            {
                DataBaseTransactionService.RollbackTransactions();
                LankanBay.masterpages.admin master = (LankanBay.masterpages.admin)this.Master;
                master.MessageBox(CommonParameterNames.MessageBoxType.ErrorMessage, CommonUserMessages.ErrorMessages.generalError);
            }
        }

        public void Update()
        {
            try
            {
                subCategoryDetails = new SubCategoryDetails();
                subCategoryDetails.CategoryId = Convert.ToInt32(cmbCategory.SelectedValue);
                subCategoryDetails.Description = txtDescription.Text.Trim();
                subCategoryDetails.IsActive = chkIsActive.Checked;
                subCategoryDetails.IsViewInNavBar = chkIsViewInNavBar.Checked;
                subCategoryDetails.Name = txtSubCategory.Text.Trim();
                subCategoryDetails.SubCategoryId = Convert.ToInt32(Session[CommonParameterNames.CommonTableColumnName.Inventory.SubCategoryDetails.SubCategoryId]);
                subCategoryDetails.UserId = Convert.ToInt32(Session[CommonParameterNames.LoggedUserDetails.userId]);
                subCategoryDetails.OrderId = Convert.ToInt32(txtOrderId.Text.Trim());
                subCategoryDetailsService.Update(subCategoryDetails);
                DataBaseTransactionService.CommitTransactions();

                LankanBay.masterpages.admin master = (LankanBay.masterpages.admin)this.Master;
                master.MessageBox(CommonParameterNames.MessageBoxType.SuccessMessage, CommonUserMessages.SuccessfulMessages.updationSuccessful);
                ResetInputs(true);
                FillGrid();
            }
            catch (Exception)
            {
                DataBaseTransactionService.RollbackTransactions();
                LankanBay.masterpages.admin master = (LankanBay.masterpages.admin)this.Master;
                master.MessageBox(CommonParameterNames.MessageBoxType.ErrorMessage, CommonUserMessages.ErrorMessages.generalError);
            }
        }

        public void Delete()
        {
            try
            {
                subCategoryDetails.SubCategoryId = Convert.ToInt32(Session[CommonParameterNames.CommonTableColumnName.Inventory.SubCategoryDetails.SubCategoryId]);
                subCategoryDetails.UserId = Convert.ToInt32(Session[CommonParameterNames.LoggedUserDetails.userId]);
                subCategoryDetailsService.Delete(subCategoryDetails);
                DataBaseTransactionService.CommitTransactions();

                LankanBay.masterpages.admin master = (LankanBay.masterpages.admin)this.Master;
                master.MessageBox(CommonParameterNames.MessageBoxType.SuccessMessage, CommonUserMessages.SuccessfulMessages.deletionSuccessful);
                ResetInputs(true);
                FillGrid();
            }
            catch (Exception)
            {
                DataBaseTransactionService.RollbackTransactions();
                LankanBay.masterpages.admin master = (LankanBay.masterpages.admin)this.Master;
                master.MessageBox(CommonParameterNames.MessageBoxType.ErrorMessage, CommonUserMessages.ErrorMessages.generalError);
            }
        }

        public void ResetInputs(bool reset)
        {
            txtDescription.Text = "";
            txtSubCategory.Text = "";
            chkIsActive.Checked = true;
            chkIsViewInNavBar.Checked = true;
            cmbCategory.SelectedIndex = 0;
            txtOrderId.Text = "";
        }

        public void Print()
        {
            Response.Redirect(CommonParameterNames.PageURLs.ReportViwerWithParameter + CommonParameterNames.ReportURL.SubCategoryDetails);
        }

        protected void dgSubcategories_ItemCommand(object source, GridCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == CommonParameterNames.ItemCommnads.Select)
                {
                    GridDataItem item = (GridDataItem)e.Item;
                    Session[CommonParameterNames.CommonTableColumnName.Inventory.SubCategoryDetails.SubCategoryId] = Convert.ToInt32(item[CommonParameterNames.CommonTableColumnName.Inventory.SubCategoryDetails.SubCategoryId].Text);
                    txtDescription.Text = item[CommonParameterNames.CommonTableColumnName.Inventory.SubCategoryDetails.Description].Text;
                    txtSubCategory.Text = item[CommonParameterNames.CommonTableColumnName.Inventory.SubCategoryDetails.Name].Text;
                    chkIsActive.Checked = Convert.ToBoolean(item[CommonParameterNames.CommonTableColumnName.Inventory.SubCategoryDetails.IsActive].Text);
                    chkIsViewInNavBar.Checked = Convert.ToBoolean(item[CommonParameterNames.CommonTableColumnName.Inventory.SubCategoryDetails.IsViewInNavBar].Text);
                    cmbCategory.SelectedValue = item[CommonParameterNames.CommonTableColumnName.Inventory.SubCategoryDetails.CategoryId].Text;
                    txtOrderId.Text = item[CommonParameterNames.CommonTableColumnName.Inventory.SubCategoryDetails.OrderId].Text;
                    LankanBay.masterpages.admin master = (LankanBay.masterpages.admin)this.Master;
                    master.Update();
                }

                else if (e.CommandName == CommonParameterNames.ItemCommnads.Delete)
                {
                    GridDataItem item = (GridDataItem)e.Item;
                    Session[CommonParameterNames.CommonTableColumnName.Inventory.SubCategoryDetails.SubCategoryId] = Convert.ToInt32(item[CommonParameterNames.CommonTableColumnName.Inventory.SubCategoryDetails.SubCategoryId].Text);
                    Delete();
                }
            }
            catch (Exception)
            {
                LankanBay.masterpages.admin master = (LankanBay.masterpages.admin)this.Master;
                master.MessageBox(CommonParameterNames.MessageBoxType.ErrorMessage, CommonUserMessages.ErrorMessages.generalError);
            
            }
        }

        protected void dgSubcategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillGrid();
        }

        protected void dgSubcategories_NeedDataSource(object source, GridNeedDataSourceEventArgs e)
        {
            dgSubcategories.DataSource = null;
            subCategoryDetails = new SubCategoryDetails();
            dgSubcategories.DataSource = subCategoryDetailsService.Select(subCategoryDetails);
        }

        protected void dgSubcategories_PageIndexChanged(object source, GridPageChangedEventArgs e)
        {
            FillGrid();
        }

        protected void dgSubcategories_PageSizeChanged(object source, GridPageSizeChangedEventArgs e)
        {
            FillGrid();
        }

        protected void dgSubcategories_PdfExporting(object source, GridPdfExportingArgs e)
        {

        }
    }
}