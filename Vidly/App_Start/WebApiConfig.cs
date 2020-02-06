using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Vidly
{
    // automatically created to help continuing the steps to build API Framework
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //configure Camel Notation ....... the first word of the variable is lowercase and the second one is uppercase
            var setting = config.Formatters.JsonFormatter.SerializerSettings;
            setting.ContractResolver = new CamelCasePropertyNamesContractResolver();
            setting.Formatting = Formatting.Indented;

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
