using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.CourseDto
{
   public class CourseDto
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; } = string.Empty;
        public DateOnly CourseStartDate { get; set; }
        public DateOnly CourseEndDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public int CoursePrice { get; set; }
        public string? CourseDescription { get; set; }
        public bool IsActive { get; set; }
        public DateTime? LastEdited { get; set; }
        public int TeacherId { get; set; }
        public string TeacherName { get; set; } = string.Empty;
    }
}
