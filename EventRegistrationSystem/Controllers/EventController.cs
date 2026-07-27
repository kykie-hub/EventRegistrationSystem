using Microsoft.AspNetCore.Mvc;
using EventRegistrationSystem.Models;

namespace EventRegistrationSystem.Controllers
{
    public class EventController : Controller
    {
        private static List<Event> events = new List<Event>();

        public IActionResult Index()
        {
            return View(events);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Event newEvent)
        {
            if (ModelState.IsValid)
            {
                newEvent.Id = events.Count + 1;
                events.Add(newEvent);

                return RedirectToAction("Index");
            }

            return View(newEvent);
        }
    }
}