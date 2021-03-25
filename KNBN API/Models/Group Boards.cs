using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KNBN_API.Models
{
    public class Group_Boards
    {
        public int Group_BoardsId { get; set; }
    }

    [NotMapped]
    public class Group_Boards_DTO
    {
        public int id { get; set; }
        public int groupId { get; set; }
        public int boardId { get; set; }
    }
}
