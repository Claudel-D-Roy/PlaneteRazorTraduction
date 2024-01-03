using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
/// <summary>
/// Auteur: Claudel D. Roy, WIllaim Jubinville, Mathieu Duval
/// Description: Le model de l'Index
/// Date: 11-25-2022
/// </summary>
namespace TP2NASA.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}