using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UrlRouting.WebUI.Customize
{
    public class weekdayConstraint : IRouteConstraint
    {
        private static string[] Days = new[] { "pzt", "sal", "car", "per", "cum", "cmt", "paz" };
        public bool Match(HttpContext httpContext, IRouter route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            return Days.Contains(values[routeKey]?.ToString().ToLowerInvariant());
        }
    }
}
