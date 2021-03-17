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
        public int BoardId { get; set; }

        [Required]
        public string Name { get; set; }

        //Foreign key to board
        public List<Board_Members> Board_Members { get; set; }
        public List<Table> Tables { get; set; }
        public List<Permission_Members> Permission_Members { get; set; }
    }

    [NotMapped]
    public class BoardDto
    {
        public int id { get; set; }
        public int userId { get; set; }
        public string name { get; set; }
    }
}
