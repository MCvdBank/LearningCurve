using System.Web;
using System.Web.Mvc;
using LearnMVC.Filters;

namespace LearnMVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //filters.Add(new HandleErrorAttribute());
            filters.Add(new EmployeeExceptionFilter());
        }
    }
}
