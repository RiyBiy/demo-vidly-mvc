using System.Web;
using System.Web.Mvc;

namespace Vidly
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new AuthorizeAttribute());// to authorize the all view and controller s 
            filters.Add(new RequireHttpsAttribute()); // will no longer available on http channel 
        }
    }
}
