using Blog3.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;
        private readonly UserManager<IdentityUser> _userManager;
        public HomeController(DataManager dataManager, UserManager<IdentityUser> userManager)
        {
            this.dataManager = dataManager;
            _userManager = userManager;
        }
        [Authorize]
        public IActionResult Index()
        {
            ViewBag.UserId = _userManager.GetUserId(User);
            return View(dataManager.Posts.GetPosts());
        }
    }
}
