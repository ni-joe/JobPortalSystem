using JobPortalSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JobPortalSystem.Domain.Models
{
  public class Interview
    {

        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        public Guid? JobId { get; set; }

        [ForeignKey(nameof(JobId))]
        public virtual JobPost? Job { get; set; }

        public Guid? Interviewee { get; set; }

        [ForeignKey(nameof(Interviewee))]
        public virtual JobSeeker? JobSeeker { get; set; }

        public Guid? ApplicationId { get; set; }

        [ForeignKey(nameof(ApplicationId))]
        public virtual JobApplication? Application { get; set; }

        public DateTime? Date { get; set; }

        public Guid? ScheduledBy { get; set; }

        [ForeignKey(nameof(ScheduledBy))]
        public virtual CompanyUser? CompanyUser { get; set; }

        [Required]
        public Guid CompanyId { get; set; }

        [ForeignKey(nameof(CompanyId))]
        public virtual JobProviderCompany Company { get; set; } = null!;

        [MaxLength(500)]
        public string? MeetingLink { get; set; }

        [MaxLength(1000)]
        public string? Notes { get; set; }

        [Required]
        public Status Status { get; set; }
     = Status.SHEDULED;
    }
}
