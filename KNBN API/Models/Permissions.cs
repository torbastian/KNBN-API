using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KNBN_API.Models
{
    public class Permissions
    {
        [Key]
        public int PermissionsID { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }
    }

    [NotMapped]
    public class PermissionsDto
    {
        public int permissionsId { get; set; }
        public string title { get; set; }
        public string description { get; set; }
    }
}
