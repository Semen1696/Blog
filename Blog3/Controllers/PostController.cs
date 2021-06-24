﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Blog.Domain;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Blog3.Models;

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
            ViewBag.PostId = id;
            ViewBag.UserId = _userManager.GetUserId(User);
            return View(dataManager.Posts.GetPostById(id));
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            dataManager.Posts.DeletePost(id);
            return View();
        }

        [HttpPost]
        public IActionResult PostComments(string mesage, int PostId)
        {
            Comments comments = new Comments();
            comments.UserId = _userManager.GetUserId(User);
            comments.Text = mesage;
            comments.PostId = PostId;
            comments.Author = _userManager.GetUserName(User);
            dataManager.Comments.SaveComment(comments);
            ViewBag.UserId = _userManager.GetUserId(User);
            //if (ModelState.IsValid)
            //{
            //    model.Author = _userManager.GetUserName(User);
            //    model.UserId = _userManager.GetUserId(User);               
            //    dataManager.Comments.SaveComment(model);
            //    //posts.Comments.Add(model);
            //    return RedirectToAction("Index", "Home");
            //}
            //var dv = dataManager.Comments.GetComments(PostId);
            return PartialView(dataManager.Comments.GetComments(PostId));

        }

    }
}
