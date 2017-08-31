function Inscription() {
    var nom = document.getElementById("inputNom").value;
    var prenom = document.getElementById("inpPrenom").value;
    var mail = document.getElementById("inpMail").value;
    var pass = document.getElementById("inpMpd").value;
    var pass2 = document.getElementById("inpMdpConf").value;
    var date = document.getElementById("inpDateN").value;
    var tel = document.getElementById("inpTel").value;
    var adresse = document.getElementById("inpAdresse").value;
    var cp = document.getElementById("inpCp").value;
    var ville = document.getElementById("inpVille").value;

    var err = 0;

    if (pass.length < 6)
    {
        err++;
        document.getElementById("errMdp").innerText = "Veuillez saisir un mot de passe de plus de 6 lettres";
    }
    if (pass != pass2)
    {
        err++;
        document.getElementById("errMdpConf").innerText = "Le mots de passes n'est pas identique.";
    }

    var reg = new RegExp("^(?:(?:31(\/)(?:0?[13578]|1[02]))\1|(?:(?:29|30)(\/)(?:0?[1,3-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(\/)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\d|2[0-8])(\/)(?:(?:0?[1-9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$");
    if (!reg.test(date))
    {
        err++;
        document.getElementById("errDateN").innerText = "Veuillez rentrer une date valide sous forme 'jour/mois/année'";
    }
        
    var regTel = new RegExp("^([0][0-9]{9})$");
    if (!regTel.test(tel))
    {
        err++;
        document.getElementById("errTel").innerText = "Veuillez rentrer un numéro de téléphone valide";
    }
    if (adresse.length == 0)
    {
        err++;
        document.getElementById("errAdr").innerText = "Veuillez rentrer votre adresse";
    }
    var regCp = new RegExp("^([0-9]{5})$");
    if (!regCp.test(cp))
    {
        err++;
        document.getElementById("errCp").innerText = "Veuillez rentrer un code postal valide";
    }
    if (ville.length == 0) {
        err++;
        document.getElementById("errAdr").innerText = "Veuillez rentrer le nomde votre ville";
    }
    if(err == 0)
        PageMethods.EnregistrePersonne();
}

function RecupAncre()
{
    
}