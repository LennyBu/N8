using Microsoft.AspNetCore.Mvc;

namespace N8_UI.Controllers
{
    public class EventController : Controller
    {
        // list of all events 
        public IActionResult EventPage()
        {
            return View();
        }
    }
}
