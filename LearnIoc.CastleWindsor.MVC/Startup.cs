﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LearnIoc.CastleWindsor.MVC.Startup))]
namespace LearnIoc.CastleWindsor.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
