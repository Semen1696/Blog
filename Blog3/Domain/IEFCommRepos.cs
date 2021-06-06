using Blog3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog3.Domain
{
    public interface IEFCommRepos
    {
        IQueryable<Comments> GetComments(int PostId);
        void SaveComment(Comments entity);
        void DeleteComment(int id);

    }
}
