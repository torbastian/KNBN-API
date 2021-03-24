﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KNBN_API.Models
{
    public class Labels
    {
        public int LabelsId { get; set; }

        public string Title;

        public string Color;

        //Foreign key to Labels
        public List<Card_Labels> Card_Labels { get; set; }
    }

    public class Labels_DTO
    {
        public int id { get; set; }

        public int boardId { get; set; }

        public string title { get; set; }

        public string color { get; set; }
    }
}
