using Blog3.Domain;
using Blog3.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Blog3.Controllers
{
    public class LikeController : Controller
    {
        private readonly DataManager _dataManager;
        private readonly UserManager<IdentityUser> _userManager;
        public LikeController(DataManager dataManager, UserManager<IdentityUser> userManager)
        {
            _dataManager = dataManager;
            _userManager = userManager;
        }

        [HttpPost, ActionName("AddDislike")]
        public IActionResult AddDislike(LikeModel likes)
        {
            var UserId = _userManager.GetUserId(User);

            Posts posts = _dataManager.Posts.GetPostById(likes.PostId);
            if (likes.UserId != null && posts.LikesCount != 0)
            {
                posts.LikesCount--;
            }
            posts.DislikesCount++;

            Likes like = _dataManager.Likes.GetLikeBy(likes.PostId, UserId);
            like.Like = false;
            like.Dislike = true;
            like.PostId = likes.PostId;
            like.UserId = UserId;


            likes.LikeCount = posts.LikesCount;
            likes.DislikeCount = posts.DislikesCount;
            likes.CanLike = like.Like;
            likes.CanDislike = like.Dislike;
            likes.UserId = UserId;


            _dataManager.Posts.SavePost(posts);
            _dataManager.Likes.SaveLike(like);
            return PartialView("~/Views/Like/AddLike.cshtml", likes);
        }


        [HttpPost, ActionName("AddLike")]
        public IActionResult AddLike(LikeModel likes)
        {
            var UserId = _userManager.GetUserId(User);

            Posts posts = _dataManager.Posts.GetPostById(likes.PostId);
            posts.LikesCount++;
            if (likes.UserId != null && posts.DislikesCount != 0)
            {
                posts.DislikesCount--;
            }

            Likes like = _dataManager.Likes.GetLikeBy(likes.PostId, UserId);
            like.Like = true;
            like.Dislike = false;
            like.PostId = likes.PostId;
            like.UserId = UserId;


            likes.LikeCount = posts.LikesCount;
            likes.DislikeCount = posts.DislikesCount;
            likes.CanLike = like.Like;
            likes.CanDislike = like.Dislike;
            likes.UserId = UserId;


            _dataManager.Posts.SavePost(posts);
            _dataManager.Likes.SaveLike(like);


            return PartialView(likes);
        }

    }
}
