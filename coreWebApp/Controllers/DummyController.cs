using coreConfigurationLibrary;
using Microsoft.AspNetCore.Mvc;

namespace coreWebApp.Controllers
{
    public class DummyController : Controller
    {
        private readonly IConfigManager _configuration;

        public DummyController(IConfigManager configuration)
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
