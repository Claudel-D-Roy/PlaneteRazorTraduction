   /// <summary>
    /// Auteur: Claudel D. Roy, WIllaim Jubinville, Mathieu Duval
    /// Description: Fonction JS permettant de modifier la couleur du message d'erreur
    /// Date: 11-25-2022
    /// </summary>

function AffichageMessage() {
    let test = $('#messageSondage').html();
    test = test.replace('<li>', '').replace('</li>', '').replace('<ul>', '').replace('</ul>', '');
    if (test == "Le courriel doit être spécifié pour recevoir les nouvelles!\n") {
        $('#messageSondage').addClass("text-danger border-danger alert-danger");
        $('#messageSondage').removeClass("text-success border-success alert-success");
    }
    else {
        $('#messageSondage').html(test);
        $('#messageSondage').addClass("text-success border-success alert-success");
        $('#messageSondage').removeClass("text-danger border-danger alert-danger");
    }
}
$(document).ready(function () {
    $('div.card').addClass("sondage");
    AffichageMessage();
    $('#messageSondage').change(function () {
        alert('changement!');
        AffichageMessage()
    });
});