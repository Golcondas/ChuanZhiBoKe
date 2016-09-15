using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webSession
{
    public partial class WebSessIon : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_OnClick(object sender, EventArgs e)
        {
            SessionManager ss = new SessionManager();
            string sessionId = ss.SetSession("uInfo",txtName.Text);
            HttpCookie sessionCookie = new HttpCookie("asp_net_session", sessionId);
            Response.Cookies.Add(sessionCookie);
            Response.Redirect("ListUser.aspx");
            ;

        }
    }
}