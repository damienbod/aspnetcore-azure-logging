using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetCoreAzureLogging.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        _logger.LogTrace("my home trace");
        _logger.LogDebug("my home debug");
        _logger.LogInformation("my home info");
        _logger.LogError("my home error");
        _logger.LogWarning("my home warning");
    }
}