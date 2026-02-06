using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace All_Validations
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode =UnobtrusiveValidationMode.None;

        }
        protected void Application_Start(object sender, EventArgs e)
        {
            ScriptManager.ScriptResourceMapping.AddDefinition("jquery", new ScriptResourceDefinition
            {
                Path = "~/Scripts/jquery-3.6.0.min.js",   // adjust path to your jQuery file
                DebugPath = "~/Scripts/jquery-3.6.0.js",
                CdnPath = "https://ajax.aspnetcdn.com/ajax/jQuery/jquery-3.6.0.min.js",
                CdnDebugPath = "https://ajax.aspnetcdn.com/ajax/jQuery/jquery-3.6.0.js"
            });
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            lblFirst.Text = "your first name is :" + txtFirst.Text;
            lblLast.Text ="your last name is :"+txtLast.Text;
            lblemail.Text ="your email is :"+txtemail.Text;
            lblpassword .Text ="your password is :"+txtpassword .Text;
            lblConfirmPassword .Text ="your confirm password is :"+txtConfirmPassword .Text;
            lblmobile .Text ="your mobile number is :"+txtmobile .Text;
            lblage .Text ="your age is :"+txtage .Text;

            lblFirst.Text = " ";
            lblLast.Text = " ";
            lblemail.Text = " ";
            lblpassword.Text = " ";
            lblConfirmPassword.Text = " ";
            lblmobile.Text = " ";
            lblage.Text = " ";

        }
    }
}