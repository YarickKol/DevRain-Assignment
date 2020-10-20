using System;
using System.ComponentModel.DataAnnotations;

namespace BlogREST_API.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string UserName { get; set; }        

        [Required]
        public string Text { get; set; }

        [Required]
        public DateTime Published { get; set; }

        public Blog Blog { get; set; }
    }
}
