
namespace BlogREST_API.DTO
{
    /// <summary>
    /// Data trasnfer object for mapping with Blog model 
    /// to create Blog object
    /// </summary>
    public class CreateBlogDTO
    {
        public string Name { get; set; }      
        public string Topic { get; set; }
        public string Text { get; set; }        
    }
}
