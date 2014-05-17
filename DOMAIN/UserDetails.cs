using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOMAIN
{
    public class UserDetails
    {
        public int UserId { get; set; }
        public int BSPId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int ResetPwQuestionId { get; set; }
        public string ResetPwQuestionAnswer { get; set; }
        public bool IsActive { get; set; }
        public bool IsLocked { get; set; }
        public int CreatedorModifiedUserId { get; set; }
    }
}