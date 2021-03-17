using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace KNBN_API.Models
{
    public class User
    {
        public int UserId { get; set; }

        [Required]
        public string Password { get; set; }

        public List<User_info> User_Info { get; set; }

        public List<Board> Boards { get; set; }

        public List<Card_Members> Card_Members { get; set; }

        public List<Board_Members> Board_Members { get; set; }

        public List<Group_Member> Group_Members { get; set; }

        public List<Permission_Members> Permission_Members { get; set; }
    }
}
