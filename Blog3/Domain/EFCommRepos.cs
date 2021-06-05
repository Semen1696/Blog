﻿using Blog3.Data;
using Blog3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Blog3.Domain
{
    public class EFCommRepos : IEFCommRepos
    {
        private readonly ApplicationDbContext context;
        public EFCommRepos(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IQueryable<Comments> GetComments()
        {
            return context.Comments;
        }
        public void SaveComment(Comments entity)
        {

            if (entity.CommId == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}