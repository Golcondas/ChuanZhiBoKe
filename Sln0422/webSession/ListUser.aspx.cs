using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webSession
{
    public partial class ListUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["asp_net_session"];
            if (cookie != null)
            {
                SessionManager ssManager = new SessionManager();
                Dictionary<string, object> uDictionary = ssManager.GetSession(cookie.Value.ToString());
                name.InnerText = uDictionary["uInfo"].ToString();
            }
        }
    }
}