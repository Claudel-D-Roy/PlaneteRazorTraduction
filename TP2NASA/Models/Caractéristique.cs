namespace TP2NASA.Models
{
    /// <summary>
    /// Auteur: Claudel D. Roy, William Jubinville, Mathieu Duval
    /// Description: Classe contenant les membres pour les caractéristiques des planètes
    /// Date: 11-25-2022
    /// </summary>
    public class Caractéristique
	{
		#region Propriété
		public int ID { get; set; }
		public string? Catégorie { get; set; }
		public string? Nom { get; set; }
		public decimal Valeur { get; set; }
		public string? MesureHtml { get; set; }
		public int PlanèteID { get; set; }
        #endregion

        #region Constructeur
        public Caractéristique()
        {

        }

        public Caractéristique(Caractéristique caractéristique)
        {
            foreach (var propriété in typeof(Caractéristique).GetProperties())
            {
                propriété.SetValue(this, propriété.GetValue(caractéristique));
            }
        }
        #endregion

        #region Nouvelle classe
        public class CaractéristiqueFR : Caractéristique
        {
            #region Constructeurs
            public CaractéristiqueFR()
            {

            }
            public CaractéristiqueFR(Caractéristique caractéristique) : base(caractéristique)
            {

            }
            #endregion
        }

        //Pour les table en anglais
        public class CaractéristiqueEN : Caractéristique
        {
            #region Constructeurs
            public CaractéristiqueEN()
            {

            }
            public CaractéristiqueEN(Caractéristique caractéristique) : base(caractéristique)
            {

            }
            #endregion
        }
        #endregion
    }
}
