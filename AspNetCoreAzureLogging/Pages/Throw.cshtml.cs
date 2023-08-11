using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetCoreAzureLogging.Pages;

public class ThrowModel : PageModel
{
    public void OnGet()
    {
        throw new Exception("FIND ME exception");
    }
}
