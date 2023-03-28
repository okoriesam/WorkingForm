using MetrosoftForm.Models;
using MetrosoftForm.Models.Dto;
using MetrosoftForm.Services.IRepository;
using MetrosoftForm.Services.Repository;
using Microsoft.AspNetCore.Mvc;

namespace MetrosoftForm.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IUsersRepository<Employee> _usersRepository;
        public EmployeeController(IUsersRepository<Employee> usersRepository)
        {
            _usersRepository= usersRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(EmployeesDto employees)
        {
            var employe = await _usersRepository.Create(employees);
            return View(employe);
        }
    }
}
