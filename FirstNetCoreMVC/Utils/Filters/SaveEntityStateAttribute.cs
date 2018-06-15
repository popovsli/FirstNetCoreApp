using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstNetCoreMVC.Utils.Filters
{
    public class SaveEntityStateAttribute : TypeFilterAttribute
    {
        public SaveEntityStateAttribute() : base(typeof(SaveEntityStateFilter))
        {
        }

        private class SaveEntityStateFilter : IAsyncActionFilter
        {
            public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
            {
                await next();

                if (context.HttpContext.Request.Method == "GET")
                {

                }
            }
        }
    }


}
