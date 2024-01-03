using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using static TP2NASA.Models.Caractéristique;
using static TP2NASA.Models.Planète;

namespace TP2NASA.Models
{
    /// <summary>
    /// Auteur: Claudel D. Roy, William Jubinville, Mathieu Duval
    /// Description: Classe contenant les membres décrivant les planètes
    /// Date: 11-25-2022
    /// </summary>
    public class Planète
    {
        #region Propriétés
        public int ID { get; set; }
        public string? Nom { get; set; }
        public string? Description { get; set; }
        public int ImageID { get; set; }
        public int NbSatellites { get; set; }
        public int NoPlanète { get; set; }
        public string? Résumé { get; set; }
        public float Révolution { get; set; }
        public Image? Image { get; set; }
        [ForeignKey("PlanèteID")]
        public List<CaractéristiqueFR>? Caractéristiques { get; set; }
        [ForeignKey("PlanèteID")]
        public List<CaractéristiqueEN>? CaractéristiquesEN { get; set; }
        #endregion

        #region Constructeur
        public Planète()
        {

        }

        public Planète(Planète planète)
        {
            foreach (var propriété in typeof(Planète).GetProperties())
            {
                propriété.SetValue(this, propriété.GetValue(planète));
            }
        }
        #endregion

        #region Nouvelle classe
        public class PlanèteFR : Planète
        {
            #region Constructeurs
            public PlanèteFR()
            {

            }
            public PlanèteFR(Planète planète) : base(planète)
            {

            }
            #endregion
        }

        //Pour les table en anglais
        public class PlanèteEN : Planète
        {
            #region Constructeurs
            public PlanèteEN()
            {

            }
            public PlanèteEN(Planète planète) : base(planète)
            {

            }
            #endregion
        }
        #endregion
    }
}
