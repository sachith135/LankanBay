using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DATA.COMMON
{
    public static class WellKnownParameters
    {
        public static class BusinessPartner
        {
            public static class BusinessPartnerNotificationsDetails
            {
                public const string NotificationTypeId = "@NotificationTypeId";
                public const string ReceiverBSPId = "@ReceiverBSPId";
                public const string BusinessPartnersWiseNotificationId = "@BusinessPartnersWiseNotificationId";
                public const string UserId = "@UserId";
            }

            public static class BusinessPartnerAddress
            {
                public const string AddressId = "@AddressId";
                public const string BSPId = "@BSPId";
                public const string AddressCatId = "@AddressCatId";
                public const string AddressLine01 = "@AddressLine01";
                public const string AddressLine02 = "@AddressLine02";
                public const string AddressLine03 = "@AddressLine03";
                public const string City = "@City";
                public const string State = "@State";
                public const string ZipCode = "@ZipCode";
                public const string IsCurrentMail = "@IsCurrentMail";
                public const string IsShippingMail = "@IsShippingMail";
                public const string UserId = "@UserId";
                public const string Operation = "@Operation";
          
            }

            public static class AddressCatogoryDetails
            {
                public const string AddressCatId = "@AddressCatId";
                public const string AddressCategory = "@AddressCategory";
                public const string IsActive = "@IsActive";
                public const string UserId = "@UserId";
                public const string Operation = "@Operation";               
            }

            public static class BusinessPartnerReference
            {
                public const string BSPId = "@BSPId";
                public const string BSPTypeId = "@BSPTypeId";
                public const string BSPCode = "@BSPCode";
                public const string FirstName = "@FirstName";
                public const string LastName = "@LastName";
                public const string PrimaryEmail = "@PrimaryEmail";
                public const string PrimaryContactNo = "@PrimaryContactNo";
                public const string Fax = "@Fax";
                public const string IsActive = "@IsActive";
                public const string UserId = "@UserId";
                public const string Operation = "@Operation";
            }

            public static class BusinessPartnerTypeDetails
            {
                public const string BSPTypeId = "@BSPTypeId";
                public const string Description = "@Description";
                public const string BSPShortCode = "@BSPShortCode";
                public const string IsActive = "@IsActive";
                public const string UserId = "@UserId";
                public const string Operation = "@Operation";
            }

            public static class UserDetails
            {
                public const string UserId = "@UserId";
                public const string BSPId = "@BSPId";
                public const string CreatedOrModifiedUserId = "@CreatedOrModifiedUserId";
                public const string ResetPwQuestionId = "@ResetPwQuestionId";
                public const string ResetPwQuestionAnswer = "@ResetPwQuestionAnswer";

                public const string Username = "@Username";
                public const string Password = "@Password";
                public const string IsActive = "@IsActive";
                public const string IsLocked = "@IsLocked";
                public const string Operation = "@Operation";
            }
        }

        public static class Inventory
        {
            public static class DeleveryOptionsDetails
            {
                public static string DeleveryOptionId = "@DeleveryOptionId";
                public static string DeleveryOption = "@DeleveryOption";
                public static string DeleveryChargersApply = "@DeleveryChargersApply";
                public static string IsActive = "@IsActive";
                public static string UserId = "@UserId";
                public const string Operation = "@Operation";
            }

            public static class CatrgoryDetails
            {
                public static string CategoryId = "@CategoryId";
                public static string Name = "@Name";
                public static string Description = "@Description";
                public static string IsViewInNavBar = "@IsViewInNavBar";
                public static string IsActive = "@IsActive";
                public static string UserId = "@UserId";
                public static string OrderId = "@OrderId";
                public const string Operation = "@Operation";
            }

            public static class SubCategoryDetails
            {
                public static string CategoryId = "@CategoryId";
                public static string SubCategoryId = "@SubCategoryId";              
                public static string Name = "@Name";
                public static string Description = "@Description";
                public static string IsViewInNavBar = "@IsViewInNavBar";
                public static string IsActive = "@IsActive";
                public static string UserId = "@UserId";            
                public const string Operation = "@Operation";
                public const string OrderId = "@OrderId";
            }

            public static class ItemDetails
            {
                public static string ItemId = "@ItemId";
                public static string SubCategoryId = "@SubCategoryId";
                public static string CategoryId = "@CategoryId";
                public static string BSPId = "@BSPId";
                public const string Operation = "@Operation";
                public static string ItemName = "@Name";
                public static string Description = "@Description";
                public static string QtyInHand = "@QtyInHand";
                public static string AlertQty = "@AlertQty";
                public static string UnitPrice = "@UnitPrice";
                public static string DeliveryChargers = "@DeliveryChargers";
                public static string DelivaryDescription = "@DelivaryDescription";
                public static string ReturnsDescription = "@ReturnsDescription";
                public static string PurchasingMethodId = "@PurchasingMethodId";
                public static string IsBuyerProtection = "@IsBuyerProtection";
                public static string ItemConditionId = "@ItemConditionId";
                public static string DeleveryOptionId = "@DeleveryOptionId";
                public static string WarrantyDescription = "@WarrantyDescription";
                public static string IsViewInNavBar = "@IsViewInNavBar";
                public static string IsActive = "@IsActive";
                public static string UserId = "@UserId";
                public static string WebPageURL = "@WebPageURL";
                public static string SearchKeyWords = "@SearchKeyWords";
                public static string IsDailyDeals = "@IsDailyDeals";
            }

            public static class ItemImageDetails
            {
                public static string ItemId = "@ItemId";
                public static string IsMainImage = "@IsMainImage";
                public static string ItemWiseImageId = "@ItemWiseImageId";
                public static string ImagePath = "@ImagePath";
                public static string UserId = "@UserId";
                public static string IsLargeImage = "@IsLargeImage";
                public static string Operation = "@Operation";
            }

            public static class ItemPurchasigFeedbackDetails
            {
                public static string ReceiverBSPId = "@ReceiverBSPId";
                public const string Operation = "@Operation";
                public static string ItemPurchasingFeedBackId = "@ItemPurchasingFeedBackId";
                public const string ItemId = "@ItemId";
                public static string SenderBSPId = "@SenderBSPId";
                public const string FeedbackStatusId = "@FeedbackStatusId";
                public static string ItemPurchasingFeedbackTypeId = "@ItemPurchasingFeedbackTypeId";
                public const string UserId = "@UserId";
                public static string SendersBSPId = "@SendersBSPId";
                public const string Feedback = "@Feedback";
            }

            public static class OrderDetailsInDetail
            {
                public static string OrderDetailId = "@OrderDetailId";
                public static string OrderId = "@OrderId";
                public static string ItemId = "@ItemId";
                public static string UnitPrice = "@UnitPrice";
                public static string Qty = "@Qty";
                public static string DeliveryChargers = "@DeliveryChargers";
                public static string UserId = "@UserId";
                public static string Operation = "@Operation";
            }

            public static class OrdersDetails
            {
                public static string OrderId = "@OrderId";
                public static string BuyerBSPId = "@BuyerBSPId";
                public static string OrderStatus = "@OrderStatus";
                public static string PaymentOptionId = "@PaymentOptionId";
                public static string UserId = "@UserId";
                public static string Operation = "@Operation";                
            }

            public static class ItemConditionDetails
            {
                public const string ItemConditionId = "@ItemConditionId";
                public const string ItemCondition = "@ItemCondition";
                public const string IsActive = "@IsActive";
                public const string UserId = "@UserId";
                public const string Operation = "@Operation";
            }

            public static class PurchasingMethodDetails
            {
                public const string ItemPurchasingMethodId = "@ItemPurchasingMethodId";
                public const string ItemPurchasingMethod = "@ItemPurchasingMethod";
                public const string IsActive = "@IsActive";
                public const string UserId = "@UserId";
                public const string Operation = "@Operation";
            }
        }

        public static class Feedback
        {
            public static class ItemPurchasingFeedbackTypeDetails
            {
                public static string ForSellerOrCustomer = "@ForSellerOrCustomer";
                public static string IsActive = "@IsActive";
            }

            public static class ItemPurchasingFeedbackDetails
            {
                public static string ReceiersBSPId = "@ReceiersBSPId";
                public static string SendersBSPId = "@SendersBSPId";
                public static string FeedbackTo = "@FeedbackTo";
                public static string ItemPurchasingFeedbackTypeId = "@ItemPurchasingFeedbackTypeId";
                public static string FeedbackStatusId = "@FeedbackStatusId";
            }
        }

        public static class SystemMaintenance
        {
            public static class AdministrationMenu
            {
                public static string CategoryId = "@CategoryId";
                public static string SubCategoryId = "@SubCategoryId";
                public static string UserId = "@UserId";
            }

            public static class ErrorLog
            {
                public static string StoredProcedure= "@StoredProcedure";
                public static string ErrorLineNo = "@ErrorLineNo";
                public static string ErrorNo = "@ErrorNo";
                public static string ErrorMessage = "@ErrorMessage";
                public static string UserId = "@UserId";
                public static string IsFromDBEnd = "@IsFromDBEnd";
                public static string IsFromCodeEnd = "@IsFromCodeEnd";
            }
        }

    }
}