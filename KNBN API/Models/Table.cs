using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KNBN_API.Models
{
    public class Table
    {
        [Key]
        public int TableID { get; set; }

        //Foreign Key -> User
        public Board Board { get; set; }
        [ForeignKey("Board")]
        public int BoardID { get; set; }

        [Required]
        public string Name { get; set; }
    }

    [NotMapped]
    public class TableDTO
    {
        public int id { get; set; }
        public int boardId { get; set; }
        public string name { get; set; }
    }
}