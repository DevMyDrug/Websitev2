<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebTest1.WebForm1" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" type="text/css" href="defaut.css" />
    <title>Classe en 3!</title>
</head>
<body>

    <form id="form1" runat="server">

    <div id="divTitle">
        <h1>Amicale des classes en 3 de Cluny </h1>
    </div>
    <div class="pages">
        <ul class ="menu">
            <li class="categ"  id="accueil" onclick="Accueil_Click" runat="server">
                <a>Accueil</a><br />
        </li>
        <li class="categ"">
            <a> Qui sommes nous?</a>
        </li>
        <li class="categ">
            <a>Contact</a>

        </li>
        </ul>
        <div id="testons" onclick="" runat="server">

            Nous vous souhaitons la bienvenue sur le site.

Inscrivez-vous vite:

il suffit de cliquer sur "inscription" en haut à droite et de remplir le formulaire.

Losque vous êtes inscrit vous avez accès à la partie privée du site.
Pour envoyer des photos n'oubliez pas de créer un nouvel album.
Donnez vos impressions sur le forum.

Merci à tous !


        </div>
    </div>

       
    </form>

</body>
</html>
