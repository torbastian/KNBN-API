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
        public int Board_MembersId { get; set; }

        //Foreign key to Board Members
        public List<Card_Members> Card_Members { get; set; }
        public List<Permission_Members> Permission_Members { get; set; }
    }

    [NotMapped]
    public class Board_MembersDto
    {
        public int id { get; set; }
        public int boardId { get; set; }
        public int userId { get; set; }
    }
}
