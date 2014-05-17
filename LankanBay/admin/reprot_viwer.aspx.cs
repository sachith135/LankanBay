using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DOMAIN;
using SERVICE;

namespace LankanBay.admin
{
    public partial class reprot_viwer : System.Web.UI.Page
    {
        String pageName = "";
        String userName = "";
        DataTable dtReportDataTable = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }

            pageName = Request.QueryString[0].ToString().Trim();
            userName = "Created By : "+Session[CommonParameterNames.LoggedUserDetails.username].ToString();



            if (pageName == CommonParameterNames.ReportURL.BSPDetails)
            {
                BusinessPartnerTypeDetails businessPartnerTypeDetails = new BusinessPartnerTypeDetails();
                BusinessPartnerReferenceDetails businessPartnerReferenceDetails = new BusinessPartnerReferenceDetails();
                BusinessPartnerReferenceDetailsService businessPartnerReferenceDetailsService = new BusinessPartnerReferenceDetailsService();
                dtReportDataTable = businessPartnerReferenceDetailsService.Select(businessPartnerReferenceDetails, businessPartnerTypeDetails);

                admin.reports.rpt_BusinessPartnerReferenceDetails rpt_BusinessPartnerReferenceDetails = new admin.reports.rpt_BusinessPartnerReferenceDetails();
                rpt_BusinessPartnerReferenceDetails.Database.Tables[CommonParameterNames.ReportDataTables.dtBusinessPartnerDetails].SetDataSource(dtReportDataTable);
                rpt_BusinessPartnerReferenceDetails.DataDefinition.FormulaFields[CommonParameterNames.LoggedUserDetails.username].Text = '"' + userName + '"';


                SetReportToReportViwer(rpt_BusinessPartnerReferenceDetails);
            }

            else if (pageName == CommonParameterNames.ReportURL.CategoryDetails)
            {
                CategoryDetails categoryDetails = new CategoryDetails();
                CategoryDetailsService categoryDetailsService  =  new CategoryDetailsService();
                dtReportDataTable = categoryDetailsService.Select(categoryDetails);

                admin.reports.rpt_CategoryDetails rpt_CategoryDetails = new admin.reports.rpt_CategoryDetails();
                rpt_CategoryDetails.Database.Tables[CommonParameterNames.ReportDataTables.dtCategoryDetails].SetDataSource(dtReportDataTable);
                rpt_CategoryDetails.DataDefinition.FormulaFields[CommonParameterNames.LoggedUserDetails.username].Text = '"' + userName + '"';


                SetReportToReportViwer(rpt_CategoryDetails);
            }

            else if (pageName == CommonParameterNames.ReportURL.SubCategoryDetails)
            {
                SubCategoryDetails subCategoryDetails = new SubCategoryDetails();
                SubCategoryDetailsService subCategoryDetailsService = new SubCategoryDetailsService();
                dtReportDataTable = subCategoryDetailsService.Select(subCategoryDetails);

                admin.reports.rpt_SubCategoryDetails rpt_SubCategoryDetails = new admin.reports.rpt_SubCategoryDetails();
                rpt_SubCategoryDetails.Database.Tables[CommonParameterNames.ReportDataTables.dtSubCategoryDetails].SetDataSource(dtReportDataTable);
                rpt_SubCategoryDetails.DataDefinition.FormulaFields[CommonParameterNames.LoggedUserDetails.username].Text = '"' + userName + '"';


                SetReportToReportViwer(rpt_SubCategoryDetails);
            }

            else if (pageName == CommonParameterNames.ReportURL.BusinessPartnerAddressDetails)
            {
                BusinessPartnerAddress businessPartnerAddress = new BusinessPartnerAddress();
                BusinessPartnerAddressService businessPartnerAddressService = new BusinessPartnerAddressService();
                dtReportDataTable = businessPartnerAddressService.Select(businessPartnerAddress);

                admin.reports.rpt_BusinessPartnerAddressDetails rpt_BusinessPartnerAddressDetails = new admin.reports.rpt_BusinessPartnerAddressDetails();
                rpt_BusinessPartnerAddressDetails.Database.Tables[CommonParameterNames.ReportDataTables.dtBusinessPartnerAddressDetails].SetDataSource(dtReportDataTable);
                rpt_BusinessPartnerAddressDetails.DataDefinition.FormulaFields[CommonParameterNames.LoggedUserDetails.username].Text = '"' + userName + '"';


                SetReportToReportViwer(rpt_BusinessPartnerAddressDetails);
            }

