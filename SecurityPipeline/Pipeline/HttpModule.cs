﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SecurityPipeline.Pipeline
{
    public class HttpModule : IHttpModule
    {

        public void Init(HttpApplication context)
        {
            context.BeginRequest += Context_BeginRequest;
        }

        private void Context_BeginRequest(object sender, EventArgs e)
        {
            Helper.Write("HttpModule", HttpContext.Current.User);
        }

        public void Dispose() { }

    }
}