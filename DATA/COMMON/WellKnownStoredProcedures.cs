using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DATA.COMMON
{
    public static class WellKnownStoredProcedures
    {
        public static class Select
        {
            public static string Select_ItemPerchasingFeedbackDetails = "Select_ItemPerchasingFeedbackDetails";
            public static string Select_BusinessPartnerWiseNotifications = "Select_BusinessPartnerWiseNotifications";
            public static string Select_NotificationTypes = "Select_NotificationTypes";
            public static string Select_OrderDetailsInDetailForOrderHistoy = "Select_OrderDetailsInDetailForOrderHistoy";
            public static string Select_OrderDetails = "Select_OrderDetails";
            public static string Select_UserWiseItemViewedDetails = "Select_UserWiseItemViewedDetails";
            public static string Select_FeedbackStatusDetailsByUserAndItem = "Select_FeedbackStatusDetailsByUserAndItem";
            public static string Select_FeedbackStatusDetails = "Select_FeedbackStatusDetails";
            public static string Select_ItemPurchasingFeedbackTypeDetails = "Select_ItemPurchasingFeedbackTypeDetails";

            public static string Select_BusinessPartnerAddressDetails = "Select_BusinessPartnerAddressDetails";
            public static string Select_SearchItem = "Select_SearchItem";
            
            public static string Select_SystemMaintenanceAdministrationMenuItems = "Select_SystemMaintenanceAdministrationMenuItems";
            public static string Select_SystemMaintenanceAdministrationMenuCategories = "Select_SystemMaintenanceAdministrationMenuCategories";
            public static string Select_SystemMaintenanceAdministrationMenuSubCategories = "Select_SystemMaintenanceAdministrationMenuSubCategories";

            public static string Select_SelectBusinessPartnerTypes = "Select_SelectBusinessPartnerTypes";
            public static string Select_PasswordResetQuestions = "Select_PasswordResetQuestions";
            public static string Select_AddressCategoryDetails = "Select_AddressCategoryDetails";

            public static string Select_UserDetails = "Select_UserDetails";
            public static string Select_BusinessPartnerReferenceDetails = "Select_BusinessPartnerReferenceDetails";

            public static string Select_DeleveryOptions = "Select_DeleveryOptions";

            public static string Select_CategoryDetails = "Select_CategoryDetails";
            public static string Select_SubCatrgoryDetails = "Select_SubCatrgoryDetails";

            public static string Select_ItemConditionDetails = "Select_ItemConditionDetails";
            public static string Select_PurchasingMethodDetails = "Select_PurchasingMethodDetails";
         
            public static string Select_MainMenuCategoriesForNavigationBar = "Select_MainMenuCategoriesForNavigationBar";
            public static string Select_MainMenuSubCategoriesRelatedToMainCategoryForNavigationBar = "Select_MainMenuSubCategoriesForNavigationBar";

            public static string Select_ItemDetailsForNavigationBar = "Select_ItemDetailsForNavigationBar";
            public static string Select_ItemDetailsToPages = "Select_ItemDetailsToPages";
            public static string Select_ItemImageDetails = "Select_ItemImageDetails";
            public static string Select_SellersItemImages = "Select_SellersItemImages";

            public static string Select_PaymentOptions = "Select_PaymentOptions";

            public static string Select_SellersTotalFeedback = "Select_SellersTotalFeedback";
            public static string Select_SellersTotalItems = "Select_SellersTotalItems";
            public static string Select_SellersActiveTotalItems = "Select_SellersActiveTotalItems";
        }

        public static class Insert
        {
            public static string Update_BusinessPartnerWiseNotificationsToRead = "Update_BusinessPartnerWiseNotificationsToRead";
            public static string Insert_OrderDetailsInDetail = "Insert_OrderDetailsInDetail";
            public static string Insert_OrderDetails = "Insert_OrderDetails";
            public static string Insert_ItemPurchasingFeedbackDetails = "Insert_ItemPurchasingFeedbackDetails";
            public static string Update_UserWiseItemViewDetails = "Update_UserWiseItemViewDetails";
            public static string Update_ItemWiseTotalViewDetails = "Update_ItemWiseTotalViewDetails";
            public static string Insert_SubCategoryDetails = "Insert_SubCategoryDetails";
            public static string Insert_CategoryDetails = "Insert_CategoryDetails";
            public static string Insert_LockUserAccount = "Insert_LockUserAccount";
            public static string Insert_UserDetails = "Insert_UserDetails";
            public static string Insert_ErrorLog = "Insert_ErrorLog";
            public static string Insert_ItemDetails = "Insert_ItemDetails";
            public static string Insert_BusinessPartnerAddress = "Insert_BusinessPartnerAddress";
            public static string Insert_BusinessPartnerReference = "Insert_BusinessPartnerReference";
            public static string Insert_ItemWiseImageDetails = "Insert_ItemWiseImageDetails";

        }

        public static class Delete
        {          
            public static string Delete_CategoryDetails = "Delete_CategoryDetails";
            public static string Delete_SubCategoryDetails = "Delete_SubCategoryDetails";
            public static string Delete_OrderDetailsWithItsAllDetails = "Delete_OrderDetailsWithItsAllDetails";
        }

    }
}