using Blog_post_API.Models;

namespace Blog_post.Services
{
    public interface IBlogService
    {
        public Task<List<Blog>> GetBlogs();
    }
}
