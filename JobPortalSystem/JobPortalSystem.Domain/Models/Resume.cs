using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace JobPortalSystem.Domain.Models
{
   public class Resume
    {
        public Guid Id { get; set; }

        public string? Title { get; set; }

        public byte[]? FileData { get; set; }
        [JsonIgnore]
        public virtual ICollection<JobSeekerProfile> JobSeekerProfiles { get; set; } = new List<JobSeekerProfile>();
    }
}
