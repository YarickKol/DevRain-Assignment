using System;

namespace BlogREST_API.DTO
{
    public class CreateBlogDTO
    {
        public string Name { get; set; }      
        public string Topic { get; set; }
        public string Text { get; set; }
        public DateTime Published { get; set; }
    }
}
