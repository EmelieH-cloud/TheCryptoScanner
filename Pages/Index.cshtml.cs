using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyCryptopScanner;
using MyCryptoScanner.Data.Models;

namespace MyCryptoScanner.Pages
{
    public class IndexModel : PageModel
    {
        public ViewModel? coinViewModel { get; set; }
        public string? ErrorMessage { get; set; }

        [BindProperty]

        public string? SearchTerm { get; set; }


        public async Task OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            if (SearchTerm == null)
            {
                ErrorMessage = "Type in the name of a coin to search.";

                return Page();
            }

            try
            {
                CoinRoot response = await new ApiCaller().MakeCall<CoinRoot>(SearchTerm.ToLower());
                coinViewModel = new ViewModel
                {
                    Name = response.Name,
                    Symbol = response.Symbol,
                    LastUpdated = response.LastUpdated,
                    MarketCapRank = response.MarketCapRank,
                    Categories = response.Categories
                };
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }

            return Page();
        }
    }
}