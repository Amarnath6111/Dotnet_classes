using System.Web;
using System.Web.Mvc;

namespace CodebasetestMVC_2AfterChanges
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
