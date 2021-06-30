using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog3.Models;

namespace Blog3.Domain.Interfaces
{
    public interface IEFRepos
    {
        IQueryable <Posts> GetPosts();
        void SavePost(Posts entity);
        Posts GetPostById(int id);
        void DeletePost(int id);
        


    }
}
