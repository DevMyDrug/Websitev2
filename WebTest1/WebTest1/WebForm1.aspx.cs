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
            presentation.Attributes["onclick"] = ClientScript.GetPostBackEventReference(this, "Presentation_Click");
            Contact.Attributes["onclick"] = ClientScript.GetPostBackEventReference(this, "Contact_Click");
        }

        protected void Categ_Click(int idcateg)
        {
            testons.InnerHtml = "";
            System.Web.UI.HtmlControls.HtmlGenericControl divGlob = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
            if (idcateg == 1)
            {
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
            }

            else if(idcateg == 2)
            {
                System.Web.UI.HtmlControls.HtmlGenericControl t1 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                t1.Style.Add("font-weight", "bold");
                t1.Style.Add("text-decoration", "underline");
                t1.InnerHtml= "Sur le plan administratif :";

                System.Web.UI.HtmlControls.HtmlGenericControl p1 = new System.Web.UI.HtmlControls.HtmlGenericControl("p");
                p1.InnerHtml = @"L'amicale des Classes en 3 est une association loi 1901 qui regroupe toutes les personnes
nées une année en 3, originaires et nouveaux arrivants, de la ville de Cluny et ses alentours.<br>
Elle s'appuie sur des statuts déposés en préfecture. Elle a sa tête un président qui est entouré par un bureau composé 
d’un président d'honneur, d'un vice président, d'un trésorier, d'un secrétaire et de membres actifs.<br>
Une assemblée générale est organisée une fois par an en convoquant tous les adhérents qui cotisent à l'association.<br>
Tous les adhérents peuvent être candidat au bureau et élu par l'assemblée générale. Le bureau est constitué peu après par les membres élus.";


                System.Web.UI.HtmlControls.HtmlGenericControl t2 = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                t2.Style.Add("font-weight", "bold");
                t2.Style.Add("text-decoration", "underline");
                t2.InnerHtml = "Sur le plan des valeurs";

                System.Web.UI.HtmlControls.HtmlGenericControl p2 = new System.Web.UI.HtmlControls.HtmlGenericControl("p");
                p2.InnerHtml = @"L'amicale a pour but de garder ou créer un lien entre toutes les personnes de la même classe 
en privilégiant la rencontre des différentes générations issues d'année se terminant en 3.<br>
L'amicale organise à ce titre des manifestations conviviales dans le courant de chaque année (randonnée, théâtre, sorties etc...)
permettant de garder le contact entre ces adhérents.<br>
L'amicale a comme devoir d'organiser une grande journée des Classes en 3 tous les dix ans et les années en 3.
Cette grande journée est constituée d’un défilé, d'un grand vin d'honneur, de photos et d’un grand banquet regroupant 
les conscrits en 3 adhérents ou non ainsi que leur famille ou amis.<br>
Une commission voyage est constituée au sein du bureau des Classes en 3 afin d'organiser des voyages tous les cinq ans avec 
des adhérents intéressés et volontaires. Les fonds nécessaire à ces voyages sont constitués de sommes prélevées mensuellement 
par l'amicale aux personnes inscrites. <br>";

                divGlob.Controls.Add(t1);
                divGlob.Controls.Add(p1);
                divGlob.Controls.Add(t2);
                divGlob.Controls.Add(p2);
            }

            else if (idcateg == 3)
            {
                System.Web.UI.HtmlControls.HtmlGenericControl divCentrer = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                System.Web.UI.HtmlControls.HtmlGenericControl table = new System.Web.UI.HtmlControls.HtmlGenericControl("table");
                System.Web.UI.HtmlControls.HtmlGenericControl l1 = new System.Web.UI.HtmlControls.HtmlGenericControl("tr");
                System.Web.UI.HtmlControls.HtmlGenericControl l2 = new System.Web.UI.HtmlControls.HtmlGenericControl("tr");
                System.Web.UI.HtmlControls.HtmlGenericControl l1c1 = new System.Web.UI.HtmlControls.HtmlGenericControl("td");
                System.Web.UI.HtmlControls.HtmlGenericControl l1c2 = new System.Web.UI.HtmlControls.HtmlGenericControl("td");
                System.Web.UI.HtmlControls.HtmlGenericControl l2c1 = new System.Web.UI.HtmlControls.HtmlGenericControl("td");
                System.Web.UI.HtmlControls.HtmlGenericControl l2c2 = new System.Web.UI.HtmlControls.HtmlGenericControl("td");

                l1c1.InnerHtml = "Siège social :";
                l1c2.InnerHtml = "Contacts";
                l2c1.InnerHtml = @"Amicale des Classes en 3.<br>
                                    26, rue de la levée.<br>
                                    71250 Cluny.<br>";
                l2c2.InnerHtml = @"Tel : 03 85 59 00 21<br><br>
                                    e-mail : classes3.cluny@gmail.com";

                l1c1.Style.Add("border-right", "1px solid black");
                l2c1.Style.Add("border-right", "1px solid black");

                table.Style.Add("margin", "0 auto");
                table.Style.Add("border-collapse", "collapse");

                l1.Controls.Add(l1c1);
                l1.Controls.Add(l1c2);

                l2.Controls.Add(l2c1);
                l2.Controls.Add(l2c2);

                table.Controls.Add(l1);
                table.Controls.Add(l2);

                divCentrer.Controls.Add(table);
                divGlob.Controls.Add(divCentrer);
            }

            divGlob.Style.Add("margin-top", "10px");
                testons.Controls.Add(divGlob);
        }



        #region IPostBackEventHandler Members

        public void RaisePostBackEvent(string eventArgument)
        {

            if (!string.IsNullOrEmpty(eventArgument))
            {

                if (eventArgument == "Accueil_Click")
                {
                    Categ_Click(1);
                }
                if (eventArgument == "Presentation_Click")
                {
                    Categ_Click(2);
                }
                if( eventArgument == "Contact_Click")
                {
                    Categ_Click(3);
                }
            }
        }

        #endregion
    }
}