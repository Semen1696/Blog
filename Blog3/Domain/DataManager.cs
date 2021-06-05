using Blog3.Domain;

namespace Blog.Domain
{
    public class DataManager
    {
        public IEFRepos Posts { get; set; }

        public IEFCommRepos  Comments { get; set; }

        public DataManager(IEFRepos PostsRepos, IEFCommRepos CommentsRepos)
        {
            Posts = PostsRepos;
            Comments = CommentsRepos;
        }
    }
}
