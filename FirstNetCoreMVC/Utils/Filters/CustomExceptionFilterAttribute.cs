using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstNetCoreMVC.Utils.Filters
{
    public class CustomExceptionFilterAttribute : TypeFilterAttribute
    {
        public CustomExceptionFilterAttribute() : base(typeof(CustomExceptionFilter))
        {

        }

        private class CustomExceptionFilter : IAsyncExceptionFilter
        {
            public Task OnExceptionAsync(ExceptionContext context)
            {
               //TODO Implement error handling
               throw new NotImplementedException();
            }
        }
    }
}
