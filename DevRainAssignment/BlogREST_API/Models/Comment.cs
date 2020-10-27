using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogREST_API.Models
{
    /// <summary>
    /// Comment model
    /// </summary>
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string UserName { get; set; }        

        [Required]
        public string Text { get; set; }
        
        public DateTime Published { get; set; }
        public virtual int BlogId { get; set; }

        [ForeignKey("BlogId")]
        public virtual Blog Blog { get; set; } // reference to Blog, where comment was posted
    }
}
