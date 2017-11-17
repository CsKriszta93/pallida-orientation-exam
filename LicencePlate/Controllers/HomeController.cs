using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LicencePlate.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LicencePlate.Controllers
{
    public class HomeController : Controller
    {
        LicencePlateRepository LicencePlateRepository;

        public HomeController(LicencePlateRepository licencePlateRepository)
        {
            LicencePlateRepository = licencePlateRepository;
        }
        [HttpGet]
        [Route("")]
        public IActionResult Search()
        {
            return View();
        }

        [HttpPost]
        [Route("/result")]
        public IActionResult SearchResult(string licenceplate)
        {
            return View(LicencePlateRepository.GetLicencePlate(licenceplate));
        }
    }
}
