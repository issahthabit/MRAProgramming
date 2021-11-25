using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MRA
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [Obsolete]
        void Auth()
        {
            if(FormsAuthentication.Authenticate(txtemail.Value,txtpassword.Value))
            {
                FormsAuthentication.RedirectFromLoginPage(txtemail.Value,false);
            }
            else
            {
                msgLabel.Text = "Invalid Logins";
            }
        }

        [Obsolete]
        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            Auth();
            //
        }
    }
}