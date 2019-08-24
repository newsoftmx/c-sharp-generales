using System.Web;
using System.Web.Mvc;

namespace mvcAprendizaje3BD
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}