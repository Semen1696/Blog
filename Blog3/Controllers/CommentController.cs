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
        //private readonly Posts posts;
        private readonly UserManager<IdentityUser> _userManager;
        public CommentController(DataManager dataManager, UserManager<IdentityUser> userManager)
        {
            this.dataManager = dataManager;
            this._userManager = userManager;
            //this.posts = posts;
        }
        public IActionResult Index(int id)
        {
            ViewBag.UserId = _userManager.GetUserId(User);
            return View(dataManager.Comments.GetComments(id));
        }

       [Authorize]
        public IActionResult AddComm(int id)
        {
            ViewBag.PostId = id;
            return View();
        }

        //[HttpPost]
        //public IActionResult PostComments(string mesage)
        //{
        //    string n = mesage;
        //    //if (ModelState.IsValid)
        //    //{
        //    //    model.Author = _userManager.GetUserName(User);
        //    //    model.UserId = _userManager.GetUserId(User);               
        //    //    dataManager.Comments.SaveComment(model);
        //    //    //posts.Comments.Add(model);
        //    //    return RedirectToAction("Index", "Home");
        //    //}
        //    return View();
        //}
        [HttpPost]
        public IActionResult Delete(int id)
        {
            dataManager.Comments.DeleteComment(id);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Back()
        {
            return RedirectToAction("Index", "Home");
        }

    }
}
