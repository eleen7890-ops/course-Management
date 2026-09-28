using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
   public class Attendance
    {
        [Key]
        public int AttendanceId { get; set; }
        public int EnrollmentId { get; set; }
        public int CourseSessionId { get; set; }
        public bool IsPresent { get; set; }
        public string? Notes { get; set; }
        public Enrollment? Enrollment { get; set; }
        public CourseSession? CourseSession { get; set; }

    }
}
