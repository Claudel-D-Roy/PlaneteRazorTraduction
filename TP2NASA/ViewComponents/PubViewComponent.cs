using Microsoft.AspNetCore.Mvc;
using TP2NASA.Models;
using TP2NASA.Services;
/// <summary>
/// Auteur: Claudel D. Roy, Willaim Jubinville, Mathieu Duval
/// Description: ViewComponenets pour les pubs.
/// Date: 12-16-2022
/// </summary>
/// 
namespace TP2NASA.ViewComponents
{
    public class PubViewComponent : ViewComponent
    {

        #region Champs
        private IPubService _service = null;
        #endregion

        #region Constructeur
        public PubViewComponent(IPubService service)
        {
            _service = service;
        }
        #endregion

        #region Propriété
        public PubViewModel ViewModel { get; set; } = new();
        #endregion

        public IViewComponentResult Invoke(int date, string? message)
        {
            DateTime dt = DateTime.Now;
            var jours = dt.Day;
            date = date - jours;

            ViewModel.Date = date;
            ViewModel.Message = string.Format(message!, date)!;
            return View(this); 
        }


    }
}
