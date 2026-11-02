using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JobPortalSystem.Domain.Models
{
    public class Company
    {
        [Key]
        public int Company_ID { get; set; }

        [ForeignKey("JobProvider")]
        public int JobProvider_ID { get; set; }
        public virtual JobProvider JobProvider { get; set; }

        public int Industry_ID { get; set; }
        public int HQLocation_ID { get; set; }

        [Required]
        [MaxLength(150)]
        public string Company_Name { get; set; }

        [MaxLength(200)]
        public string Company_Location { get; set; }

        public string Company_Description { get; set; }

        [MaxLength(20)]
        public string Company_Phone { get; set; }

        [MaxLength(150)]
        public string Company_Email { get; set; }

        [MaxLength(200)]
        public string Company_Website { get; set; }

        // Navigation Property
        //public virtual ICollection<JobPost> JobPosts { get; set; } = new List<JobPost>();
    }
}
