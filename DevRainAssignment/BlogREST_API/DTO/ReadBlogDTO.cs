namespace BlogREST_API.DTO
{
    /// <summary>
    /// Data trasnfer object for mapping with Blog model 
    /// to read Blog object from database
    /// </summary>
    public class ReadBlogDTO
    {           
        public string Name { get; set; }        
        public string Topic { get; set; }        
        public string Text { get; set; }      
    }
}
