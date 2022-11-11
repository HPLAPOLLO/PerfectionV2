using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Hpl.Server.teams
{
    public class CreateUpdateTeamDto
    {
        [Required]
        [StringLength(500)]
        public string Description { get; set; }
    }
}
