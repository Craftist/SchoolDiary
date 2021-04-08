using System.Diagnostics;
using System.Globalization;
using System.Threading;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using SchoolDiary3.Models;

namespace SchoolDiary3.Controllers
{
    public class BaseController : Controller
    {
        private readonly ILogger<BaseController>      _logger;
        private readonly UserManager<ApplicationUser> _userManager;

        public BaseController() { }

        public BaseController(ILogger<BaseController> logger, UserManager<ApplicationUser> userManager)
        {
            _logger = logger;
            _userManager = userManager;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Debug.Assert(_userManager != null, "_userManager != null");
            var applicationUser = _userManager.GetUserAsync(User).Result;
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
