using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Blog3.Data;
using Blog3.Models;

namespace Blog.Domain
{
    public class EFRepos : IEFRepos

    {
        private readonly ApplicationDbContext  context;
        public EFRepos(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IQueryable <Posts> GetPosts()
        {
            return context.Posts;
        }
        public void SavePost(Posts entity)
        {
            if (entity.PostId == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        

        public void DeletePost(int id)
        {
            context.Posts.Remove(new Posts() { PostId = id });
            context.SaveChanges();
        }
    }
}
