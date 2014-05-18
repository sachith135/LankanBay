using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOMAIN
{
    public static class CommonParameterNames
    {
        public static class Curruncy
        {
            public static string LKR = "LKR";
        }

        public static class ItemCommnads
        {
            
            public static string Select = "Select";
            public static string Delete = "Delete";
        }

        public static class MessageBoxType
        {
            public static string SuccessMessage = "SuccessMessage";
            public static string ErrorMessage = "ErrorMessage";
            public static string QuestionMessage = "QuestionMessage";
            public static string InformationMessage = "InformationMessage";
            public static string WarnningMessage = "WarnningMessage";

            public static string MyCart = "MyCart";
            public static string CusSupport = "CusSupport";
        }

        public static class PageURLs
        {
            public static string AdminMainPage = "admin/sup_additem.aspx";
            public static string ItemSearch = "search.aspx?keywords=";
            public static string Default = "Default.aspx";
            public static string HomePage = "home.aspx";
            public static string ViewItemPageWithParameters = "viewitem.aspx?iid=";
            public static string CategoryPage = "category.aspx";
            public static string CategoryPageWithParameters = "category.aspx?cid=";
            public static string SubCategoryWithParameter = "subcategory.aspx?scid=";
            public static string LoginPage = "login.aspx";
            public static string Checkout = "checkout.aspx";
            public static string ReportViwerWithParameter = "reprot_viwer.aspx?p=";
            public static string BspSellerProfile = "bsp_seller_profile.aspx?id=";
            public static string BspCustomerProfile = "bsp_customer_profile.aspx?id=";
            public static string Sellers_other_item = "sellers_other_item.aspx?id=";
        }

        public static class ReportURL
        {
            public static string BSPDetails = "BSPDetails";
            public static string CategoryDetails = "CategoryDetails";
            public static string SubCategoryDetails = "SubCategoryDetails";
            public static string BusinessPartnerAddressDetails = "BusinessPartnerAddressDetails";
            public static string ItemDetails = "ItemDetails";
            public static string UserDetails = "UserDetails";
            public static string ItemPurchasingFeedbackTypeDetails = "ItemPurchasingFeedbackTypeDetails";
            public static string ItemPurchasingFeedbackDetails = "ItemPurchasingFeedbackDetails";
        }

        public static class ReportDataTables
        {
            public static string dtBusinessPartnerDetails = "dtBusinessPartnerDetails";
            public static string dtCategoryDetails = "dtCategoryDetails";
            public static string dtSubCategoryDetails = "dtSubCategoryDetails";
            public static string dtBusinessPartnerAddressDetails = "dtBusinessPartnerAddressDetails";
            public static string dtItemDetails = "dtItemDetails";
            public static string dtUserDetails = "dtUserDetails";
            public static string dtItemPurchasingFeedbackTypeDetails = "dtItemPurchasingFeedbackTypeDetails";
            public static string dtItemPurchasingFeedbackDetails = "dtItemPurchasingFeedbackDetails";
        }

        public static class URLParameters
        {
            public static string ItemId = "iid";
            public static string CategoryId = "cid";
            public static string SubCategoryId = "scid";
            public static string IsFromLoginPage = "isFromLoginPage";
        }

        public static class CommonTableColumnName
        {
            public static class Business_Partners
            {
                public static class Address_Catogory_Details
                {
                    public const string AddressCatId = "AddressCatId";
                    public const string AddressCategory = "AddressCategory";
                    public const string IsActive = "IsActive";
                    public const string CreatedUserId = "CreatedUserId";
                    public const string ModifiedUserId = "ModifiedUserId";
                    public const string CreatedDateTime = "CreatedDateTime";
                    public const string ModifiedDateTime = "ModifiedDateTime";
                }
                public static class BusinessPartnerAddress
                {
                    public const string AddressId = "AddressId";
                    public const string BSPId = "BSPId";
                    public const string AddressCatId = "AddressCatId";
                    public const string AddressLine01 = "AddressLine01";
                    public const string AddressLine02 = "AddressLine02";
                    public const string AddressLine03 = "AddressLine03";
                    public const string City = "City";
                    public const string State = "State";
                    public const string CountryId = "CountryId";
                    public const string IsCurrentMail = "IsCurrentMail";
                    public const string IsShippingMail = "IsShippingMail";
                    public const string CreatedUserId = "CreatedUserId";
                    public const string ModifiedUserId = "ModifiedUserId";
                    public const string CreatedDateTime = "CreatedDateTime";
                    public const string ModifiedDateTime = "ModifiedDateTime";
                }
                public static class BusinessPartnerReference
                {
                    public const string BSPId = "BSPId";
                    public const string BSPTypeId = "BSPTypeId";
                    public const string BSPCode = "BSPCode";
                    public const string FirstName = "FirstName";
                    public const string FullName = "FullName";
                    public const string LastName = "LastName";
                    public const string PrimaryEmail = "PrimaryEmail";
                    public const string PrimaryContactNo = "PrimaryContactNo";
                    public const string Fax = "Fax";
                    public const string IsActive = "IsActive";
                    public const string CreatedUserId = "CreatedUserId";
                    public const string ModifiedUserId = "ModifiedUserId";
                    public const string CreatedDateTime = "CreatedDateTime";
                    public const string ModifiedDateTime = "ModifiedDateTime";
                    public const string CompleteAddress = "CompleteAddress";

                }
                public static class BusinessPartnerTypeDetails
                {
                    public const string BSPTypeId = "BSPTypeId";
                    public const string Description = "Description";
                    public const string BSPShortCode = "BSPShortCode";
                    public const string IsActive = "IsActive";
                    public const string CreatedUserId = "CreatedUserId";
                    public const string ModifiedUserId = "ModifiedUserId";
                    public const string CreatedDateTime = "CreatedDateTime";
                    public const string ModifiedDateTime = "ModifiedDateTime";
                }
                public static class BusinessPartnerWiseEmailDetails
                {
                    public const string BusinessPartnersWiseEmailId = "BusinessPartnersWiseEmailId";
                    public const string EmailQueueId = "EmailQueueId";
                    public const string ReceiverBSPId = "ReceiverBSPId";
                    public const string SenderBSPId = "SenderBSPId";
                    public const string Status = "Status";
                    public const string SenderUserId = "SenderUserId";
                    public const string SendDateTime = "SendDateTime";
                }
                public static class BusinessPartnerWiseSMSQueue
                {
                    public const string BusinessPartnerWiseSMSQueueId = "BusinessPartnerWiseSMSQueueId";
                    public const string SMSQueueId = "SMSQueueId";
                    public const string ReceiversBSPId = "ReceiversBSPId";
                    public const string SendersUserId = "SendersUserId";
                    public const string SendDateTime = "SendDateTime";
                }
                public static class CountryDetails
                {
                    public const string CountryId = "CountryId";
                    public const string CountryName = "CountryName";
                    public const string IsActive = "IsActive";
                    public const string CreatedUserId = "CreatedUserId";
                    public const string ModifiedUserId = "ModifiedUserId";
                    public const string CreatedDateTime = "CreatedDateTime";
                    public const string ModifiedDateTime = "ModifiedDateTime";

                }
                public static class EmailQueue
                {
                    public const string EmailId = "EmailId";
                    public const string EmailTypeId = "EmailTypeId";
                    public const string Subject = "Subject";
                    public const string Body = "Body";
                }
                public static class EmailTypes
                {
                    public const string EmailTypeId = "EmailTypeId";
                    public const string EmailType = "EmailType";
                    public const string IsActive = "IsActive";
                    public const string CreatedUserId = "CreatedUserId";
                    public const string ModifiedUserId = "ModifiedUserId";
                    public const string CreatedDateTime = "CreatedDateTime";
                    public const string ModifiedDateTime = "ModifiedDateTime";
                }
                public static class PasswordResetQuestions
                {
                    public const string PasswordResetQuestionId = "PasswordResetQuestionId";
                    public const string PasswordResetQuestion = "PasswordResetQuestion";
                    public const string IsActive = "IsActive";
                    public const string CreatedUserId = "CreatedUserId";
                    public const string ModifiedUserId = "ModifiedUserId";
                    public const string CreatedDateTime = "CreatedDateTime";
                    public const string ModifiedDateTime = "ModifiedDateTime";
                }
                public static class SMSQueueDetails
                {
                    public const string SMSQueueId = "SMSQueueId";
                    public const string SMSBody = "SMSBody";
                }
                public static class UserAccess
                {
                    public const string UserAccessId = "UserAccessId";
                    public const string UserId = "UserId";
                    public const string AccsessGrantedAreas = "AccsessGrantedAreas";
                    public const string AccessGrantedPages = "AccessGrantedPages";
                    public const string CreatedUserId = "CreatedUserId";
                    public const string ModifiedUserId = "ModifiedUserId";
                    public const string CreatedDateTime = "CreatedDateTime";
                    public const string ModifiedDateTime = "ModifiedDateTime";
                }
                public static class UserDetails
                {

                    public const string UserId = "UserId";
                    public const string BSPId = "BSPId";
                    public const string Username = "Username";
                    public const string Password = "Password";
                    public const string ResetPwQuestionId = "ResetPwQuestionId";
                    public const string ResetPwQuestionAnswer = "ResetPwQuestionAnswer";
                    public const string IsActive = "IsActive";
                    public const string IsLocked = "IsLocked";
                    public const string CreatedUserId = "CreatedUserId";
                    public const string ModifiedUserId = "ModifiedUserId";
                    public const string CreatedDateTime = "CreatedDateTime";
                    public const string ModifiedDateTime = "ModifiedDateTime";
                    public const string BSPShortCode = "BSPShortCode";
                }
            }
            public static class Feedback
            {
                public static class FeedbackDetails
                {
                    public const string FeedbackId = "FeedbackId";
                    public const string FeedbackStatusId = "FeedbackStatusId";
                    public const string Feedback = "Feedback";
                    public const string DateTime = "DateTime";
                }
                public static class FeedbackStatusDetails
                {
                    public const string ToolTip = "ToolTip";
                    public const string Image = "Image";
                    public const string FeedbackStatusId = "FeedbackStatusId";
                    public const string FeedbackStatus = "FeedbackStatus";
                    public const string IsActive = "IsActive";
                    public const string CreatedUserId = "CreatedUserId";
                    public const string ModifiedUserId = "ModifiedUserId";
                    public const string CreatedDateTime = "CreatedDateTime";
                    public const string ModifiedDateTime = "ModifiedDateTime";
                }

                public static class ItemPurchasingFeedbackDetails
                {
                    public static string BspName = "BSPName";
                    public static string BSPShortCode = "BSPShortCode";

                    public static string PostingPositiveFeedback = "PostingPositiveFeedback";
                    public static string DeliveryPositiveFeedback = "DeliveryPositiveFeedback";
                    public static string QualityPositiveFeedback = "QualityPositiveFeedback";
                    public static string PostingNegetiveFeedback = "PostingNegetiveFeedback";
                    public static string ItemDeliveryNegetiveFeedback = "ItemDeliveryNegetiveFeedback";
                    public static string ItemQualityNegetiveFeedback = "ItemQualityNegetiveFeedback";
                    public static string TotalPositiveFeedback = "TotalPositiveFeedback";
                    public static string TotalNegetiveFeedback = "TotalNegetiveFeedback";

                    public static string SellerTotalPositiveFeedback = "SellerTotalPositiveFeedback";
                    public static string SellerTotalNegetiveFeedback = "SellerTotalNegetiveFeedback";
                }

                public static class ItemPurchasingFeedbackTypeDetails
                {
                    public const string ItemPurchasingFeedbackTypeId = "ItemPurchasingFeedbackTypeId";
                    public const string ItemPurchasingFeedbackType = "ItemPurchasingFeedbackType";
                    public const string IsActive = "IsActive";
                    public const string CreatedUserId = "CreatedUserId";
                    public const string ModifiedUserId = "ModifiedUserId";
                    public const string CreatedDateTime = "CreatedDateTime";
                    public const string ModifiedDateTime = "ModifiedDateTime";
                }
                public static class ItemWiseTotalViewDetails
                {
                    public const string ItemWiseTotalViewId = "ItemWiseTotalViewId";
                    public const string ItemPurchasingFeedbackType = "ItemId";
                    public const string TotalViews = "TotalViews";
                    public const string LastViewdDateTime = "LastViewdDateTime";
                }
                public static class UserWiseItemViewDetails
                {
                    public const string ItemWiseViewId = "ItemWiseViewId";
                    public const string ItemId = "ItemId";
                    public const string UserId = "UserId";
                    public const string ViewedDateTime = "ViewedDateTime";
                }
            }
            public static class Inventory
            {
                public static class CatrgoryDetails
                {
                    public static string OrderId = "OrderId";
                    public static string CategoryId = "CategoryId";
                    public static string Name = "Name";
                    public static string Description = "Description";
                    public static string IsViewInNavBar = "IsViewInNavBar";
                    public static string IsActive = "IsActive";
                    public static string CreatedUserId = "CreatedUserId";
                    public static string CreatedDateTime = "CreatedDateTime";
                    public static string ModifiedUserId = "ModifiedUserId";
                    public static string ModifiedDateTime = "ModifiedDateTime";
                }

                public static class DeleveryOptionDetails
                {
                    public const string DeleveryOptionId = "DeleveryOptionId";
                    public const string DeleveryOption = "DeleveryOption";
                    public const string DeleveryChargersApply = "DeleveryChargersApply";
                    public const string IsActive = "IsActive";
                    public const string CreatedUserId = "CreatedUserId";
                    public const string ModifiedUserId = "ModifiedUserId";
                    public const string CreatedDateTime = "CreatedDateTime";
                    public const string ModifiedDateTime = "ModifiedDateTime";

                }
                public static class ItemConditionDetails
                {
                    public const string ItemConditionId = "ItemConditionId";
                    public const string ItemCondition = "ItemCondition";
                    public const string IsActive = "IsActive";
                    public const string CreatedUserId = "CreatedUserId";
                    public const string ModifiedUserId = "ModifiedUserId";
                    public const string CreatedDateTime = "CreatedDateTime";
                    public const string ModifiedDateTime = "ModifiedDateTime";
                }

                public static class ItemDetails
                {
                    public static string ImagePath = "ImagePath";
                    public static string ItemId = "ItemId";
                    public static string SubCategoryId = "SubCategoryId";
                    public static string SubCategory = "SubCategory";
                    public static string CategoryId = "CategoryId";
                    public static string Category = "Category";
                    public static string BSPId = "BSPId";
                    public static string BSPName = "BSPName";
                    public static string ItemName = "ItemName";
                    public static string ItemDescription = "ItemDescription";
                    public static string QtyInHand = "QtyInHand";
                    public static string UnitPrice = "UnitPrice";
                    public static string DeliveryChargers = "DeliveryChargers";
                    public static string DelivaryDescription = "DelivaryDescription";
                    public static string ReturnsDescription = "ReturnsDescription";
                    public static string PurchasingMethodId = "PurchasingMethodId";
                    public static string IsBuyerProtection = "IsBuyerProtection";
                    public static string PurchasingMethod = "PurchasingMethod";
                    public static string ItemConditionId = "ItemConditionId";
                    public static string Condition = "Condition";
                    public static string DeleveryOptionId = "DeleveryOptionId";
                    public static string DeliveryOption = "DeliveryOption";
                    public static string WarrantyDescription = "WarrantyDescription";
                    public static string IsViewInNavBar = "IsViewInNavBar";
                    public static string IsActive = "IsActive";
                    public static string CreatedUserId = "CreatedUserId";
                    public static string CreatedDateTime = "CreatedDateTime";
                    public static string ModifiedUserId = "ModifiedUserId";
                    public static string ModifiedDateTime = "ModifiedDateTime";
                    public static string WebPageURL = "WebPageURL";
                    public static string TotalViews = "TotalViews";
                    public static string ItemRatings = "ItemRatings";
                }

                public static class ItemImageDetails
                {
                    public static string ItemWiseImageId = "ItemWiseImageId";
                    public static string ItemId = "ItemId";
                    public static string ImageTypeId = "ImageTypeId";
                    public static string ImagePath = "ImagePath";
                    public static string CreatedUserId = "CreatedUserId";
                    public static string CreatedDateTime = "CreatedDateTime";
                    public static string ModifiedUseId = "ModifiedUseId";
                    public static string ModifiedDateTime = "ModifiedDateTime";
                }

                public static class ItemImageTypeDetails
                {
                    public const string ItemImageTypeId = "ItemImageTypeId";
                    public const string ItemImageType = "ItemImageType";
                    public const string IsActive = "IsActive";
                    public const string CreatedUserId = "CreatedUserId";
                    public const string ModifiedUserId = "ModifiedUserId";
                    public const string CreatedDateTime = "CreatedDateTime";
                    public const string ModifiedDateTime = "ModifiedDateTime";
                }

                public static class ItemInventoryDetails
                {
                    public const string InventoryLogId = "InventoryLogId";
                    public const string ItemId = "ItemId";
                    public const string QtyInHand = "QtyInHand";
                    public const string AlertQty = "AlertQty";
                    public const string CreatedUserId = "CreatedUserId";
                    public const string ModifiedUserId = "ModifiedUserId";
                    public const string CreatedDateTime = "CreatedDateTime";
                    public const string ModifiedDateTime = "ModifiedDateTime";
                }
                
                public static class ItemPurchasingMethodDetails
                {
                    public const string ItemPurchasingMethodId = "ItemPurchasingMethodId";
                    public const string ItemPurchasingMethod = "ItemPurchasingMethod";
                    public const string IsActive = "IsActive";
                    public const string CreatedUserId = "CreatedUserId";
                    public const string ModifiedUserId = "ModifiedUserId";
                    public const string CreatedDateTime = "CreatedDateTime";
                    public const string ModifiedDateTime = "ModifiedDateTime";
                }

                public static class SubCategoryDetails
                {
                    public static string SubCategoryId = "SubCategoryId";
                    public static string CategoryId = "CategoryId";
                    public static string Category = "Category";
                    public static string OrderId = "OrderId";
                    public static string Name = "Name";
                    public static string Description = "Description";
                    public static string IsViewInNavBar = "IsViewInNavBar";
                    public static string IsActive = "IsActive";
                    public static string CreatedUserId = "CreatedUserId";
                    public static string CreatedDateTime = "CreatedDateTime";
                    public static string ModifiedUserId = "ModifiedUserId";
                    public static string ModifiedDateTime = "ModifiedDateTime";
                }

                public static class UserWiseItemPurchaseDetails
                {
                    public const string UserWiseItemPurchasingId = "UserWiseItemPurchasingId";
                    public const string CartId = "CartId";
                    public const string ItemId = "ItemId";
                    public const string UserId = "UserId";
                    public const string ItemQty = "ItemQty";
                    public const string PurchasedDateTime = "PurchasedDateTime";
                }

                public static class PaymentOptions
                {
                    public static string PaymentGateWayId = "PaymentGateWayId";
                    public static string Name = "Name";
                    public static string LogoPath = "LogoPath";
                    public static string Description = "Description";
                    public static string IsActive = "IsActive";
                    public static string CreatedUserId = "CreatedUserId";
                    public static string CreatedDateTime = "CreatedDateTime";
                    public static string ModifiedUserId = "ModifiedUserId";
                    public static string ModifiedDateTime = "ModifiedDateTime";
                }

            }
        }

        public static class Operations
        {
            public const string Insert = "I";
            public const string Update = "U";
        }

        public static class LoggedUserDetails
        {
            public static string userId = "userId";
            public static string username = "username";
            public static string fullname = "fullname";
            public static string loggingAttempts = "loggingAttempts";
            public static string bspId = "bspId";
            public static string bspShortCode = "bspShortCode";
        }
    }
}

