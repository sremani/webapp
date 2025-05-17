using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace webapp.Pages
{
    /// <summary>
    /// Base page model that provides a strongly typed <see cref="ILogger"/> instance.
    /// </summary>
    /// <typeparam name="T">The page model type.</typeparam>
    public abstract class LoggedPageModel<T> : PageModel
    {
        protected readonly ILogger<T> Logger;

        protected LoggedPageModel(ILogger<T> logger)
        {
            Logger = logger;
        }
    }
}
