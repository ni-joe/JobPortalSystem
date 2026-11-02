using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JobPortalSystem.Domain.Models
{
    public class JobProvider
    {
        [Key]
        public int JobProvider_ID { get; set; }

        public int SystemUser_ID { get; set; }

        [Required]
        [MaxLength(100)]
        public string JobProvider_Name { get; set; }

        [Required]
        [MaxLength(150)]
        public string JobProvider_Email { get; set; }

        [Required]
        [MaxLength(100)]
        public string JobProvider_Password { get; set; }

        [MaxLength(250)]
        public string JobProvider_Address { get; set; }

        public DateTime JobProvider_RegistrationDate { get; set; } = DateTime.Now;

        [MaxLength(50)]
        public string JobProvider_Type { get; set; }

        // Navigation Properties for EF Core relationships
        //public virtual ICollection<Company> Companies { get; set; } = new List<Company>();
        //public virtual ICollection<JobPost> JobPosts { get; set; } = new List<JobPost>();
    }
}
