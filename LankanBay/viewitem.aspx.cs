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
    public partial class viewitem : System.Web.UI.Page
    {
        ItemDetails itemDetails = new ItemDetails();
        ItemDetailsService itemDetailsService = new ItemDetailsService();

        ItemImageDetails itemImageDetails = new ItemImageDetails();
        ItemImageDetailsService itemImageDetailsService = new ItemImageDetailsService();

        ItemWiseTotalViewDetailsService itemWiseTotalViewDetailsService = new ItemWiseTotalViewDetailsService();
        UserWiseItemViewDetailsService userWiseItemViewDetailsService = new UserWiseItemViewDetailsService();

        DataTable dtItemDetails = new DataTable();

        private string imagePath;
        private int itemId;
        private string itemName;
        private string description;
        private int qty;
        private int qtyInHand;
        private decimal unitPrice;
        private decimal deliveryChargers;
        private decimal total;


        protected void Page_Load(object sender, EventArgs e)
        {   
            if (!IsPostBack)
            {
                UpdateItemWiseTotalViews();
                UpdateUserWiseItemViews();               
            }
        }

        private void UpdateItemWiseTotalViews()
        {
            try
            {
                if (System.Web.HttpContext.Current.Session[CommonParameterNames.LoggedUserDetails.userId] != null)
                {
                    itemDetails = new ItemDetails();
                    itemDetails.ItemId = Convert.ToInt32(Request.QueryString[0].ToString());
                    itemDetails.UserId = Convert.ToInt32(Session[CommonParameterNames.LoggedUserDetails.userId]);
                    itemWiseTotalViewDetailsService.UpdateItemWiseTotalViews(itemDetails);
                    DataBaseTransactionService.CommitTransactions();
                }
                else 
                {
                    itemDetails = new ItemDetails();
                    itemDetails.ItemId = Convert.ToInt32(Request.QueryString[0].ToString());
                    itemDetails.UserId = Convert.ToInt32(-999);
                    itemWiseTotalViewDetailsService.UpdateItemWiseTotalViews(itemDetails);
                    DataBaseTransactionService.CommitTransactions();
                }
            }
            catch (Exception)
            {
                DataBaseTransactionService.RollbackTransactions();
                LankanBay.masterpages.sitemaster master = (LankanBay.masterpages.sitemaster)this.Master;
                master.MessageBox(CommonParameterNames.MessageBoxType.WarnningMessage, CommonUserMessages.WarnningMessages.reqQtyIsGraterThanInHand);
            }
        }

        private void UpdateUserWiseItemViews()
        {
            try
            {
                if (System.Web.HttpContext.Current.Session[CommonParameterNames.LoggedUserDetails.userId] != null)
                {
                    itemDetails = new ItemDetails();
                    itemDetails.ItemId = Convert.ToInt32(Request.QueryString[0].ToString());
                    itemDetails.UserId = Convert.ToInt32(Session[CommonParameterNames.LoggedUserDetails.userId]);
                    userWiseItemViewDetailsService.UpdateUserWiseItemViews(itemDetails);
                    DataBaseTransactionService.CommitTransactions();
                }              
            }
            catch (Exception)
            {
                DataBaseTransactionService.RollbackTransactions();
                LankanBay.masterpages.sitemaster master = (LankanBay.masterpages.sitemaster)this.Master;
                master.MessageBox(CommonParameterNames.MessageBoxType.WarnningMessage, CommonUserMessages.WarnningMessages.reqQtyIsGraterThanInHand);
            }
            
        }

        protected void btnAddToCart_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                if (System.Web.HttpContext.Current.Session[CommonParameterNames.LoggedUserDetails.userId] == null)
                {
                    Session["ItemId"] = Request.QueryString[0].ToString();
                    Response.Redirect(CommonParameterNames.PageURLs.LoginPage);                 

                }
                else
                {
                    DataTable dtItemDetails = new DataTable();
                    DataTable dtItemImageDetails = new DataTable();

                    itemDetails.ItemId = Convert.ToInt32(Request.QueryString[CommonParameterNames.URLParameters.ItemId].ToString());
                    dtItemDetails = itemDetailsService.SelectThisItemDetailsForMainPage(itemDetails);

                    itemImageDetails.ItemId = itemDetails.ItemId;
                    dtItemImageDetails = itemImageDetailsService.SelectThisImageDetail(itemImageDetails);                    

                    if (Convert.ToInt32(dtItemDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Inventory.ItemDetails.QtyInHand]) >= Convert.ToInt32(txtRequestedQty.Text))
                    {
                        imagePath = dtItemImageDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Inventory.ItemImageDetails.ImagePath].ToString();
                        itemId = Convert.ToInt32(dtItemDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Inventory.ItemDetails.ItemId]);
                        itemName = dtItemDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Inventory.ItemDetails.ItemName].ToString();
                        description = dtItemDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Inventory.ItemDetails.ItemDescription].ToString();
                        qty = Convert.ToInt32(txtRequestedQty.Text.Trim());
                        qtyInHand = Convert.ToInt32(dtItemDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Inventory.ItemDetails.QtyInHand]);
                        unitPrice = Convert.ToDecimal(dtItemDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Inventory.ItemDetails.UnitPrice]);
                        deliveryChargers = Convert.ToDecimal(dtItemDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Inventory.ItemDetails.DeliveryChargers]);
                        total = (unitPrice * qty) + deliveryChargers;                     

                        ((DataTable)Session["dtCart"]).Rows.Add(imagePath,itemId, itemName, description, qty,qtyInHand, unitPrice, deliveryChargers, total);                      
                        ViewCart();
                    }

                    else
                    {
                        LankanBay.masterpages.sitemaster master = (LankanBay.masterpages.sitemaster)this.Master;
                        master.MessageBox(CommonParameterNames.MessageBoxType.WarnningMessage, CommonUserMessages.WarnningMessages.reqQtyIsGraterThanInHand);
                    }

                }

            }
            catch (Exception ex)
            {
                LankanBay.masterpages.sitemaster master = (LankanBay.masterpages.sitemaster)this.Master;
                master.MessageBox(CommonParameterNames.MessageBoxType.ErrorMessage, ex.Message.ToString());

            }
        }
            
        public void ViewCart()
        {
            LankanBay.masterpages.sitemaster master = (LankanBay.masterpages.sitemaster)this.Master;
            master.MessageBox(CommonParameterNames.MessageBoxType.MyCart, "../yourcart.aspx");
           

        }

        protected void btnBuyItNow_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                if (System.Web.HttpContext.Current.Session[CommonParameterNames.LoggedUserDetails.userId] == null)
                {
                    Session["ItemId"] = Request.QueryString[0].ToString();
                    Response.Redirect(CommonParameterNames.PageURLs.LoginPage);

                }
                else
                {
                    DataTable dtItemDetails = new DataTable();
                    DataTable dtItemImageDetails = new DataTable();

                    itemDetails.ItemId = Convert.ToInt32(Request.QueryString[CommonParameterNames.URLParameters.ItemId].ToString());
                    dtItemDetails = itemDetailsService.SelectThisItemDetailsForMainPage(itemDetails);

                    itemImageDetails.ItemId = itemDetails.ItemId;
                    dtItemImageDetails = itemImageDetailsService.SelectThisImageDetail(itemImageDetails);

                    if (Convert.ToInt32(dtItemDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Inventory.ItemDetails.QtyInHand]) >= Convert.ToInt32(txtRequestedQty.Text))
                    {
                        imagePath = dtItemImageDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Inventory.ItemImageDetails.ImagePath].ToString();
                        itemId = Convert.ToInt32(dtItemDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Inventory.ItemDetails.ItemId]);
                        itemName = dtItemDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Inventory.ItemDetails.ItemName].ToString();
                        description = dtItemDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Inventory.ItemDetails.ItemDescription].ToString();
                        qty = Convert.ToInt32(txtRequestedQty.Text.Trim());
                        qtyInHand = Convert.ToInt32(dtItemDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Inventory.ItemDetails.QtyInHand]);
                        unitPrice = Convert.ToDecimal(dtItemDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Inventory.ItemDetails.UnitPrice]);
                        deliveryChargers = Convert.ToDecimal(dtItemDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Inventory.ItemDetails.DeliveryChargers]);
                        total = (unitPrice * qty) + deliveryChargers;

                        ((DataTable)Session["dtCart"]).Rows.Add(imagePath, itemId, itemName, description, qty, qtyInHand, unitPrice, deliveryChargers, total);
                        //ViewCart();
                        Response.Redirect(CommonParameterNames.PageURLs.Checkout);
                    }

                    else
                    {
                        LankanBay.masterpages.sitemaster master = (LankanBay.masterpages.sitemaster)this.Master;
                        master.MessageBox(CommonParameterNames.MessageBoxType.WarnningMessage, CommonUserMessages.WarnningMessages.reqQtyIsGraterThanInHand);
                    }

                }

            }
            catch (Exception ex)
            {
                LankanBay.masterpages.sitemaster master = (LankanBay.masterpages.sitemaster)this.Master;
                master.MessageBox(CommonParameterNames.MessageBoxType.ErrorMessage, ex.Message.ToString());

            }
        }

        protected void lnkBtnRateSeller_Click(object sender, EventArgs e)
        {
            if (Request.QueryString != null && Request.QueryString[0].ToString().Length != 0 && Request.QueryString[0] != null)
            {
                Response.Redirect(CommonParameterNames.PageURLs.BspSellerProfile + GetSellersBSP() + "&iid=" + Request.QueryString[0].ToString());
            }
        }

        protected void lnkBtnViewOtherItems_Click(object sender, EventArgs e)
        {
           Response.Redirect(CommonParameterNames.PageURLs.Sellers_other_item + GetSellersBSP());
        }

        private int GetSellersBSP()
        {
            if (Request.QueryString[0] != null && Request.QueryString[CommonParameterNames.URLParameters.ItemId].ToString().Length != 0)
            {
                itemId = Convert.ToInt32(Request.QueryString[0].ToString());
                itemDetails.ItemId = itemId;
                dtItemDetails = itemDetailsService.SelectThisItemDetailsForMainPage(itemDetails);

            }
            else
            {
                Response.Redirect(CommonParameterNames.PageURLs.HomePage);
            }

            int bspId = Convert.ToInt32(dtItemDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Inventory.ItemDetails.BSPId].ToString());
            return bspId;
        }
        
    }
}