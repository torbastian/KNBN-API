using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KNBN_API.Models
{
    public class Group
    {
        [Key]
        public int GroupID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Color { get; set; }
    }

    [NotMapped]
    public class GroupDto
    {
        public int id { get; set; }
        public int plantId { get; set; }
        public string name { get; set; }
        public string color { get; set; }
    }
}
