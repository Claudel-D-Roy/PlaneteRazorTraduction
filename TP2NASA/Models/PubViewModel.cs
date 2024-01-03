using System.ComponentModel.DataAnnotations;
/// <summary>
/// Auteur: Claudel D. Roy, Willaim Jubinville, Mathieu Duval
/// Description: ViewModel pour les pubs.
/// Date: 12-16-2022
/// </summary>
/// 
namespace TP2NASA.Models
{
    public class PubViewModel
    {
        
        public int Date { get; set; }
        public string? Message { get; set; }
       
    }
}
