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
            context.Entry(entity).State = EntityState.Added;
            context.SaveChanges();
        }
    }
}
