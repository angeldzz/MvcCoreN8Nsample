using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcCoreN8Nsample.Models;
using MvcCoreN8Nsample.Services;

namespace MvcCoreN8Nsample.Controllers
{
    public class HomeController : Controller
    {
        private N8NService service;
        public HomeController(N8NService service)
        {
            this.service = service;
        }
        public IActionResult Index()
        {
            List<string> urlList = new List<string>();
            urlList.Add("https://www.marca.com/");
            urlList.Add("https://loldle.org/");
            ViewData["URLS"] = urlList;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(string paginaweb)
        {
            Response response = await service.Execute(paginaweb);
            List<string> urlList = new List<string>();
            urlList.Add("https://www.marca.com/");
            urlList.Add("https://loldle.org/");
            ViewData["URLS"] = urlList;
            return View(response.Imagenes);
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
