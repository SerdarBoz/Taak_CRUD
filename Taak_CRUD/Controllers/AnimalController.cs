using Microsoft.AspNetCore.Mvc;
using Taak_CRUD.Models;

namespace Taak_CRUD.Controllers
{
    public class AnimalController : Controller
    {
        private AnimalRepository animals;

        public AnimalController()
        {
            animals = new AnimalRepository();
        }
        public IActionResult Index()
        {
            return View(animals.GetAnimals());
        }
        public IActionResult Details(int id) 
        {
            return View(animals.LookForAnimal(id));
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Animal animal)
        {
            animals.AddNewAnimal(animal);
            return RedirectToAction("Index");
        }
        
        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(animals.LookForAnimal(id));
        }

        [HttpPost]
        public IActionResult Edit(int id, Animal animal)
        {
            animals.UpdateAnimal(id, animal);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            animals.DeleteAnimal(id);
            return RedirectToAction("Index");
        }
    }
}
