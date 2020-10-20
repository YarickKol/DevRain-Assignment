using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlogREST_API.Models
{
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

        [Required]
        public DateTime Published{ get; set; }

        public ICollection<Comment> Comments { get; set;}
    }
}
