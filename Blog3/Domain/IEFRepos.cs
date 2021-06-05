using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog3.Models;

namespace Blog.Domain
{
    public interface IEFRepos
    {
        IQueryable <Posts> GetPosts();
        void SavePost(Posts entity);
        
        void DeletePost(int id);

        
    }
}
