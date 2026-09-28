using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.CourseDto
{
  public  class CreateCourseRequest
    {
        [Required(ErrorMessage = "Course name is required.")]
        public string CourseName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Course start date is required.")]
        public DateOnly? CourseStartDate { get; set; }
        [Required(ErrorMessage = "Course end date is required.")]
        public DateOnly? CourseEndDate { get; set; }

        [Required(ErrorMessage = "Course start time is required.")]
        public TimeSpan? StartTime { get; set; }
        [Required(ErrorMessage = "Course end time is required.")]

        public TimeSpan? EndTime { get; set; }
        [Range(1, int.MaxValue)]
        public int CoursePrice { get; set; }
        [Required(ErrorMessage = "Course description is required.")]
        public string? CourseDescription { get; set; }
        public bool IsActive { get; set; } = true;
        
        [Range(1, int.MaxValue, ErrorMessage = "Please select a teacher.")]
        public int TeacherId { get; set; }
       
    }
}
