﻿using System;
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
        public int BoardMembersID { get; set; }

        public Board Board { get; set; }
        [ForeignKey("Board")]
        public int BoardID { get; set; }

        public User User { get; set; }
        [ForeignKey("User")]
        public int UserID { get; set; }

        public Group Group { get; set; }
        [ForeignKey("Group")]
        public int GroupID { get; set; }

        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
        public virtual ICollection<Board> Boards { get; set; }
    }

    [NotMapped]
    public class Board_MembersDto
    {
        public int id { get; set; }
        public int boardId { get; set; }
        public int userId { get; set; }
        public int groupId { get; set; }
    }
}
