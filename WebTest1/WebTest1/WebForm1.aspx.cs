using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTest1
{
    public partial class WebForm1 : System.Web.UI.Page, IPostBackEventHandler
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            accueil.Attributes["onclick"] = ClientScript.GetPostBackEventReference(this, "Accueil_Click");
        }
        protected void Accueil_Click()
        {
            string txt = "accueil";
            testons.InnerHtml = txt;
        }
        #region IPostBackEventHandler Members

        public void RaisePostBackEvent(string eventArgument)
        {

            if (!string.IsNullOrEmpty(eventArgument))
            {

                if (eventArgument == "Accueil_Click")
                {
                    Accueil_Click();
                }
            }
        }

#endregion
    }
}