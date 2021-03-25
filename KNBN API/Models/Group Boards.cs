using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KNBN_API.Models
{
    public class Group_Boards
    {
        public int GroupId { get; set; }
        public Group Groups { get; set; }
        public int BoardId { get; set; }
        public Board Boards { get; set; }
    }

    [NotMapped]
    public class Group_Boards_DTO
    {
        public int id { get; set; }
        public int groupId { get; set; }
        public int boardId { get; set; }
    }
}
