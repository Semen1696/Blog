using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Blog3.Domain;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Blog3.Models;
using System.Linq;

namespace Blog.Controllers
{
    public class PostController : Controller
    {
        private readonly DataManager dataManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IWebHostEnvironment hostingEnvironment;

        public PostController(DataManager dataManager, UserManager<IdentityUser> userManager, IWebHostEnvironment hostingEnvironment)
        {
            this.dataManager = dataManager;
            _userManager = userManager;
            this.hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Edit(int id)
        {
            var entity = id == default ? new Posts() : dataManager.Posts.GetPostById(id);
            return View(entity);
        }

        [HttpPost]
        public IActionResult Edit(Posts model, IFormFile titleImageFile)
        {
            if (ModelState.IsValid)
            {
                if (titleImageFile != null)
                {
                    model.TitleImagePath = titleImageFile.FileName;
                    using (var stream = new FileStream(Path.Combine(hostingEnvironment.WebRootPath, "images/", titleImageFile.FileName), FileMode.Create))
                    {
                        titleImageFile.CopyTo(stream);
                    }
                }
                model.UserId = _userManager.GetUserId(User);
                model.Author = _userManager.GetUserName(User);
                dataManager.Posts.SavePost(model);
                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }

        public IActionResult Show(int id)
        {
            string UserId = _userManager.GetUserId(User);
            var Like = dataManager.Likes.GetLikeBy(id, UserId);
            ViewBag.Like = Like.Like;
            ViewBag.Dislike = Like.Dislike;
            ViewBag.PostId = id;
            ViewBag.UserId = Like.UserId;
            
           var model = dataManager.Posts.GetPostById(id);
            
            return View(model);
        }

        public IActionResult Delete(int id)
        {
            dataManager.Posts.DeletePost(id);
            return RedirectToAction("Index", "Home");
        }

        //[HttpPost]
        //public IActionResult AddLike(int LikeCount, int PostId, int DisCount, string Mark, int LikeId)
        //{
        //    Likes likes;
        //    if (LikeId == default)
        //    {
        //        likes = new()
        //        {
        //            LikeId = LikeId,
        //            UserId = _userManager.GetUserId(User),
        //            PostId = PostId
        //        };
        //    }
        //    else
        //    {
        //        likes = dataManager.Likes.GetLikeById(LikeId);
        //    }

        //    Posts post = dataManager.Posts.GetPostById(PostId);
        //    if (Mark == "Like")
        //    {
        //        LikeCount++;
        //        if (DisCount != 0)
        //            DisCount--;
        //        likes.Like = true;
        //        likes.Dislike = false;
        //        post.LikesCount = LikeCount;
        //        post.DislikesCount = DisCount;
        //    }
        //    else
        //    {
        //        if (Mark == "DisLike")
        //        {
        //            DisCount++;
        //            if (LikeCount != 0)
        //                LikeCount--;
        //            likes.Like = false;
        //            likes.Dislike = true;
        //            post.DislikesCount = DisCount;
        //            post.LikesCount = LikeCount;
        //        }
        //    }



        //    dataManager.Posts.SavePost(post);
        //    dataManager.Likes.SaveLike(likes);
        //    ViewBag.UserId = _userManager.GetUserId(User);

        //    return PartialView("AddLike", post);
        //}



    }
}
