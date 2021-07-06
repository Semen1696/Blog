using Blog3.Models;


namespace Blog3.Domain.Interfaces
{
    public interface IEFLikesRepos
    {
        Likes GetLikeById(int id);
        Likes GetLikeBy(int PostId, string UserId);
        void SaveLike(Likes entity);
    }
}
