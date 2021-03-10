using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace KNBN_API.Models
{
    public class Board
    {
        [Key]
        public int BoardID { get; set; }

        //Foreign Key -> User
        public List<User> UserId { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