            else if (pageName == CommonParameterNames.ReportURL.ItemDetails)
            {
                ItemDetails itemDetails = new ItemDetails();
                ItemDetailsService itemDetailsService = new ItemDetailsService();
                dtReportDataTable = itemDetailsService.SelectSellersItems(itemDetails);

                admin.reports.rpt_ItemDetails rpt_ItemDetails = new admin.reports.rpt_ItemDetails();
                rpt_ItemDetails.Database.Tables[CommonParameterNames.ReportDataTables.dtItemDetails].SetDataSource(dtReportDataTable);
                rpt_ItemDetails.DataDefinition.FormulaFields[CommonParameterNames.LoggedUserDetails.username].Text = '"' + userName + '"';


                SetReportToReportViwer(rpt_ItemDetails);
            }

            else if (pageName == CommonParameterNames.ReportURL.UserDetails)
            {
                UserDetails userDetails = new UserDetails();
                UserDetailsService userDetailsService = new UserDetailsService();
                dtReportDataTable = userDetailsService.Select(userDetails);

                admin.reports.rpt_UserDetails rpt_UserDetails = new admin.reports.rpt_UserDetails();
                rpt_UserDetails.Database.Tables[CommonParameterNames.ReportDataTables.dtUserDetails].SetDataSource(dtReportDataTable);
                rpt_UserDetails.DataDefinition.FormulaFields[CommonParameterNames.LoggedUserDetails.username].Text = '"' + userName + '"';


                SetReportToReportViwer(rpt_UserDetails);
            }

            else if (pageName == CommonParameterNames.ReportURL.ItemPurchasingFeedbackTypeDetails)
            {
                ItemPurchasingFeedbackTypeDetails itemPurchasingFeedbackTypeDetails = new ItemPurchasingFeedbackTypeDetails();
                ItemPurchasingFeedbackTypeDetailsService itemPurchasingFeedbackTypeDetailsService = new ItemPurchasingFeedbackTypeDetailsService();
                dtReportDataTable = itemPurchasingFeedbackTypeDetailsService.Select(itemPurchasingFeedbackTypeDetails);

                admin.reports.rpt_ItemPurchasingFeedbackTypeDetails rpt_ItemPurchasingFeedbackTypeDetails = new admin.reports.rpt_ItemPurchasingFeedbackTypeDetails();
                rpt_ItemPurchasingFeedbackTypeDetails.Database.Tables[CommonParameterNames.ReportDataTables.dtItemPurchasingFeedbackTypeDetails].SetDataSource(dtReportDataTable);
                rpt_ItemPurchasingFeedbackTypeDetails.DataDefinition.FormulaFields[CommonParameterNames.LoggedUserDetails.username].Text = '"' + userName + '"';


                SetReportToReportViwer(rpt_ItemPurchasingFeedbackTypeDetails);
            }

            else if (pageName == CommonParameterNames.ReportURL.ItemPurchasingFeedbackDetails)
            {
                ItemPurchasingFeedbackDetails itemPurchasingFeedbackDetails = new ItemPurchasingFeedbackDetails();
                ItemPurchasingFeedbackDetailsService itemPurchasingFeedbackDetailsService = new ItemPurchasingFeedbackDetailsService();
                dtReportDataTable = itemPurchasingFeedbackDetailsService.SelectItemPerchasingFeedbackDetails(itemPurchasingFeedbackDetails);

                admin.reports.rpt_ItemPurchasingFeedbackDetails rpt_ItemPurchasingFeedbackDetails = new admin.reports.rpt_ItemPurchasingFeedbackDetails();
                rpt_ItemPurchasingFeedbackDetails.Database.Tables[CommonParameterNames.ReportDataTables.dtItemPurchasingFeedbackDetails].SetDataSource(dtReportDataTable);
                rpt_ItemPurchasingFeedbackDetails.DataDefinition.FormulaFields[CommonParameterNames.LoggedUserDetails.username].Text = '"' + userName + '"';


               // SetReportToReportViwer(rpt_ItemPurchasingFeedbackDetails);
            }

        }


        private void SetReportToReportViwer(object reportName)
        {
            //CrystalReportViewer1.ReportSource = reportName;
            //CrystalReportViewer1.ToolPanelView = CrystalDecisions.Web.ToolPanelViewType.None;
            //CrystalReportViewer1.HasToggleParameterPanelButton = false;
            //CrystalReportViewer1.HasToggleGroupTreeButton = false;
        }
    }

}