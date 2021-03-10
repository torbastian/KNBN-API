using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace KNBN_API.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [Required]
        public string Password { get; set; }

        //Relations
        public ICollection<Board> Boards { get; set; }
    }
}
