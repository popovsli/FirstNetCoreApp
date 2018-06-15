using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstNetCoreMVC.Utils.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace FirstNetCoreMVC.Utils.BaseControllers
{
    public class BaseController : Controller
    {
        public ISession Session => HttpContext.Session;

    }
}