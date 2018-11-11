using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Security.Principal;


namespace WebApplication1
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs args)
        {
            if (Context.User != null)
            {
                
                string[] userRoles;
                string[] userPermisos = new string[0];

               
                //    userRoles = _DNCService.GetRolesByEmail(Context.User.Identity.Name).ToArray();
                //    int rolID = _DNCService.GetRolByEmail(Context.User.Identity.Name);
                //    List<RolPermiso> listadoPermisos = _DNCService.GetPermisosPorRol(rolID);

                //    int x = 0;
                //    Array.Resize(ref userPermisos, listadoPermisos.Count);
                //    foreach (RolPermiso item in listadoPermisos)
                //    {
                //        userPermisos[x] = item.Permiso.Accion;
                //        x += 1;
                //    }
                //}


                //GenericPrincipal gp = new GenericPrincipal(Context.User.Identity, userPermisos);

                //Context.User = gp;
            }
        }

    }
}
