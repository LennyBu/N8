using Microsoft.AspNetCore.Mvc;
using N8_Data.Entities;

namespace N8_UI.Controllers
{
    public class EventController : Controller
    {
        // list of all events 
        public IActionResult EventPage()
        {
            return View();
        }

        public IActionResult Detail(Event e) 
        {
            return View(e);
        }
    }
}
