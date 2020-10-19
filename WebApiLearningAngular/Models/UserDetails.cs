using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiLearningAngular04.Models
{
    public class UserDetails
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string UserName { get; set; }
        [Required]
        [Column(TypeName = "varchar(16)")]
        public string UserNumber { get; set; }
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime JoinDate { get; set; }
        [Required]
        [Column(TypeName = "bit")]
        public bool IsDeleted { get; set; }
    }
}
