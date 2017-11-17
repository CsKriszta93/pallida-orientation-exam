using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LicencePlate.Repositories;
using LicencePlate.Models;

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
        public IActionResult Search(string input)
        {
            return View();
        }

        [HttpGet]
        [Route("search/police")]
        public IActionResult PoliceCars()
        {
            return View(LicencePlateRepository.OnlyPoliceCars());
        }

        [HttpGet]
        [Route("/search/diplomat")]
        public IActionResult DiplomatCars()
        {
            return View(LicencePlateRepository.OnlyDiplomats());
        }

        [HttpGet]
        [Route("/api/search/{brand}")]
        public IActionResult ApiBrands([FromBody] LicencePlateClass brand)
        {
            var brands = LicencePlateRepository.SameBrand(brand);
            foreach (var car in brands)
            {
                return Json(new { plate = car.plate, car_brand = car.car_brand, car_model = car.car_model, year = car.year, color = car.color });
            }     
        }    

        [HttpGet]
        [Route("/search/{brand}")]
        public IActionResult Brands(LicencePlateClass brand)
        {
            return View(LicencePlateRepository.SameBrand(brand));
        }

        [HttpPost]
        [Route("/result")]
        public IActionResult SearchResult(string licenceplate)
        {
            return View(LicencePlateRepository.GetLicencePlate(licenceplate));
        }
    }
}
