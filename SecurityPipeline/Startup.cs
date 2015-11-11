using Owin;
using SecurityPipeline.Pipeline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using SecurityPipeline.Middleware;
using System.Threading.Tasks;
using System.Security.Claims;

namespace SecurityPipeline
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var configuration = new HttpConfiguration();
            configuration.Routes.MapHttpRoute(
                "default",
                "api/{controller}"
                );

            app.Use(typeof(TestMiddleware));

            app.UseBasicAuthentication("Demo", ValidateUser);

            app.UseWebApi(configuration);
        }

        private async Task<IEnumerable<Claim>> ValidateUser(string id, string secret)
        {
            if (id == secret)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, id),
                    new Claim(ClaimTypes.Role, "foo")
                };

                return claims;
            }

            return null;
        }
    }
}