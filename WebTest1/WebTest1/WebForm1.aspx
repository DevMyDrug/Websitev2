<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebTest1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" type="text/css" href="defaut.css" />
    <script type="text/javascript" id="JS" src="JavaScript.js"></script>
    <title>Classe en 3!</title>
</head>
<body id="testit" runat="server">
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true">
            <Scripts>
                <asp:ScriptReference Path="PageMethod.js" />
            </Scripts>
        </asp:ScriptManager>
        <div style="float: right">
            <table class="connexion">
                <tr>
                    <td style="border-right: 1px solid black">
                        <div id="Connexion" runat="server">Connexion</div>
                    </td>
                    <td>
                        <a name="inscription" id="insc" runat="server">Inscription</a>
                    </td>
                </tr>
            </table>
        </div>

        <div id="divTitle">
            <h1>Amicale des classes en 3 de Cluny </h1>
        </div>
        <div class="pages">
            <div class="menu">
                <div style="display: flex; margin: 0 auto;">
                    <div class="categ" id="accueil" onclick="Accueil_Click" runat="server">
                        Accueil<br />
                    </div>
                    <div class="categ" id="presentation" onclick="Presentation_Click" runat="server">
                        Qui sommes nous?
                    </div>
                    <div class="categ" id="Contact" onclick="Contact_Click" runat="server">
                        Contact
                    </div>
                </div>

            </div>

            <div class="global" id="contenu" onclick="" runat="server">
            </div>
        </div>
        <input hidden="hidden" 
    </form>

</body>
</html>
