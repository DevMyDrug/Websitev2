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
            testons.InnerHtml = "";
            System.Web.UI.HtmlControls.HtmlGenericControl divGlob = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
            //divGlob.Style.Add("", "");
            divGlob.InnerHtml = @"Nous vous souhaitons la bienvenue sur le site.
<br>
Inscrivez - vous vite:
<br>
il suffit de cliquer sur ""inscription"" en haut à droite et de remplir le formulaire.
<br>
Losque vous êtes inscrit vous avez accès à la partie privée du site.<br>
Pour envoyer des photos n'oubliez pas de créer un nouvel album.<br>
Donnez vos impressions sur le forum.
<br>
Merci à tous !";

            testons.Controls.Add(divGlob);

            //string txt = "accueil";
            //testons.InnerHtml = txt;
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