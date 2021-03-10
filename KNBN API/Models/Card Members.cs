﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KNBN_API.Models
{
    public class Card_Members
    {
        [Key]
        public int CardMembersID { get; set; }

        public Card Card { get; set; }
        [ForeignKey("Card")]
        public int CardID { get; set; }

        public User User { get; set; }
        [ForeignKey("User")]
        public int UserID { get; set; }

        public Group Group { get; set; }
        [ForeignKey("Group")]
        public int GroupID { get; set; }
    }
}