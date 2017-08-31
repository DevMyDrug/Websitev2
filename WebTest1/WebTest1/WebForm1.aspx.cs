using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using OutilsWeb;
using Logger;
using OutilsWeb.Balise;
using System.Web.Services;

namespace WebTest1
{

    public partial class WebForm1 : System.Web.UI.Page, IPostBackEventHandler
    {
        static Database db = new Database();
        protected void Page_Load(object sender, EventArgs e)
        {
            Categ_Click(1);
            accueil.Attributes["onclick"] = ClientScript.GetPostBackEventReference(this, "Accueil_Click");
            presentation.Attributes["onclick"] = ClientScript.GetPostBackEventReference(this, "Presentation_Click");
            Contact.Attributes["onclick"] = ClientScript.GetPostBackEventReference(this, "Contact_Click");
            insc.Attributes["onclick"] = ClientScript.GetPostBackEventReference(this, "Inscription_Click");
            testit.Attributes.Add("onload", "RecupAncre()");

        }

        protected void Categ_Click(int idcateg)
        {
            contenu.InnerHtml = "";
            HtmlB divGlob = new HtmlB("Div");

            if (idcateg == 1)
            {
                //Response.Redirect("WebTest1.aspx#Acceuil");
                divGlob.InnerHtml(@"Nous vous souhaitons la bienvenue sur le site.
                                    <br><br>
                                    Inscrivez - vous vite:
                                    <br><br>
                                    il suffit de cliquer sur ""inscription"" en haut à droite et de remplir le formulaire.
                                    <br><br>
                                    Losque vous êtes inscrit vous avez accès à la partie privée du site.<br>
                                    Pour envoyer des photos n'oubliez pas de créer un nouvel album.<br>
                                    Donnez vos impressions sur le forum.
                                    <br>
                                    Merci à tous !");
            }

            else if (idcateg == 2)
            {
                Response.Redirect("WebTest1.aspx#aPropos");
                HtmlB table = new HtmlB("table");

                HtmlB t1 = new HtmlB("DIV");
                t1.SStyle("font-weight:bold;text-decoration:underline");
                t1.InnerHtml("Sur le plan administratif :");

                HtmlB p1 = new HtmlB("p");
                p1.InnerHtml(@"L'amicale des Classes en 3 est une association loi 1901 qui regroupe toutes les personnes
nées une année en 3, originaires et nouveaux arrivants, de la ville de Cluny et ses alentours.<br>
Elle s'appuie sur des statuts déposés en préfecture. Elle a sa tête un président qui est entouré par un bureau composé 
d’un président d'honneur, d'un vice président, d'un trésorier, d'un secrétaire et de membres actifs.<br>
Une assemblée générale est organisée une fois par an en convoquant tous les adhérents qui cotisent à l'association.<br>
Tous les adhérents peuvent être candidat au bureau et élu par l'assemblée générale. Le bureau est constitué peu après par les membres élus.");


                HtmlB t2 = new HtmlB("DIV");
                t2.SStyle("font-weight:bold;text-decoration:underline");
                t2.InnerHtml("Sur le plan des valeurs");

                HtmlB p2 = new HtmlB("p");
                p2.InnerHtml(@"L'amicale a pour but de garder ou créer un lien entre toutes les personnes de la même classe 
en privilégiant la rencontre des différentes générations issues d'année se terminant en 3.<br>
L'amicale organise à ce titre des manifestations conviviales dans le courant de chaque année (randonnée, théâtre, sorties etc...)
permettant de garder le contact entre ces adhérents.<br>
L'amicale a comme devoir d'organiser une grande journée des Classes en 3 tous les dix ans et les années en 3.
Cette grande journée est constituée d’un défilé, d'un grand vin d'honneur, de photos et d’un grand banquet regroupant 
les conscrits en 3 adhérents ou non ainsi que leur famille ou amis.<br>
Une commission voyage est constituée au sein du bureau des Classes en 3 afin d'organiser des voyages tous les cinq ans avec 
des adhérents intéressés et volontaires. Les fonds nécessaire à ces voyages sont constitués de sommes prélevées mensuellement 
par l'amicale aux personnes inscrites. <br>");

                divGlob.AddChilds(t1);
                divGlob.AddChilds(p1);
                divGlob.AddChilds(t2);
                divGlob.AddChilds(p2);
            }

            else if (idcateg == 3)
            {
                Response.Redirect("WebTest1.aspx#Contact");
                #region table contact

                HtmlB divCentrer = new HtmlB("DIV");
                HtmlB table = new HtmlB("table");
                HtmlB l1 = new Tr();
                HtmlB l2 = new Tr();
                HtmlB l1c1 = new Td();
                HtmlB l1c2 = new Td();
                HtmlB l2c1 = new Td();
                HtmlB l2c2 = new Td();

                l1c1.InnerHtml("Siège social :");
                l1c2.InnerHtml("Contacts");
                l2c1.InnerHtml(@"Amicale des Classes en 3.<br>
                                    26, rue de la levée.<br>
                                    71250 Cluny.<br>");
                l2c2.InnerHtml(@"Tel : 03 85 59 00 21<br><br>
                                    e-mail : classes3.cluny@gmail.com");

                l1c1.SStyle("border-right:1px solid black");
                l2c1.SStyle("border-right:1px solid black");

                table.SStyle("margin:0 auto;border-collapse: collapse");

                l1.AddChilds(l1c1);
                l1.AddChilds(l1c2);

                l2.AddChilds(l2c1);
                l2.AddChilds(l2c2);

                table.AddChilds(l1);
                table.AddChilds(l2);

                divCentrer.AddChilds(table);
                divGlob.AddChilds(divCentrer);
                #endregion

                HtmlB divInsc = new HtmlB("div");
                divInsc.InnerHtml(@"Pour les inscriptions (Démarche externe au site) :
                                        <br><br>
                                        Envoyer un mail avec :<br>
                                        <br><br>
                                        Nom<br>
                                        Prénom<br>
                                        Année de naissance<br>
                                        Adresse<br>
                                        N° téléphone<br>
                                        Adresse mail<br>");
                divInsc.SStyle("margin-top:100px");
                divGlob.AddChilds(divInsc);
            }

            divGlob.SStyle("margin-top:10px");
            contenu.Controls.Add(divGlob.GetHtml());
        }

        protected void Inscription_Click()
        {
            Response.Redirect("WebTest1.aspx#Inscription");
            contenu.InnerHtml = "";
            HtmlB field = new HtmlB("fieldset");
            HtmlB legend = new HtmlB("legend");
            legend.InnerHtml("Inscription");
            field.AddChilds(legend);
            HtmlB table = new Table().SClass("TableInsc").AddChilds(
                    new Tr().AddChilds(
                        new Td().InnerHtml("Nom"),
                        new Td().AddChilds(
                            new InputText().SId("inputNom")
                        )
                    ),
                    new Tr().AddChilds(
                        new Td().InnerHtml("Prenom"),
                        new Td().AddChilds(
                            new InputText().SId("inpPrenom")
                        )
                    ),
                    new Tr().AddChilds(
                        new Td().InnerHtml("Adresse mail"),
                        new Td().AddChilds(
                            new InputText().SId("inpMail")
                        ),
                        new Td().AddChilds(new Div().SClass("divErr").SId("errMail"))
                    ),
                    new Tr().AddChilds(
                        new Td().InnerHtml("Entrez votre mot de passe"),
                        new Td().AddChilds(
                            new InputText().SId("inpMpd")
                        ),
                        new Td().AddChilds(new Div().SClass("divErr").SId("errMdp"))
                    ),
                    new Tr().AddChilds(
                        new Td().InnerHtml("Confirmez votre mot de passe"),
                        new Td().AddChilds(
                            new InputText().SId("inpMdpConf")
                        ),
                        new Td().AddChilds(new Div().SClass("divErr").SId("errMdpConf"))
                    ),
                    new Tr().AddChilds(
                        new Td().InnerHtml("Date de naissance"),
                        new Td().AddChilds(
                            new InputText().SId("inpDateN")
                        ),
                        new Td().AddChilds(new Div().SClass("divErr").SId("errDateN"))
                    ),
                    new Tr().AddChilds(
                        new Td().InnerHtml("Telephone"),
                        new Td().AddChilds(
                            new InputText().SId("inpTel")
                        ),
                        new Td().AddChilds(new Div().SClass("divErr").SId("errTel"))
                    ),
                    new Tr().AddChilds(
                        new Td().InnerHtml("Adresse"),
                        new Td().AddChilds(
                            new HtmlB("textarea").SId("inpAdresse")
                        ),
                        new Td().AddChilds(new Div().SClass("divErr").SId("errAdr"))
                    ),
                    new Tr().AddChilds(
                        new Td().InnerHtml("Code Postal"),
                        new Td().AddChilds(
                            new InputText().SId("inpCp")
                        ),
                        new Td().AddChilds(new Div().SClass("divErr").SId("errCp"))
                    ),
                    new Tr().AddChilds(
                        new Td().InnerHtml("Ville"),
                        new Td().AddChilds(
                            new InputText().SId("inpVille")
                        ),
                        new Td().AddChilds(new Div().SClass("divErr").SId("errVille"))
                    )
                );
            field.AddChilds(table);
            HtmlB btnConf = new HtmlB("button").OnClick("Inscription()").InnerHtml("Confirmer");
            contenu.Controls.Add(field.GetHtml());
            contenu.Controls.Add(btnConf.GetHtml());
        }

        [WebMethod]
        public static void EnregistrePersonne(string mail, string pass, string nom, string prenom, string adresse,
            string cp, string ville, string dateNaissance, string tel)
        {
            Dictionary<string, object> vars = new Dictionary<string, object>();
            vars.Add("?m", mail);
            vars.Add("?p",pass);
            vars.Add("?n", nom);
            vars.Add("?pr",prenom);
            vars.Add("?a",adresse);
            vars.Add("?cp",Convert.ToInt32(cp));
            vars.Add("?v", ville);
            DateTime date = DateTime.Parse(dateNaissance);
            vars.Add("?d",date);
            vars.Add("?t",Convert.ToInt32(tel));

            db.NonQuery(@"INSERT INTO utilisateurs(mail,pass,nom,prenom,adresse,datenaissance,telephone,cp,ville)
                        VALUES (?m,?p,?n,?pr,?a,?d,?t,?cp,?v)", vars);

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
                if (eventArgument == "Contact_Click")
                {
                    Categ_Click(3);
                }
                if (eventArgument == "Inscription_Click")
                {
                    Inscription_Click();
                }
            }
        }

        #endregion
    }
}