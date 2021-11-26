using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MRA.Models
{
    
    public class Token
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class UserDetails
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string email { get; set; }
    }

    public class LoginDetails
    {
        public int ResultCode { get; set; }
        public string Remark { get; set; }
        public Token Token { get; set; }
        public bool Authenticated { get; set; }
        public UserDetails UserDetails { get; set; }
    }

}