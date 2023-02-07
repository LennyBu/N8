using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using N8_UI.Models;

namespace N8_UI.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> LoginAccount()
        {
            var loggedOn = new LoginViewModel();
            return View(loggedOn);
        }
        [HttpPost]
        public async Task<ActionResult> LoginAccount(LoginViewModel loggedOn)
        {
            string username = "1";
            string password = "2";
            if (username != loggedOn.username)
            {
                return RedirectToAction(nameof(LoginAccount));
            }
            if (password != loggedOn.password)
            {
                return RedirectToAction(nameof(LoginAccount));
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
