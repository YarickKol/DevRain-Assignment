namespace BlogREST_API.DTO
{
    /// <summary>
    /// Data trasnfer object for mapping with Comment model 
    /// to read Comment object from database
    /// </summary>
    public class ReadCommentDTO
    {
        public string UserName { get; set; }       
        public string Text { get; set; }
    }
}
