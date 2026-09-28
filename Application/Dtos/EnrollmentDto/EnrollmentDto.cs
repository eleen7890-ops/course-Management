using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums;

namespace Application.Dtos.EnrollmentDto
{
    public class EnrollmentDto
    {
        public int EnrollmentId { get; set; }
        public DateOnly EnrollmentDate { get; set; }
        public EnrollmentStatusEnum EnrollmentStatus { get; set; }
        public bool IsActive { get; set; }
        public DateTime? LastEdited { get; set; }
        public int StudentId { get; set; }
        public string StudentName { get; set; } = string.Empty;
        public int CourseId { get; set; }
        public string CourseName { get; set; } = string.Empty;

    }
}
