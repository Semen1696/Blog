using Blog3.Domain;
using Blog3.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


namespace Blog3.Controllers
{
    public class CommentController : Controller
    {
        private readonly DataManager _dataManager;
        private readonly UserManager<IdentityUser> _userManager;
        public CommentController(DataManager dataManager, UserManager<IdentityUser> userManager)
        {
            _dataManager = dataManager;
            _userManager = userManager;
        }
        public IActionResult Index(int id)
        {
            ViewBag.UserId = _userManager.GetUserId(User);
            return View(_dataManager.Comments.GetComments(id));
        }
     

        [HttpPost]
        public IActionResult PostComments(string message, int postId)
        {

            Comments comments = new()
            {
                UserId = _userManager.GetUserId(User),
                Text = message,
                PostId = postId,
                Author = _userManager.GetUserName(User)
            };
            _dataManager.Comments.SaveComment(comments);
            ViewBag.UserId = _userManager.GetUserId(User);

            return PartialView("~/Views/Comment/PostComments.cshtml", _dataManager.Comments.GetComments(postId));
        }

        public IActionResult Delete(int id, int postid)
        {
            _dataManager.Comments.DeleteComment(id);
            ViewBag.UserId = _userManager.GetUserId(User);
            return PartialView("~/Views/Comment/PostComments.cshtml", _dataManager.Comments.GetComments(postid));
        }


    }
}
