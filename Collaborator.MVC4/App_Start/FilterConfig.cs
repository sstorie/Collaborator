using System.Web.Mvc;

// ReSharper disable CheckNamespace
namespace Collaborator.MVC4
// ReSharper restore CheckNamespace
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}