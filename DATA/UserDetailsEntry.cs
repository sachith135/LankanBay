using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DATA.COMMON;
using DOMAIN;

namespace DATA
{
    public class UserDetailsEntry
    {
        public DataTable Select(UserDetails userDetails)
        {
            try
            {
                Dictionary<string, object> spParameters = new Dictionary<string, object>();
                spParameters.Add(WellKnownParameters.BusinessPartner.UserDetails.Username, userDetails.Username);
                spParameters.Add(WellKnownParameters.BusinessPartner.UserDetails.Password, userDetails.Password);
                spParameters.Add(WellKnownParameters.BusinessPartner.UserDetails.IsActive, userDetails.IsActive);
                spParameters.Add(WellKnownParameters.BusinessPartner.UserDetails.IsLocked, userDetails.IsLocked);
                return DataBaseUtilities.DataBaseUtilities.Select(WellKnownStoredProcedures.Select.Select_UserDetails, spParameters);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void LockAndUnlockUserAccount(UserDetails userDetails)
        {
            try
            {
                Dictionary<string, object> spParameters = new Dictionary<string, object>();
                spParameters.Add(WellKnownParameters.BusinessPartner.UserDetails.Username, userDetails.Username);
                spParameters.Add(WellKnownParameters.BusinessPartner.UserDetails.IsLocked, userDetails.IsLocked);
                DataBaseUtilities.DataBaseUtilities.Insert(WellKnownStoredProcedures.Insert.Insert_LockUserAccount, spParameters);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Insert(UserDetails userDetails,string operation)
        {
            try
            {
                Dictionary<string, object> spParameters = new Dictionary<string, object>();              
                spParameters.Add(WellKnownParameters.BusinessPartner.UserDetails.BSPId, userDetails.BSPId);
                spParameters.Add(WellKnownParameters.BusinessPartner.UserDetails.CreatedOrModifiedUserId, userDetails.CreatedorModifiedUserId);
                spParameters.Add(WellKnownParameters.BusinessPartner.UserDetails.IsActive, userDetails.IsActive);
                spParameters.Add(WellKnownParameters.BusinessPartner.UserDetails.IsLocked, userDetails.IsLocked);
                spParameters.Add(WellKnownParameters.BusinessPartner.UserDetails.Password, userDetails.Password);
                spParameters.Add(WellKnownParameters.BusinessPartner.UserDetails.ResetPwQuestionAnswer, userDetails.ResetPwQuestionAnswer);
                spParameters.Add(WellKnownParameters.BusinessPartner.UserDetails.ResetPwQuestionId, userDetails.ResetPwQuestionId);
                spParameters.Add(WellKnownParameters.BusinessPartner.UserDetails.UserId, userDetails.UserId);
                spParameters.Add(WellKnownParameters.BusinessPartner.UserDetails.Username, userDetails.Username);
                spParameters.Add(WellKnownParameters.BusinessPartner.UserDetails.Operation,operation);

                DataBaseUtilities.DataBaseUtilities.Insert(WellKnownStoredProcedures.Insert.Insert_UserDetails, spParameters);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}