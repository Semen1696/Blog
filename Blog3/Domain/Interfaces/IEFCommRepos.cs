using Blog3.Models;
using System.Linq;


namespace Blog3.Domain.Interfaces
{
    public interface IEFCommRepos
    {
        IQueryable<Comments> GetComments(int PostId);
        void SaveComment(Comments entity);
        void DeleteComment(int id);

    }
}
