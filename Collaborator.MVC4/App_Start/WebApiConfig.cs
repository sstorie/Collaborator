using System.Web.Http;

// ReSharper disable CheckNamespace
namespace Collaborator.MVC4
// ReSharper restore CheckNamespace
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
