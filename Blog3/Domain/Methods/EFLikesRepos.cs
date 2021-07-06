using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog3.Domain.Interfaces;
using Blog3.Models;
using Blog3.Data;
using Microsoft.EntityFrameworkCore;

namespace Blog3.Domain.Methods
{
    public class EFLikesRepos : IEFLikesRepos
    {
        private readonly ApplicationDbContext context;
        public EFLikesRepos(ApplicationDbContext context)
        {
            this.context = context;
        }
        public void SaveLike(Likes entity)
        {
            if (entity.LikeId == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
        public Likes GetLikeById(int id)
        {
            var like = context.Likes.FirstOrDefault(x => x.LikeId == id);
            return like;
        }

        public Likes GetLikeBy(int PostId, string UserId)
        {
            var like = context.Likes.FirstOrDefault(u => u.PostId == PostId && u.UserId == UserId);
            if (like != null)
                return like;
            else
                return new Likes();
        }
    }
}
