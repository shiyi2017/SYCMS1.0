using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SZCMS.Controllers.Admin
{
    public class BasePage: Controller
    {
        public string GetUserName()
        {
           return  HttpContext.Session.GetString("code");
        }

        public string IsLogin()
        {
            string code = GetUserName();
            if (string.IsNullOrEmpty(code))
            {
                Response.Redirect("/Admin/Login");
            }
            return code;
        }
    }
}
