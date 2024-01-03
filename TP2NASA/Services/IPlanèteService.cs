using TP2NASA.Models;

namespace TP2NASA.Services
{
    /// <summary>
    /// Auteur: Claudel D. Roy, Willaim Jubinville, Mathieu Duval
    /// Description: L'interface pour les services
    /// Date: 11-25-2022
    /// </summary>
    public interface IPlanèteService
    {
        #region Enum
        public enum Mode
        {
            BD,
            Liste
        }
        #endregion

        #region Méthodes
        public Planète[] Lister();
        public Planète Trouver(int iNoPlanète);
        public bool Envoyer(Sondage sondage);
        #endregion
    }
}
