using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DATA.COMMON;
using System.Data;

namespace DATA
{
    public class PasswordResetQuestionsEntry
    {
        public DataTable Select()
        {
            return DataBaseUtilities.DataBaseUtilities.Select(WellKnownStoredProcedures.Select.Select_PasswordResetQuestions);
        }
    }
}