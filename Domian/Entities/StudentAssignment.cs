using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Enums;

namespace Domain.Entities
{
    public class StudentAssignment
    {
        public int StudentAssignmentId { get; set; }
        public int? Mark { get; set; }
        public string? Feedback { get; set; }
        public AssignmentStatusEnum AssignmentStatus { get; set; }
        public DateTime? SubmissionDate { get; set; }
        public int EnrollmentId { get; set; }
        public int AssignmentId { get; set; }
        public Enrollment? Enrollment { get; set; } = null!;
        public Assignment Assignment { get; set; } = null!;
    }
}
