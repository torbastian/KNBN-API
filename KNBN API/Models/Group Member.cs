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
        public int Group_MemberId { get; set; }
    }

    [NotMapped]
    public class Group_MemberDto
    {
        public int id { get; set; }
        public int groupId { get; set; }
        public int userId { get; set; }
    }
}
