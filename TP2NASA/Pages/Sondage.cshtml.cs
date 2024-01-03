using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using TP2NASA.Models;
using TP2NASA.Models.Sondages;
using TP2NASA.Services;

namespace TP2NASA.Pages
{
    /// <summary>
    /// Auteur: Claudel D. Roy, William Jubinville, Mathieu Duval
    /// Description: Classe contenant le Model pour le sondage maison
    /// Date: 11-25-2022
    /// </summary>
    public class SondageModel : PageModel
    {
        #region �num�rations
        public enum Actions
        {
            Envoyer,
            Recommencer
        }
        #endregion

        #region Champs
        IPlan�teService? _service = null;
        #endregion

        #region Propri�t�s
        [BindProperty] // IMPORTANT!!!
        public SondageViewModel? Sondage { get; set; }
        public List<string> Plan�tes { get; set; } = new();
        #endregion

        #region Constructeur
        /// <summary>
        /// Auteur: Claudel D. Roy, William Jubinville, Mathieu Duval
        /// Description: Constructeur de la liste des noms de plan�tes dans la base de donn�es
        /// Date: 11-25-2022
        /// </summary>
        public SondageModel(IPlan�teService service)
        {
            _service = service;
            var plan�tes_data = _service.Lister();
            List<string> nom_plan�tes = plan�tes_data.Select(i => i.Nom).ToList()!;
            Plan�tes = nom_plan�tes;
        }
        #endregion

        public void OnGet()
        {
        }

        public IActionResult OnPost(int action)
        {
            if ((Actions)action == Actions.Envoyer)
                if (!ModelState.IsValid)
                {
                    foreach (var modelState in ModelState.Values)
                        foreach (var error in modelState.Errors)
                            ModelState.AddModelError("", error.ErrorMessage);

                    return Page(); // Nous fait revenir a la page courante
                }

            return RedirectToPage(); // Vide le formulaire
        }
    }
}
