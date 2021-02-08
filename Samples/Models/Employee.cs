using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Samples.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string FirstName { get; set; }

        [StringLength(20)]
        public string LastName { get; set; }
  
        [StringLength(1)]
        public string Gender { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(30)]
        public string IpAddress { get; set; }
    }
}
