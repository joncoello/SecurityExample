using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace SecurityPipeline.Pipeline
{
    [TestAuthenticationFilter]
    [TestAuthorisationFilter]
    public class TestController : ApiController
    {
        public IHttpActionResult Get() {

            Helper.Write("Controller", User);

            return Ok();

        }

    }
}