using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DATA;
using DOMAIN;

namespace SERVICE
{
    public class PasswordResetQuestionsService
    {
        PasswordResetQuestionsEntry passwordResetQuestionsEntry = new PasswordResetQuestionsEntry();
        public DataTable Select()
        {
            return passwordResetQuestionsEntry.Select();
        }
    }
}