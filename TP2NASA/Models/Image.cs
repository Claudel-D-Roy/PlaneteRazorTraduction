namespace TP2NASA.Models
{
    /// <summary>
    /// Auteur: Claudel D. Roy, William Jubinville, Mathieu Duval
    /// Description: Classe contenant les membres pour les caractéristiques des images
    /// Date: 11-25-2022
    /// </summary>
    public class Image
    {
        #region Propriétés
        public int ID { get; set; }
        public string? Nom { get; set; }
        public int Taille { get; set; }
        public string? Type { get; set; }
        public byte[]? Data { get; set; }
        #endregion
    }
}
