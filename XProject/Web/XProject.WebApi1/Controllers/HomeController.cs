using Invedia.Core.EnvUtils;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace XProject.WebApi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger _logger;

        public HomeController()
        {
            _logger = Log.Logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult<string> GetVersion()
        {
            var version = typeof(Program).Assembly.GetName().Version?.ToString();
            _logger.Information($"Version = {version}");
            return version;
        }
    }
}