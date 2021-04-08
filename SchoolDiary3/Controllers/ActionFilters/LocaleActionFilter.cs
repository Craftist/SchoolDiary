using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using SchoolDiary3.Models;

namespace SchoolDiary3.Controllers.ActionFilters
{
    public class LocaleActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var _userManager = context.HttpContext.RequestServices.GetService(typeof(UserManager<ApplicationUser>)) as UserManager<ApplicationUser>;
            
            var applicationUser = _userManager.GetUserAsync(context.HttpContext.User).Result;
            var userLocale = applicationUser.Locale;

            if (context.RouteData.Values.ContainsKey("culture")) {
                userLocale = context.RouteData.Values["culture"]?.ToString();
            }

            var userLocaleObject = CultureInfo.GetCultureInfo(userLocale);

            var currentThread = Thread.CurrentThread;
            currentThread.CurrentCulture = userLocaleObject;
            currentThread.CurrentUICulture = userLocaleObject;

            base.OnActionExecuting(context);
        }
    }
}
