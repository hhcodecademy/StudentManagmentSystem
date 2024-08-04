using Microsoft.AspNetCore.Mvc;
using StudentManagmentSystem.DAL.Models;
using StudentManagmentSystem.DAL.Repository.Interface;

namespace StudentManagmentSystem.WebUI.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IStudentRepository _repository;

        public StudentsController(IStudentRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            var students = _repository.GetAll().ToList();
            return View(students);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student model)
        {
            _repository.Add(model);
            return View();
        }
    }
}
