using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Test.Models;
using Test.Views.Home;

namespace Test.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult NewsList(string lang)
        {
            var model = NewsVM.data.Select(x => new NewsShow()
                {
                    ID = x.ID,
                    Thumb = x.Thumb,
                    Slag = x.Slag,
                    Title = x.Info.Where(y => y.Lang.Equals(lang)).FirstOrDefault().Title,
                    Description = x.Info.Where(y => y.Lang.Equals(lang)).FirstOrDefault().Desription,
                    Language = x.Info.Where(y => y.Lang.Equals(lang)).FirstOrDefault().Lang
            }).ToList();
            return View(model);
        }

        public IActionResult News(int id, string lang)
        {
            var model = NewsVM.data.Where(x => x.ID == id).FirstOrDefault();
            var modelLang = model.Info.Where(x => x.Lang.Equals(lang)).FirstOrDefault();
            NewsShow modelResult = new NewsShow()
            {
                ID = model.ID,
                Thumb = model.Thumb,
                Language = modelLang.Lang,
                Title = modelLang.Title,
                Description = modelLang.Desription,
                Slag = model.Slag
            };
            return View(modelResult);
        }

        public IActionResult Index()
        {
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
