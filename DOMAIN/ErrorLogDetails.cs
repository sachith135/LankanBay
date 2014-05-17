using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOMAIN
{
    public class ErrorLogDetails
    {
        public string ClassNamePlusFunctionName { get; set; }        
        public string ErrorMessage { get; set; }
        public int UserId { get; set; }        
    }
}