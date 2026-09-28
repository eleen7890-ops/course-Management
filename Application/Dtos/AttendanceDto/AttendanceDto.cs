using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.AttendanceDto
{
   public class AttendanceDto
    {
        public int AttendanceId { get; set; }
        public int EnrollmentId { get; set; }
        public int CourseSessionId { get; set; }
        public bool IsPresent { get; set; }
        public string? Notes { get; set; }
    }
}
