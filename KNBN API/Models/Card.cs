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
        public int CardId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int Position { get; set; }

        //Foreign key to Card
        public List<Card_Members> Card_Members { get; set; }
        public List<Card_Labels> Card_Labels { get; set; }
    }

    [NotMapped]
    public class CardDto
    {
        public int id { get; set; }
        public int tableId { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int position { get; set; }
    }
}
