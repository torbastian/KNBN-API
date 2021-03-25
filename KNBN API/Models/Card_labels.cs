using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KNBN_API.Models
{
    public class Card_labels
    {
        public int CardId { get; set; }
        public Card Card { get; set; }
        public int LabelId { get; set; }
        public Labels Labels { get; set; }
    }
}
