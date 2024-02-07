using FirstrazorPage.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FirstrazorPage.Pages.Food
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        [BindProperty(SupportsGet = true)]
        public FoodModel Food { get; set; } = new();
        public void OnGet()
        {
            _logger.LogInformation("GET request to DataEntry page");
            
        }

      
        public void OnPost()
        {
            _logger.LogInformation("POST request to Index page");
           
        }
    }
}
