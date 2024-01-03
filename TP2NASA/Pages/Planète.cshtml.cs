using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TP2NASA.Models;
using TP2NASA.Services;

namespace TP2NASA.Pages.Planètes
{
    /// <summary>
    /// Auteur: Claudel D. Roy, William Jubinville, Mathieu Duval
    /// Description: Classe contenant le Model des fiches pour les planètes
    /// Date: 11-25-2022
    /// </summary>
    public class PlanèteModel : PageModel
    {
        #region Champs
        private IPlanèteService? _service = null;
        #endregion

        #region Propriétés
        public Planète[]? Planètes { get; set; }
        public Planète? Planète { get; set; }
        #endregion

        #region Constructeur 
        public PlanèteModel(IPlanèteService service)
        {
            _service = service;
        }
        #endregion

        #region Méthodes
        /// <summary>
        /// Auteur: Claudel D. Roy, William Jubinville, Mathieu Duval
        /// Description: Permet d'extraire des informations de la base de données et les assigner.
        /// Date: 11-25-2022
        /// </summary>
        public void OnGet(int noplanete)
        {
            Planète = _service!.Trouver(noplanete);
            Planètes = _service!.Lister();
        }
        #endregion
    }
}
