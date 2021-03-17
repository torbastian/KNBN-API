using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KNBN_API.Models
{
    public class Card
    {
        [Key]
        public int CardID { get; set; }

        public Table Table { get; set; }
        [ForeignKey("Table")]
        public int TableID { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Table> Tables { get; set; }
    }

    [NotMapped]
    public class CardDto
    {
        public int id { get; set; }
        public int tableId { get; set; }
        public string title { get; set; }
        public string description { get; set; }
    }
}
