using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KNBN_API.Models
{
    public class Board
    {
        [Key]
        public int BoardID { get; set; }

        //Foreign Key -> User
        public User User { get; set; }
        [ForeignKey("User")]
        public int UserID { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
