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
        public int GroupId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Color { get; set; }

        //Foreign key to Group
        public List<Board_Members> Board_Members { get; set; }
        public List<Card_Members> Card_Members { get; set; }
        public List<Group_Member> Group_Members { get; set; }
        public List<Permission_Members> Permission_Members { get; set; }
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
