namespace TP2NASA.Models
{
    /// <summary>
    /// Auteur: Claudel D. Roy, William Jubinville, Mathieu Duval
    /// Description: Classe contenant les membres pour les champs dans le sondage maison
    /// Date: 11-25-2022
    /// </summary>
    public class Sondage
    {
        #region Propriétés
        public string? Prénom { get; set; }
        public string? Nom { get; set; }
        public string? Courriel { get; set; }
        public string? PlanètePréférée { get; set; }
        public int Niveau { get; set; }
        public DateTime? DernièreVisite { get; set; }
        public string? Commentaire { get; set; }
        public string? CodePromo { get; set; }
        public Planète? Planète { get; set; }
        public Planète[]? Planètes { get; set; }
        public bool Informé { get; set; } = false; 
        #endregion
    }
}
