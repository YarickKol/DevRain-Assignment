
namespace BlogREST_API.DTO
{
    /// <summary>
    /// Data trasnfer object for mapping with Comment model 
    /// to create Comment object
    /// </summary>
    public class CreateCommentDTO
    {        
        public string UserName { get; set; }
        public string Text { get; set; }        
        public int BlogId { get; set; }
    }
}
