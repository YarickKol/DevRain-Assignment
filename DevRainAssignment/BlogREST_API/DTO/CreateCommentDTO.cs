using BlogREST_API.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogREST_API.DTO
{
    public class CreateCommentDTO
    {        
        public string UserName { get; set; }
        public string Text { get; set; }        
        public int BlogId { get; set; }
    }
}
