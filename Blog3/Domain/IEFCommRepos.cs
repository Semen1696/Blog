using Blog3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog3.Domain
{
    public interface IEFCommRepos
    {
        IQueryable<Comments> GetComments();
        void SaveComment(Comments entity);
    }
}
