using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DATA;
using DOMAIN;
using System.Data;

namespace SERVICE
{
    public class FeedbackStatusDetailsService
    {
        FeedbackStatusDetailsEntry feedbackStatusDetailsEntry = new FeedbackStatusDetailsEntry();

        public DataTable Select()
        {
            return feedbackStatusDetailsEntry.Select();
        }
    }
}