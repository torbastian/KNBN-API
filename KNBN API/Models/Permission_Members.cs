using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KNBN_API.Models
{
    public class Permission_Members
    {
        public int Permission_MembersId { get; set; }

    }

    [NotMapped]
    public class Permission_MembersDTO
    {
        public int id { get; set; }
        public int permissionId { get; set; }
        public int boardMembersId { get; set; }
    }
}
