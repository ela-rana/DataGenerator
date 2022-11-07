using DataGenerator.Models;
using DataGenerator.Services;
using DataGenerator.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DataGenerator.Controllers
{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IAdminRepository _adminRepository;
        public HomeController(ILogger<HomeController> logger, IAdminRepository adminRepository)
        {
            _logger = logger;
            _adminRepository = adminRepository;
        }

        public IActionResult Index()
        {
            List<string> dataTypes = Enum.GetNames(typeof(AllDataTypes)).Cast<string>().ToList();
            ViewBag.DataTypeOptions = dataTypes;
            return View();
        }

        public IActionResult GetStarted()
        {
            DataPoolViewModel dataPoolViewModel = new DataPoolViewModel();
            dataPoolViewModel.FirstNamePools = _adminRepository.GetAllFirstNames();
            dataPoolViewModel.LastNamePools = _adminRepository.GetAllLastNames();
            return View(dataPoolViewModel);
        }

        public IActionResult DisplayData(string myQuery, int myNumberOfRows)
        {
            return View();
        }

        public IActionResult CustomError()
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