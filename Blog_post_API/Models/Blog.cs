using System.ComponentModel.DataAnnotations.Schema;

namespace Blog_post_API.Models
{
    public class Blog
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Created_date { get; set; }
        public DateTime Last_updated_date { get; set; }
    }
}
