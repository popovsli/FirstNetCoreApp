using BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstNetCoreMVC.Utils.Filters
{
    public class ValidateModelFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                //Note that setting the Result property on the Action­ExecutingContext will short-circuit the request
                context.Result = new BadRequestObjectResult(context.ModelState);
            }
        }
    }
}
