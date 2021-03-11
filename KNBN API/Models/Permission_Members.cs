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
        [Key]
        public int ID { get; set; }

        public Permissions Permissions { get; set; }
        [ForeignKey("Permissions")]
        public int PermissionID { get; set; }

        public User User { get; set; }
        [ForeignKey("User")]
        public int UserID { get; set; }

        public Group Groups { get; set; }
        [ForeignKey("Group")]
        public int GroupID { get; set; }

        public Board Boards { get; set; }
        [ForeignKey("Board")]
        public int BoardID { get; set; }

    }

    [NotMapped]
    public class Permission_MembersDTO
    {
        public int id { get; set; }
        public int permissionId { get; set; }
        public int userId { get; set; }
        public int groupId { get; set; }
        public int boardId { get; set; }
    }
}
