using Microsoft.AspNetCore.Mvc;
using Play.Models;
using Play.Services;

namespace Play.Controllers
{
    public class TodoController : Controller
    {
        private readonly ITodoService _service;

        public TodoController(ITodoService service)
        {
            _service = service;
        }

        public IActionResult Index() => View(_service.GetAll());

        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(TodoItem item)
        {
            _service.Add(item);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id) => View(_service.Get(id));

        [HttpPost]
        public IActionResult Edit(TodoItem item)
        {
            _service.Update(item);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return RedirectToAction("Index");
        }
    }
}