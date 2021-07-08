using System.Linq;
using Microsoft.EntityFrameworkCore;
using Blog3.Data;
using Blog3.Models;
using Blog3.Domain.Interfaces;

namespace Blog3.Domain.Methods
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
            return context.Posts.Include(post => post.Comments);
                                               
        }

        public Posts GetPostById(int id)
        {
            var t = context.Posts.Include(x => x.Comments);
            return t.FirstOrDefault(x => x.PostId == id); ;
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
