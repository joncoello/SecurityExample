using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace SecurityPipeline.Pipeline
{
    public class TestMiddleware
    {
        private Func<IDictionary<string, object>, Task> _next;
        public TestMiddleware(Func<IDictionary<string, object>, Task> next)
        {
            _next = next;
        }
        public async Task Invoke(IDictionary<string, object> env) {

            var context = new OwinContext(env);
            Helper.Write("Middleware", context.Request.User);

            await _next(env);

        }

    }
}