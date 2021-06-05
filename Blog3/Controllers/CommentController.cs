using Blog.Domain;
using Blog3.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


namespace Blog3.Controllers
{
    public class CommentController : Controller
    {
        private readonly DataManager dataManager;
        private readonly UserManager<IdentityUser> _userManager;
        public CommentController(DataManager dataManager, UserManager<IdentityUser> userManager)
        {
            this.dataManager = dataManager;
            this._userManager = userManager;
        }
        public IActionResult Index(int Id)
        {
            ViewBag.PostId = Id;
            return View(dataManager.Comments.GetComments());
        }

       [Authorize]
        public IActionResult AddComm(int Id)
        {
            ViewBag.PostId = Id;
            return View();
        }

        [HttpPost]
        public IActionResult AddComm(Comments model)
        {
            if (ModelState.IsValid)
            {
                model.Author = _userManager.GetUserName(User);
                dataManager.Comments.SaveComment(model);
                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }

        public IActionResult Back()
        {
            return RedirectToAction("Index", "Home");
        }

    }
}
