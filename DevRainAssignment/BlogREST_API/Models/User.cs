using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogREST_API.Models
{
    /// <summary>
    /// class represents the data for a user in the application
    /// </summary>
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
        
    }
}
