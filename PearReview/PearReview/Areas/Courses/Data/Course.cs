﻿using PearReview.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PearReview.Areas.Courses.Data
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }

        [Required]
        public AppUser Teacher { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }
    }
}
