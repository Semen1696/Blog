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

        [HttpPost]
        public IActionResult AddLike(int PostId, string UserId)
        {

            Posts posts = _dataManager.Posts.GetPostById(PostId);
            posts.LikesCount++;
            if (UserId != null && posts.DislikesCount != 0)
            {
                posts.DislikesCount--;
            }

            var NewUserId = _userManager.GetUserId(User);
            Likes like = _dataManager.Likes.GetLikeBy(PostId, NewUserId);
            like.Like = true;
            like.Dislike = false;
            like.PostId = PostId;
            like.UserId = UserId;
            like.UserId = UserId == null ? NewUserId : UserId;

            LikeModel likeModel = new()
            {
                PostId = PostId,
                LikeCount = posts.LikesCount,
                DislikeCount = posts.DislikesCount,
                CanLike = like.Like,
                CanDislike = like.Dislike,
                UserId = like.UserId
            };

            _dataManager.Posts.SavePost(posts);
            _dataManager.Likes.SaveLike(like);


            return PartialView(likeModel);
        }

        [HttpPost]
        public IActionResult AddDislike(int PostId, string UserId)
        {
            
            Posts posts = _dataManager.Posts.GetPostById(PostId);
            if (UserId != null && posts.LikesCount != 0)
            {
                posts.LikesCount--;
            }
            posts.DislikesCount++;

            var NewUserId = _userManager.GetUserId(User);
            Likes like = _dataManager.Likes.GetLikeBy(PostId, NewUserId);
            like.Like = false;
            like.Dislike = true;
            like.PostId = PostId;
            like.UserId = UserId == null ? NewUserId : UserId;

            LikeModel likeModel = new()
            {
                PostId = PostId,
                LikeCount = posts.LikesCount,
                DislikeCount = posts.DislikesCount,
                CanLike = like.Like,
                CanDislike = like.Dislike,
                UserId = like.UserId
            };

            _dataManager.Posts.SavePost(posts);
            _dataManager.Likes.SaveLike(like);
            return PartialView("~/Views/Like/AddLike.cshtml", likeModel);
        }


        

    }
}
