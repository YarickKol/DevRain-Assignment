using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlogREST_API.Models
{
    /// <summary>
    /// Blog model class
    /// </summary>
    public class Blog
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string Name { get; set;}

        [Required]
        [MaxLength(250)]
        public string Topic { get; set; }

        [Required]        
        public string Text { get; set; }

        
        public DateTime Published{ get; set; }

        public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>(); // list of comments of blog
    }
}
