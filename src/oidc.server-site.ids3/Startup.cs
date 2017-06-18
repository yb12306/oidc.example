﻿using Microsoft.Owin;
using Owin;
using ServerSite;
using ServerSite.Ids3.Use;

[assembly: OwinStartup(typeof(Startup))]

namespace ServerSite
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseIds3();
        }
    }
}