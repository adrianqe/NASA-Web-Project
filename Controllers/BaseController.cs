using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace NASAWebPrototype.Controllers
{
    public class BaseController : Controller
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var query = context.HttpContext.Request.Query;
            var lang = query["lang"].ToString();

            if (!string.IsNullOrEmpty(lang))
            {
                // Guardar la cookie
                context.HttpContext.Response.Cookies.Append(
                    "lang",
                    lang,
                    new Microsoft.AspNetCore.Http.CookieOptions
                    {
                        Expires = DateTimeOffset.UtcNow.AddYears(1)
                    }
                );

                // Redireccionar a la misma URL sin el parámetro lang
                var request = context.HttpContext.Request;
                var currentUrl = request.Path + request.QueryString;
                var newUrl = currentUrl.ToString().Replace($"?lang={lang}", "").Replace($"&lang={lang}", "");

                context.Result = new RedirectResult(newUrl);
            }

            base.OnActionExecuting(context);
        }
    }
}
