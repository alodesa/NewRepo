using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Webapi2.Entitites
{
    public class CaseStatus
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Status { get; set; }

        public  ICollection<Case> Cases { get; set; }

    }
}
