using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace SecurityPipeline.Pipeline
{
    public class TestAuthorisationFilterAttribute : AuthorizeAttribute
    {
        protected override bool IsAuthorized(System.Web.Http.Controllers.HttpActionContext actionContext)
        {
            Helper.Write("AuthorisationFilter", actionContext.RequestContext.Principal);

            return true;
        }
    }
}