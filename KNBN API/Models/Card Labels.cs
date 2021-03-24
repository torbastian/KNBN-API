using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KNBN_API.Models
{
    public class Card_Labels
    {
        public int Card_LabelsId { get; set; }

    }

    [NotMapped]
    public class Card_Labels_DTO
    {
        public int id { get; set; }

        public int cardId { get; set; }
        public int labelId { get; set; }
    }
}
