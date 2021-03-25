using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KNBN_API.Models
{
    public class Group_Member
    {
        public int GropId { get; set; }
        public Group Group { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }

    [NotMapped]
    public class Group_MemberDto
    {
        public int id { get; set; }
        public int groupId { get; set; }
        public int userId { get; set; }
    }
}
