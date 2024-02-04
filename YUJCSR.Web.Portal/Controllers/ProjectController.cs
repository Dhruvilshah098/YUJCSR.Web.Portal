using Microsoft.AspNetCore.Mvc;
using System;
using YUJCSR.Web.CSO.BusinessManager;

namespace YUJCSR.Web.Portal.Controllers
{
    public class ProjectController : Controller
    {
        IConfiguration _config;


        public ProjectController(IConfiguration iConfig)
        {
            _config = iConfig;
        }
        public async Task<IActionResult> Index()
        {
            ProjectManager obj = new ProjectManager(_config);
            var list = obj.GetProjects();
            //var list = (APIResponse)data.Result;
            ViewBag.Projects =  list;
            return View();
        }

        public IActionResult Details(string id)
        {
            ProjectManager obj = new ProjectManager(_config);
            var project = obj.GetProjects().FirstOrDefault(x => x.ProjectID == id);
            //var list = (APIResponse)data.Result;
            ViewBag.Project = project;
            return View();
        }
    }
}