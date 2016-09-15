using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebSession
{
    public partial class Cookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOK_OnClick(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string password = txtPassword.Text;
            HttpCookie cooke = new HttpCookie("uName",name);
            
            cooke.Expires = DateTime.Now.AddDays(2);
            Response.Cookies.Add(cooke);
            Response.Redirect("WebCookie.aspx");
            //cooke
        }
    }
}