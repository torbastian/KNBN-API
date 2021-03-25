using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KNBN_API.Models
{
    public class User
    {
        public int UserId { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Color { get; set; }


        //Foreign key to User
        public List<Board> Boards { get; set; }
        public List<Board_Members> Board_Members { get; set; }
        public IList<Group_Member> Group_Members { get; set; }
        public List<Group> Group { get; set; }

    }

    [NotMapped]
    public class UserDTO
    {
        public string email { get; set; }
        public int userId { get; set; }
        public string name { get; set; }
        public string color { get; set; }
    }
}
