using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Collaborator.Common.Events;
using Microsoft.AspNet.SignalR;
using SignalR.EventAggregatorProxy.SystemWeb;

namespace Collaborator.MVC4
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // This needs to be done BEFORE any other routes are registered...!!
            //
            // Register the default hubs route: ~/signalr
            RouteTable.Routes.MapHubs();
            RouteTable.Routes.MapEventProxy<EventBase>();

            AreaRegistration.RegisterAllAreas();

            //WebApiConfig.Register(GlobalConfiguration.Configuration);
            //FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

        }
    }
}