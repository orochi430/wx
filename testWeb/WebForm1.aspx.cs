using Senparc.Weixin.QY.AdvancedAPIs;
using Senparc.Weixin.QY.CommonAPIs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace testWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public string _corpId = System.Configuration.ConfigurationManager.AppSettings["_corpId"];
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var accessToken = AccessTokenContainer.GetToken(_corpId);
            var result = MailListApi.GetDepartmentMember(accessToken, 2, 0, 0);
            
            MassApi.SendText(accessToken, "xiaobao", "", "", "7", "测试发送");
            //MassApi.SendImage(accessToken,"xiaobao|orochi430","","","7",)
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var accessToken = AccessTokenContainer.GetToken(_corpId);
            string[] users = { "xiaobao", "orochi430", "xiaoze" };
            ChatApi.CreateChat(accessToken, "mychart", "测试会话", "orochi430", users);
        }
    }
}