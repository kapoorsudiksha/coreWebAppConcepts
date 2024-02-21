using coreConfigurationLibrary;
using Microsoft.AspNetCore.Mvc;

namespace coreWebAPIClient.Controllers
{
    public class DemoController : Controller
    {
        private readonly IConfigManager _configuration;

        public DemoController(IConfigManager configuration)
        {
            this._configuration = configuration;
        }
        public IActionResult Index()
        {
            ViewBag.strEmail = this._configuration.EmailID;
            ViewBag.strAccountKey = this._configuration.AccountKey;
            return View();
        }
    }
}
