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
        public IActionResult Index(int id)
        {
            ViewBag.UserId = _userManager.GetUserId(User);
            return View(dataManager.Comments.GetComments(id));
        }
     

        [HttpPost]
        public IActionResult PostComments(string mesage, int PostId)
        {

            Comments comments = new()
            {
                UserId = _userManager.GetUserId(User),
                Text = mesage,
                PostId = PostId,
                Author = _userManager.GetUserName(User)
            };
            dataManager.Comments.SaveComment(comments);
            ViewBag.UserId = _userManager.GetUserId(User);

            return PartialView(dataManager.Comments.GetComments(PostId));
        }

        public IActionResult Delete(int id, int postid)
        {
            dataManager.Comments.DeleteComment(id);
            ViewBag.UserId = _userManager.GetUserId(User);
            return PartialView("~/Views/Comment/PostComments.cshtml", dataManager.Comments.GetComments(postid));
        }


    }
}
