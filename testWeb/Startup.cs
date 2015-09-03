using Microsoft.Owin;
using Owin;
using Senparc.Weixin.QY.CommonAPIs;
using Senparc.Weixin.QY.Test.CommonApis;

[assembly: OwinStartupAttribute(typeof(testWeb.Startup))]
namespace testWeb
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
            AccessTokenContainer.Register(System.Configuration.ConfigurationManager.AppSettings["_corpId"], System.Configuration.ConfigurationManager.AppSettings["_corpSecret"]);
        }
    }
}
