using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace adstra_task.ViewModel
{
    public class RoleFormVM
    {
        [Required]
        public string Name { get; set; }
    }
}
