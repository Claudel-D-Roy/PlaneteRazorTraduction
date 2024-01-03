using System.ComponentModel.DataAnnotations;
/// <summary>
  /// Auteur: Claudel D. Roy, Willaim Jubinville, Mathieu Duval
  /// Description: Classe des pubs.
  /// Date: 12-16-2022
  ///
///</ summary >
///
namespace TP2NASA.Models
{
    public class Pub
    {
   
        public int Date { get; set; }
        public string? Message { get; set; }
    }
}
