using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace webapp.Pages
{
    public class PrivacyModel : LoggedPageModel<PrivacyModel>
    {
        public PrivacyModel(ILogger<PrivacyModel> logger) : base(logger)
        {
        }

        public void OnGet()
        {
        }
    }
}