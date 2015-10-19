using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ForumApplication.Models
{
    public class UserModel
    {
        public string UserName { get; set; }
        public string Age { get; set; }

        public string StatusMessage { get; set; }
    }
}
