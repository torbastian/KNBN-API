using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KNBN_API.Models
{
    public class Card_Members
    {
        public int Card_MembersId { get; set; }
    }

    [NotMapped]
    public class Card_MembersDto
    {
        public int id { get; set; }
        public int cardId { get; set; }
        public int boardMembersId { get; set; }

    }
}
