using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KNBN_API.Models
{
    public class User_info
    {
        [Key]
        public int Email { get; set; }

        public User User { get; set; }
        [ForeignKey("User")]
        public int UserID { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Color { get; set; }



    }
}
