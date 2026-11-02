using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JobPortalSystem.Domain.Models
{
    public class JobSeekerProfileSkill
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public Guid JobSeekerProfileId { get; set; }

        [ForeignKey(nameof(JobSeekerProfileId))]
        public virtual JobSeekerProfile JobSeekerProfile { get; set; }
            = null!;

        [Required]
        public Guid SkillId { get; set; }

        [ForeignKey(nameof(SkillId))]
        public virtual Skill Skill { get; set; } = null!;
    }
}
