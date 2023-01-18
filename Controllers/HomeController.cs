using Microsoft.AspNetCore.Mvc;
using StaffManagement.Models;
using StaffManagement.ViewModels;

namespace StaffManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStaffRepository _staffRepository;

        public HomeController(IStaffRepository staffRepository)
        {
            _staffRepository = staffRepository;
        }

        public ViewResult Index()
        {
            HomeIndexViewModel viewModel = new HomeIndexViewModel()
            {
                Staffs = _staffRepository.GetAll(),
                Title = "Barcha xodimlar ro'yhati"
            };
            return View(viewModel);
        }

        public ViewResult Details()
        {
            HomeDetailsViewModel viewModel = new HomeDetailsViewModel()
            {
                Staff = _staffRepository.Get(3),
                Title = "Staff Details"
            };
            return View(viewModel);
        }

        public JsonResult Data()
        {
            return Json(new { id = 17, name = "Said", lastname = "Abu" });
        }

        public string Staff()
        {
            return _staffRepository.Get(3).FirstName;
        }
    }
}
