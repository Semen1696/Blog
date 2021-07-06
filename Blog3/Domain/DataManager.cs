using Blog3.Domain;
using Blog3.Domain.Interfaces;


namespace Blog3.Domain
{
    public class DataManager
    {
        public IEFRepos Posts { get; set; }

        public IEFCommRepos  Comments { get; set; }

        public IEFLikesRepos Likes { get; set; }

        public DataManager(IEFRepos PostsRepos, IEFCommRepos CommentsRepos, IEFLikesRepos LikesRepos)
        {
            Posts = PostsRepos;
            Comments = CommentsRepos;
            Likes = LikesRepos;
        }
    }
}
