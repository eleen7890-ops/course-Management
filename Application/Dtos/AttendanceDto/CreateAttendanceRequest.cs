using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.AttendanceDto
{
   public class CreateAttendanceRequest
    {
      
        [Range(1, int.MaxValue, ErrorMessage = "Please select an Enrollment.")]
        public int EnrollmentId { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Please select a Course Session.")]
        public int CourseSessionId { get; set; }
        public int StudentId { get; set; }
        public string StudentName { get; set; } = string.Empty;
        public bool ? IsPresent { get; set; } 
        public string? Notes { get; set; }
    }
}
