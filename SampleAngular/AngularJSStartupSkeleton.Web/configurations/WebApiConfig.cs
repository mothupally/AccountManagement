using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using AngularJSStartupSkeleton.WebAPI;
using System.Reflection;
using System.IO;
using Newtonsoft.Json.Serialization;
namespace AngularJSStartupSkeleton.Web
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes(); 


            //  load apis from another assembly using CustomAssemblyResolver
            string uriLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
            string uriPath = string.Format("{0}\\AngularJSStartupSkeleton.WebAPI.dll", uriLocation);
            config.Services.Replace(typeof(IAssembliesResolver), new CustomAssemblyResolver(new Uri(uriPath).LocalPath));

            // return Json in camelcase
            var jsonFormatter = config.Formatters.OfType<JsonMediaTypeFormatter>().First();
            jsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

        }
    }
}
