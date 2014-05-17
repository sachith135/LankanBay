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
    public partial class admin_add_catrgory : System.Web.UI.Page
    {
        CategoryDetails categoryDetails = new CategoryDetails();
        CategoryDetailsService categoryDetailsService = new CategoryDetailsService();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ResetInputs(true);
                FillGrid();
            }
        }

        public void ResetInputs(bool reset)
        {
            if (reset)
            {
                txtDescription.Text = "";
                txtCatrgory.Text = "";
                chkIsViewInNavBar.Checked = true;
                chkIsActive.Checked = true;
                txtOrderId.Text = "";
            }
        }

        private void FillGrid()
        {
            try
            {
                categoryDetails = new CategoryDetails();
                categoryDetails.CategoryId = 0;
                dgCategories.DataSource = categoryDetailsService.Select(categoryDetails);
                dgCategories.DataBind();

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
                categoryDetails = new CategoryDetails();
                categoryDetails.CategoryId = 1;
                categoryDetails.Description = txtDescription.Text.Trim();
                categoryDetails.IsActive = chkIsActive.Checked;
                categoryDetails.IsViewInNavBar = chkIsViewInNavBar.Checked;
                categoryDetails.Name = txtCatrgory.Text.Trim();
                categoryDetails.UserId = Convert.ToInt32(Session[CommonParameterNames.LoggedUserDetails.userId]);
                categoryDetails.OrderId = Convert.ToInt32(txtOrderId.Text.Trim());
                categoryDetailsService.Insert(categoryDetails);
                DataBaseTransactionService.CommitTransactions();

                LankanBay.masterpages.admin master = (LankanBay.masterpages.admin)this.Master;
                master.MessageBox(CommonParameterNames.MessageBoxType.SuccessMessage, CommonUserMessages.SuccessfulMessages.insertionSuccessful);
                FillGrid();
                ResetInputs(true);

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
                categoryDetails = new CategoryDetails();
                categoryDetails.CategoryId = Convert.ToInt32(Session[CommonParameterNames.CommonTableColumnName.Inventory.CatrgoryDetails.CategoryId]);
                categoryDetails.Description = txtDescription.Text.Trim();
                categoryDetails.IsActive = chkIsActive.Checked;
                categoryDetails.IsViewInNavBar = chkIsViewInNavBar.Checked;
                categoryDetails.Name = txtCatrgory.Text.Trim();
                categoryDetails.OrderId = Convert.ToInt32(txtOrderId.Text.Trim());
                categoryDetails.UserId = Convert.ToInt32(Session[CommonParameterNames.LoggedUserDetails.userId]);
                categoryDetailsService.Update(categoryDetails);
                DataBaseTransactionService.CommitTransactions();

                LankanBay.masterpages.admin master = (LankanBay.masterpages.admin)this.Master;
                master.MessageBox(CommonParameterNames.MessageBoxType.SuccessMessage, CommonUserMessages.SuccessfulMessages.updationSuccessful);
                FillGrid();
                ResetInputs(true);

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
                categoryDetails = new CategoryDetails();
                categoryDetails.CategoryId = Convert.ToInt32(Session[CommonParameterNames.CommonTableColumnName.Inventory.CatrgoryDetails.CategoryId]);               
                categoryDetails.UserId = Convert.ToInt32(Session[CommonParameterNames.LoggedUserDetails.userId]);
                categoryDetailsService.Delete(categoryDetails);
                DataBaseTransactionService.RollbackTransactions();

                LankanBay.masterpages.admin master = (LankanBay.masterpages.admin)this.Master;
                master.MessageBox(CommonParameterNames.MessageBoxType.SuccessMessage, CommonUserMessages.SuccessfulMessages.deletionSuccessful);
                FillGrid();
                ResetInputs(true);

            }
            catch (Exception)
            {
                LankanBay.masterpages.admin master = (LankanBay.masterpages.admin)this.Master;
                master.MessageBox(CommonParameterNames.MessageBoxType.ErrorMessage, CommonUserMessages.ErrorMessages.generalError);
            }
        }

        public void Print()
        {
            Response.Redirect(CommonParameterNames.PageURLs.ReportViwerWithParameter + CommonParameterNames.ReportURL.CategoryDetails);
        }

        protected void dgCategories_ItemCommand(object source, Telerik.Web.UI.GridCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == CommonParameterNames.ItemCommnads.Select)
                {
                    GridDataItem item = (GridDataItem)e.Item;
                    Session[CommonParameterNames.CommonTableColumnName.Inventory.CatrgoryDetails.CategoryId] = item[CommonParameterNames.CommonTableColumnName.Inventory.CatrgoryDetails.CategoryId].Text;
                    txtCatrgory.Text = item[CommonParameterNames.CommonTableColumnName.Inventory.CatrgoryDetails.Name].Text;
                    txtDescription.Text= item[CommonParameterNames.CommonTableColumnName.Inventory.CatrgoryDetails.Description].Text;
                    chkIsActive.Checked = Convert.ToBoolean(item[CommonParameterNames.CommonTableColumnName.Inventory.CatrgoryDetails.IsActive].Text);
                    chkIsViewInNavBar.Checked = Convert.ToBoolean(item[CommonParameterNames.CommonTableColumnName.Inventory.CatrgoryDetails.IsViewInNavBar].Text);
                    txtOrderId.Text = item[CommonParameterNames.CommonTableColumnName.Inventory.CatrgoryDetails.OrderId].Text;
                    LankanBay.masterpages.admin master = (LankanBay.masterpages.admin)this.Master;
                    master.Update();

                }
                else if (e.CommandName == CommonParameterNames.ItemCommnads.Delete)
                {

                    GridDataItem item = (GridDataItem)e.Item;
                    Session[CommonParameterNames.CommonTableColumnName.Inventory.CatrgoryDetails.CategoryId] = item[CommonParameterNames.CommonTableColumnName.Inventory.CatrgoryDetails.CategoryId].Text;
                    Delete();
                }
            }
            catch (Exception)
            {
                LankanBay.masterpages.admin master = (LankanBay.masterpages.admin)this.Master;
                master.MessageBox(CommonParameterNames.MessageBoxType.ErrorMessage, CommonUserMessages.ErrorMessages.generalError);
            
            }
        }

        protected void dgCategories_NeedDataSource(object source, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
        {
            categoryDetails = new CategoryDetails();
            categoryDetails.CategoryId = 0;
            dgCategories.DataSource = categoryDetailsService.Select(categoryDetails);
        }

        protected void dgCategories_PageIndexChanged(object source, Telerik.Web.UI.GridPageChangedEventArgs e)
        {
            FillGrid();
        }

        protected void dgCategories_PageSizeChanged(object source, Telerik.Web.UI.GridPageSizeChangedEventArgs e)
        {
            FillGrid();
        }

        protected void dgCategories_SortCommand(object source, Telerik.Web.UI.GridSortCommandEventArgs e)
        {
            FillGrid();
        }


    }
}