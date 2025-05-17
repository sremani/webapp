using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace webapp.Pages
{
    public class IndexModel : LoggedPageModel<IndexModel>
    {
        public IndexModel(ILogger<IndexModel> logger) : base(logger)
        {
        }

        public void OnGet()
        {

        }
    }
}