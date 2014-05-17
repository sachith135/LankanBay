using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using DOMAIN;
using SERVICE;
using Telerik.Web.UI;

namespace LankanBay.admin
{
    public partial class sup_additemimages : System.Web.UI.Page
    {
        ItemDetails itemDetails = new ItemDetails();
        ItemDetailsService itemDetailsService = new ItemDetailsService();

        ItemImageDetails itemImageDetails = new ItemImageDetails();
        ItemImageDetailsService itemImageDetailsService = new ItemImageDetailsService();

        string saveLocationLarge = "";
        string saveLocationSmall = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillItemDetails();
                FillGrid();
                
            }
        }

        public Size OriginalImageSize { get; set; }        //Store original image size.
        public Size NewImageSize { get; set; }

        public void ResetInputs(bool reset)
        {
            if (reset)
            {
                cmbItemName.SelectedIndex = 0;
                txtDescription.Text = ""; 
            }
        }

        private void FillGrid()
        {
            try
            {
                itemImageDetails.UserId = Convert.ToInt32(Session[CommonParameterNames.LoggedUserDetails.userId]);
                itemImageDetails.ItemId = Convert.ToInt32(cmbItemName.SelectedValue);

                dgItemImage.DataSource = null;
                dgItemImage.DataSource = itemImageDetailsService.SelectSellersItemImages(itemImageDetails);
                dgItemImage.DataBind();

                for (int i = 0; i < dgItemImage.Items.Count; i=i+2)
                {
                   ((GridDataItem)dgItemImage.Items[i+1]).Visible = false;
                   ((System.Web.UI.WebControls.Image)dgItemImage.MasterTableView.Items[i].FindControl("image")).ImageUrl = "../" + dgItemImage.Items[i]["ImagePath"].Text;

                              
                                                          
                }

            }
            catch (Exception)
            {
                LankanBay.masterpages.admin master = (LankanBay.masterpages.admin)this.Master;
                master.MessageBox(CommonParameterNames.MessageBoxType.ErrorMessage,CommonUserMessages.ErrorMessages.generalError);
            }
        }

        public void Update()
        {
            try
            {
                itemImageDetails = new ItemImageDetails();
                for (int i = 0; i < dgItemImage.Items.Count; i++)
                {
                    if (((System.Web.UI.WebControls.CheckBox)dgItemImage.MasterTableView.Items[i].FindControl("chkIsMain")).Checked)
                    {
                        itemImageDetails.ItemId = Convert.ToInt32(dgItemImage.MasterTableView.Items[i]["ItemId"].Text);
                        itemImageDetails.ItemWiseImageId = Convert.ToInt32(dgItemImage.MasterTableView.Items[i]["ItemWiseImageId"].Text);
                        itemImageDetails.IsMainImage = true;
                        itemImageDetailsService.Update(itemImageDetails);
                    }
                }

                FillGrid();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public void Insert()
        {
            Update();
        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
           
            if ((File1.PostedFile != null) && (File1.PostedFile.ContentLength > 0))
            {
                Guid uid = Guid.NewGuid();
                string fn = System.IO.Path.GetFileName(File1.PostedFile.FileName);

                saveLocationSmall = Server.MapPath("../images/items_small/") +  Convert.ToInt32(cmbItemName.SelectedValue) + "_" + uid + ".png".Trim();
                saveLocationLarge = Server.MapPath("../images/items_large/") + Convert.ToInt32(cmbItemName.SelectedValue) + "_" + uid + ".png".Trim();
                //saveLocationLarge = Server.MapPath("../images") + "\\large\\" + Convert.ToInt32(cmbItemName.SelectedValue) + "_" + uid + ".png".Trim();

                // string SaveLocation = Server.MapPath("LogoImages") + "\\" + uid + fn;
                try
                {
                    string fileExtention = File1.PostedFile.ContentType;
                    int fileLenght = File1.PostedFile.ContentLength;

                    if (fileExtention == "image/png" || fileExtention == "image/jpeg" || fileExtention == "image/x-png")
                    {
                        if (fileLenght <= 5048576)
                        {
                            System.Drawing.Bitmap bmpPostedImage = new System.Drawing.Bitmap(File1.PostedFile.InputStream);
                            System.Drawing.Image objImage = ScaleImage(bmpPostedImage, 81);
                            objImage.Save(saveLocationSmall, ImageFormat.Png);

                            System.Drawing.Bitmap bmpPostedImage2 = new System.Drawing.Bitmap(File1.PostedFile.InputStream);
                            System.Drawing.Image objImage2 = ScaleImage2(bmpPostedImage2, 81);
                            objImage2.Save(saveLocationLarge, ImageFormat.Png);


                            itemImageDetails.ImagePath = "images/items_small/" + Convert.ToInt32(cmbItemName.SelectedValue) + "_" + uid + ".png".Trim();
                            itemImageDetails.IsMainImage = true;
                            itemImageDetails.ItemId = Convert.ToInt32(cmbItemName.SelectedValue);
                            itemImageDetails.ItemWiseImageId = 1;
                            itemImageDetails.IsLargeImage = false;
                            itemImageDetails.UserId = Convert.ToInt32(Session[CommonParameterNames.LoggedUserDetails.userId]);
                            itemImageDetailsService.Insert(itemImageDetails);

                            itemImageDetails.ImagePath = "images/items_large/" + Convert.ToInt32(cmbItemName.SelectedValue) + "_" + uid + ".png".Trim();
                            itemImageDetails.IsMainImage = true;
                            itemImageDetails.ItemId = Convert.ToInt32(cmbItemName.SelectedValue);
                            itemImageDetails.ItemWiseImageId = 1;
                            itemImageDetails.IsLargeImage = true;
                            itemImageDetails.UserId = Convert.ToInt32(Session[CommonParameterNames.LoggedUserDetails.userId]);
                            itemImageDetailsService.Insert(itemImageDetails);

                            DataBaseTransactionService.CommitTransactions();
                            FillGrid();

                            LankanBay.masterpages.admin master = (LankanBay.masterpages.admin)this.Master;
                            master.MessageBox(CommonParameterNames.MessageBoxType.SuccessMessage, CommonUserMessages.SuccessfulMessages.imageUploadSuccessful);
                        }
                        else
                        {
                            LankanBay.masterpages.admin master = (LankanBay.masterpages.admin)this.Master;
                            master.MessageBox(CommonParameterNames.MessageBoxType.WarnningMessage, CommonUserMessages.WarnningMessages.imageSizeTooLarge);
                        }
                    }
                    else
                    {
                        LankanBay.masterpages.admin master = (LankanBay.masterpages.admin)this.Master;
                        master.MessageBox(CommonParameterNames.MessageBoxType.WarnningMessage, CommonUserMessages.ErrorMessages.fileFormatIncorrect);
                    }                    
                    
                }
                catch (Exception ex)
                {
                    LankanBay.masterpages.admin master = (LankanBay.masterpages.admin)this.Master;
                    master.MessageBox(CommonParameterNames.MessageBoxType.ErrorMessage, CommonUserMessages.ErrorMessages.generalError);
                }
            }

        }

        public static System.Drawing.Image ScaleImage(System.Drawing.Image image, int maxHeight)
        {
            var ratio = (double)maxHeight / image.Height;
            var newWidth = (int)411; //(int)(image.Width * ratio);
            var newHeight = (int)274; //(int)(image.Height * ratio);
            var newImage = new Bitmap(newWidth, newHeight);
            using (var g = Graphics.FromImage(newImage))
            {
                g.DrawImage(image, 0, 0, newWidth, newHeight);
            }
            return newImage;
        }

        public static System.Drawing.Image ScaleImage2(System.Drawing.Image image, int maxHeight)
        {
            var ratio = (double)maxHeight / image.Height;
            var newWidth = (int)1280; //(int)(image.Width * ratio);
            var newHeight = (int)854; //(int)(image.Height * ratio);
            var newImage = new Bitmap(newWidth, newHeight);
            using (var g = Graphics.FromImage(newImage))
            {
                g.DrawImage(image, 0, 0, newWidth, newHeight);
            }
            return newImage;
        }

        private void FillItemDetails()
        {
            try
            {
                cmbItemName.Items.Clear();
                cmbItemName.Items.Insert(0, new RadComboBoxItem("--------------- Select ---------------","0"));
                itemDetails.UserId = Convert.ToInt32(Session[CommonParameterNames.LoggedUserDetails.userId]);
                cmbItemName.DataSource = itemDetailsService.SelectSellersActiveItems(itemDetails);
                cmbItemName.DataTextField = CommonParameterNames.CommonTableColumnName.Inventory.ItemDetails.ItemName;
                cmbItemName.DataValueField = CommonParameterNames.CommonTableColumnName.Inventory.ItemDetails.ItemId;
                cmbItemName.DataBind();
            }
            catch (Exception)
            {
                LankanBay.masterpages.admin master = (LankanBay.masterpages.admin)this.Master;
                master.MessageBox(CommonParameterNames.MessageBoxType.ErrorMessage,CommonUserMessages.ErrorMessages.generalError);
            }
        }

        protected void cmbItemName_SelectedIndexChanged(object o, Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs e)
        {
            try
            {
                itemDetails.ItemId = Convert.ToInt32(cmbItemName.SelectedValue);
                txtDescription.Text = itemDetailsService.SelectSellersItems(itemDetails).Rows[0][CommonParameterNames.CommonTableColumnName.Inventory.ItemDetails.ItemDescription].ToString();
                FillGrid();
            }
            catch (Exception)
            {
                LankanBay.masterpages.admin master = (LankanBay.masterpages.admin)this.Master;
                master.MessageBox(CommonParameterNames.MessageBoxType.ErrorMessage,CommonUserMessages.ErrorMessages.generalError);
            }
        }
    }
}