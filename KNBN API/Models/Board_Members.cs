using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace KNBN_API.Models
{
    public class Board_Members
    {
        [Key]
        public int BoardMemberID { get; set; }

        public Board Board { get; set; }
        [ForeignKey("Board")]
        public int BoardID { get; set; }

        public User User { get; set; }
        [ForeignKey("User")]
        public int UserID { get; set; }

        public Group Group { get; set; }
        [ForeignKey("Group")]
        public int GroupID { get; set; }
    }
}
