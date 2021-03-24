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
        public int TableId { get; set; }

        [Required]
        public string Name { get; set; }

        public int Position { get; set; }

        //Foreign key to Table
        public List<Card> Card { get; set; }
    }

    [NotMapped]
    public class TableDTO
    {
        public int id { get; set; }
        public int boardId { get; set; }
        public string name { get; set; }
        public int position { get; set; }
    }
}