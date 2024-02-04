using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using YUJCSR.Web.CSO.BusinessManager;
using YUJCSR.Web.Portal.Models;

namespace YUJCSR.Web.Portal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        IConfiguration _config;
        

        public HomeController(ILogger<HomeController> logger, IConfiguration iConfig)
        {
            _logger = logger;
            _config = iConfig;
        }

        public async Task<IActionResult> Index()
        {
            ProjectManager manager = new ProjectManager(_config);
            var data = manager.GetProjects().Take(3);

            ViewBag.Projects = data;
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }

        public IActionResult Impact()
        {
            return View();
        }
        public IActionResult CSO()
        {
            CSOManager obj = new CSOManager(_config);
            var list = obj.GetCSO();
            //var list = (APIResponse)data.Result;
            ViewBag.CSO = list;
            return View();
        }
        public IActionResult Companies()
        {
            CSOManager obj = new CSOManager(_config);
            var list = obj.GetCSO();
            //var list = (APIResponse)data.Result;
            ViewBag.CSO = list;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
