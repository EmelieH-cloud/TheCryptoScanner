using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyCryptopScanner;
using MyCryptoScanner.Data.Models;

namespace MyCryptoScanner.Pages
{
    public class IndexModel : PageModel
    {
        public ViewModel? coinViewModel { get; set; }

        public ViewModel? sekViewModel { get; set; }
        public ViewModel? coinViewModelSek { get; set; }
        public string? ErrorMessage { get; set; }

        public List<string> Strings { get; set; } = new List<string>
    {
        "01coin", "0chain", "0-knowledge-network", "0-mee"
       , "0x", "0x0-ai-ai-smart-contract", "0x1-tools-ai-multi-tool",
        "0xaiswap", "0xanon", "0xblack", "0xcoco", "0xconnect"
    };

        [BindProperty]
        public string? SearchTerm { get; set; }

        public async Task<IActionResult> OnPost()
        {
            try
            {
                // Skapa ett objekt av PriceRoot
                PriceRoot secondResponse = await new ApiCaller().MakeCall<PriceRoot>($"simple/price?ids={SearchTerm}&vs_currencies=sek&include_market_cap=false&include_24hr_vol=false&include_24hr_change=false&include_last_updated_at=false&precision=18");


                sekViewModel = new ViewModel();

                foreach (var term in Strings)
                {
                    if (term.ToLower() == SearchTerm.ToLower())
                    {
                        switch (term.ToLower())
                        {
                            case "01coin":
                                if (secondResponse._01coin != null)
                                {
                                    sekViewModel.Sek = secondResponse._01coin.Sek;
                                }
                                break;
                            case "0chain":
                                if (secondResponse._0chain != null)
                                {
                                    sekViewModel.Sek = secondResponse._0chain.Sek;
                                }
                                break;
                            case "0-knowledge-network":
                                if (secondResponse._0knowledgenetwork != null)
                                {
                                    sekViewModel.Sek = secondResponse._0knowledgenetwork.Sek;
                                }
                                break;
                            case "0-mee":
                                if (secondResponse._0mee != null)
                                {
                                    sekViewModel.Sek = secondResponse._0mee.Sek;
                                }
                                break;
                            case "0x":
                                if (secondResponse._0x != null)
                                {
                                    sekViewModel.Sek = secondResponse._0x.Sek;
                                }
                                break;
                            case "0x0-ai-ai-smart-contract":
                                if (secondResponse._0x0aiaismartcontract != null)
                                {
                                    sekViewModel.Sek = secondResponse._0x0aiaismartcontract.Sek;
                                }
                                break;
                            case "0x1-tools-ai-multi-tool":
                                if (secondResponse._0x1toolsaimultitool != null)
                                {
                                    sekViewModel.Sek = secondResponse._0x1toolsaimultitool.Sek;
                                }
                                break;
                            case "0xaiswap":
                                if (secondResponse._0xaiswap != null)
                                {
                                    sekViewModel.Sek = secondResponse._0xaiswap.Sek;
                                }
                                break;
                            case "0xanon":
                                if (secondResponse._0xanon != null)
                                {
                                    sekViewModel.Sek = secondResponse._0xanon.Sek;
                                }
                                break;
                            case "0xblack":
                                if (secondResponse._0xblack != null)
                                {
                                    sekViewModel.Sek = secondResponse._0xblack.Sek;
                                }
                                break;
                            case "0xcoco":
                                if (secondResponse._0xcoco != null)
                                {
                                    sekViewModel.Sek = secondResponse._0xcoco.Sek;
                                }
                                break;
                            case "0xconnect":
                                if (secondResponse._0xconnect != null)
                                {
                                    sekViewModel.Sek = secondResponse._0xconnect.Sek;
                                }
                                break;

                            default:
                                // Hantera fallet där term inte matchar någon känd sträng
                                break;
                        }
                    }
                }
                coinViewModelSek = sekViewModel;
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