using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOMAIN
{
    public class CommonUserMessages
    {
        public static class SuccessfulMessages
        {
            public static string insertionSuccessful = "Record inserted successfully !";
            public static string updationSuccessful = "Record updated successfully !";
            public static string deletionSuccessful = "Record deleted successfully !";
            public static string imageUploadSuccessful = "Image uploaded successfully !";
            public static string userRegistrationSuccessful = "You are registered successfully. Please check your email address to verify your account.";
        }

        public static class ErrorMessages
        {
            public static string generalError = "Sorry, there is an error. contact admin !";
            public static string sorryWeCantProcessAtThisMoment = "Sorry, this operation cannot be done in this moment. Try again later. !";
            public static string fileFormatIncorrect = "This file format is incorrect. Please use 'PNG', 'JPGE' file format.";
        }

        public static class InformationMessages
        {
            public static string nodailyDeails = "There is no daity deails for today. You will redirect to our home page.";
            public static string yourOrderPlacedSuccessfullyPayLater = "Your order placed succesflly. You can pay your order later using MyLankanBay. Your order will cancel if you not pay the amount with in three (3)working days";
            public static string notloggedin = "You are not logged in. Please log in to do this process.";
            public static string thankYouForFeedback = "Your feedback is very important to us to rate this seller. Thank you for feedback.";
            public static string checkLoggedinOrNotBeforeFeedback = "You are not logged in. Please login before rate or feedback this seller.";

            public static string noItemsForThisSearch = "Sorry, there is no item(s) which realated to your search. Try using different keywords .!";
            public static string noItemsInCart = "There is no items in your cart at this moment.";
        }

        public static class QuestionMessages
        {
            public static string generalError = "Sorry, there is an error. contact admin !";
        }

        public static class WarnningMessages
        {
            public static string selectFeedbackType = "You have not selected at least one feedback type or you have given feedback ffor all feedback types.";
            public static string passwordIncorrect = "Password incorrect. Please check your password again";
            public static string usernameorpasswordcombinationerror = "Either username or password incorrect !";
            public static string usernameNotExists = "There is no user with this username. If you do not have an account, please use Create new account option.";

            public static string yourAccountIsLocked = "Your account has been locked due to unauthorized login attempts";
            public static string usenameralreadyexists = "This username already exist. Please use another.";

            public static string imageSizeTooLarge = "Image sizw is grater than 5MB. Please use image bellow 5MB.";
            public static string reqQtyIsGraterThanInHand = "Requested quantity is grater than quantity in hand.";

        }


    }
}