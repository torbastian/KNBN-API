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
        public string Email { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Color { get; set; }
    }

    [NotMapped]
    public class UserInfoDTO
    {
        public string email { get; set; }
        public int userId { get; set; }
        public string name { get; set; }
        public string color { get; set; }
    }
}
