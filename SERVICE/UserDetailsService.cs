using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;
using DATA;
using DOMAIN;
using System.Data;

namespace SERVICE
{
    public class UserDetailsService
    {
        UserDetailsEntry userDetailsEntry = new UserDetailsEntry();

        public DataTable Select(UserDetails userDetails)
        {
            return userDetailsEntry.Select(userDetails);
        }

        public void Insert(UserDetails userDetails)
        {
            userDetailsEntry.Insert(userDetails,CommonParameterNames.Operations.Insert);
        }

        public void Update(UserDetails userDetails)
        {
            userDetailsEntry.Insert(userDetails, CommonParameterNames.Operations.Update);
        }

        public void LockOrUnlockUserAccount(UserDetails userDetails)
        {
            userDetailsEntry.LockAndUnlockUserAccount(userDetails);
        }

        public string CalculateMD5Hash(string input)
        {
            // step 1, calculate MD5 hash from input
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }
    }
}