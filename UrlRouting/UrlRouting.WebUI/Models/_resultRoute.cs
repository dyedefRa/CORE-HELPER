using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UrlRouting.WebUI.Models
{
    public class _resultRoute
    {
        public string Controller { get; set; }
        public string Action { get; set; }
        public Dictionary<string, object> RouteData = 
            new Dictionary<string, object>();
    }
}
