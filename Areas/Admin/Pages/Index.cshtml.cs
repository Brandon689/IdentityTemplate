using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IdentityTemplate.Areas.Admin.Pages
{
    [Authorize(Roles = "Admin")]
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
