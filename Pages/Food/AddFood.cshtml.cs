using FirstrazorPage.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection;

namespace FirstrazorPage.Pages.Food
{
    public class AddFoodModel : PageModel
    {


        [BindProperty(SupportsGet = true)]
        public FoodModel Food { get; set; } = new FoodModel();

        private readonly ILogger<AddFoodModel> _logger;

        public AddFoodModel(ILogger<AddFoodModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
            _logger.LogInformation("Get From AddFood");
        }

        public IActionResult OnPostRedirect()

        {
            if (string.IsNullOrEmpty(Food.Name) || string.IsNullOrEmpty(Food.Description))
            {
                ModelState.AddModelError(string.Empty, "All fields are required.");
                return Page();
            }
            _logger.LogInformation("Post and redirect From AddFood");
            return RedirectToPage("Index", Food);
        }

        public IActionResult OnPost()
        {
            if (string.IsNullOrEmpty(Food.Name) || string.IsNullOrEmpty(Food.Description))
            {
                ModelState.AddModelError(string.Empty, "All fields are required.");
                return Page();
            }

            return Page();

        }
    }
}
