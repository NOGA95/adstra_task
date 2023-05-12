using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace adstra_task.Models
{
    public class UsersList
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
