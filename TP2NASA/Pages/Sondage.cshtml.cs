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
        #region Énumérations
        public enum Actions
        {
            Envoyer,
            Recommencer
        }
        #endregion

        #region Champs
        IPlanèteService? _service = null;
        #endregion

        #region Propriétés
        [BindProperty] // IMPORTANT!!!
        public SondageViewModel? Sondage { get; set; }
        public List<string> Planètes { get; set; } = new();
        #endregion

        #region Constructeur
        /// <summary>
        /// Auteur: Claudel D. Roy, William Jubinville, Mathieu Duval
        /// Description: Constructeur de la liste des noms de planètes dans la base de données
        /// Date: 11-25-2022
        /// </summary>
        public SondageModel(IPlanèteService service)
        {
            _service = service;
            var planètes_data = _service.Lister();
            List<string> nom_planètes = planètes_data.Select(i => i.Nom).ToList()!;
            Planètes = nom_planètes;
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
