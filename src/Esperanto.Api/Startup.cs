using Esperanto.Api.Helpers;
using Esperanto.Api.Security;
using Esperanto.CrossCutting;
using Esperanto.SharedKernel.Events;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;
using Owin;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using System;
using System.Web.Http;

namespace Esperanto.Api
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();

            var container = new Container();

            ConfigureDependencyInjection(config, container);



            ConfigureWebApi(config);


            ConfigureOAuth(app, container);


            app.UseCors(CorsOptions.AllowAll);

            app.UseWebApi(config);

            


        }

        public static void ConfigureWebApi(HttpConfiguration config)
        {
            var formatters = config.Formatters;

            formatters.Remove(formatters.XmlFormatter);

            var jsonSettings = formatters.JsonFormatter.SerializerSettings;

            jsonSettings.Formatting = Newtonsoft.Json.Formatting.Indented;

            jsonSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            jsonSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;

            jsonSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.None;

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                "DefaultApi",
                "api/{controller}/{id}",
                new
                {
                    id = RouteParameter.Optional
                }
            );
        }

        public static void ConfigureDependencyInjection(HttpConfiguration config, Container container)
        {
            container.Options.DefaultScopedLifestyle = new WebApiRequestLifestyle();

            DependencyRegister.Register(container);

            config.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);

            DomainEvent.Container = new DomainEventContainer(config.DependencyResolver);
        }

        public void ConfigureOAuth(IAppBuilder app, Container container)
        {
            OAuthAuthorizationServerOptions oAuthServerOptions = new OAuthAuthorizationServerOptions()
            {
                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/api/security/token"),
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(2),
                Provider = new SimpleAuthorizationServerProvider(container)
            };

            //Passamos as opções de configuração de OAuth Authrorization Server para a aplicação
            app.UseOAuthAuthorizationServer(oAuthServerOptions);

            //Passamos as opções de configuração de Bearer Authentication para a nossa aplicação
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());
        }
    }
}