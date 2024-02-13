using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyCryptopScanner;
using MyCryptoScanner.Data.Models;

namespace MyCryptoScanner.Pages
{
    public class IndexModel : PageModel
    {
        public ViewModel? coinViewModelInfo { get; set; }
        public ViewModel? coinViewModelSek { get; set; }
        public string? ErrorMessage { get; set; }

        public List<string> Strings { get; set; } = new List<string>
    {
        "01coin", "0chain", "0-knowledge-network", "0-mee", "0vix-protocol",
        "0vm", "0x", "0x0-ai-ai-smart-contract", "0x1-tools-ai-multi-tool",
        "0xaiswap", "0xanon", "0xblack", "0xcoco", "0xconnect"
    };

        [BindProperty]
        public string? SearchTerm { get; set; }

        public async Task<IActionResult> OnPost()
        {
            try
            {
                // Använd värdet från SearchTerm direkt
                CoinInfoRoot response = await new ApiCaller().MakeCall<CoinInfoRoot>(SearchTerm.ToLower());

                coinViewModelInfo = new ViewModel
                {
                    Symbol = response.Symbol,
                    Name = response.Name,
                };


            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }

            return Page();
        }


        public async Task OnGet()
        {

        }


    }
}