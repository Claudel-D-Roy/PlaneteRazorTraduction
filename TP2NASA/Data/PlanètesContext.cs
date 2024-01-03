using Microsoft.EntityFrameworkCore;
using TP2NASA.Models;
using static TP2NASA.Models.Caractéristique;
using static TP2NASA.Models.Planète;

namespace TP2NASA.Data
{
    /// <summary>
    /// Auteur: Claudel D. Roy, WIllaim Jubinville, Mathieu Duval
    /// Description: Classe permettant de communiquer avec la base de données avec EntityFrameworkCore
    /// Date: 11-25-2022
    /// </summary>
    public class PlanètesContext : DbContext
    {
        #region Propriétés
        public DbSet<PlanèteFR> Planètes { get; set; }
        public DbSet<PlanèteEN> PlanètesEN { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<CaractéristiqueFR> Caractéristiques { get; set; }
        public DbSet<CaractéristiqueEN> CaractéristiquesEN { get; set; }
        #endregion

        #region Constructeur
        /// <summary>
        /// Auteur: Claudel D. Roy, WIllaim Jubinville, Mathieu Duval
        /// Description: Constructeur pour les options de la base de données
        /// Date: 11-25-2022
        /// </summary>
        public PlanètesContext(DbContextOptions options)
            : base(options) {}
        #endregion
    }
}
