using BlogREST_API.Models;

namespace BlogREST_API.DTO
{
    public class CreateCommentDTO
    {
        public Blog Blog { get; set; }
        public string UserName { get; set; }
        public string Text { get; set; }
    }
}
