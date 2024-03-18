using Blog_post_API.Models;
using System.Net.Http.Json;

namespace Blog_post.Services
{
    public class BlogService : IBlogService
    {
        private readonly HttpClient _http;
        public BlogService(HttpClient http)
        {
            _http = http;
        }
        public async Task<List<Blog>> GetBlogs()
        {


            var response = await _http.GetFromJsonAsync<List<Blog>>("/api/Blogs");
            return response;
        }
    }
}
