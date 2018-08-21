using ConcessionariaAPI.api.Helpers;
using ConcessionariaAPI.Startup;
using Microsoft.Owin.Cors;
using Owin;
using System.Web.Http;
using Unity;

namespace ConcessionariaAPI.api
{
    public class Startaup
    {
        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();

            var container = new UnityContainer();
            DependencyResolver.Resolve(container);
            config.DependencyResolver = new UnityResolver(container);

            ConfigureWebApi(config);

            app.UseCors(CorsOptions.AllowAll);

        }

        private void ConfigureWebApi(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute
                (
                    name: "DefaultApi",
                    routeTemplate : "api/{controller}/{id}",
                    defaults : new {id = RouteParameter.Optional}
                );
        }
    }
}