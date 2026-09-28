using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums;

namespace Application.Dtos.StudentAssignmentDto
{
   public class StudentAssignmentDto
    {
        public int? StudentAssignmentId { get; set; }
        public int? Mark { get; set; }
        public string? Feedback { get; set; }
        public AssignmentStatusEnum? AssignmentStatus { get; set; }
        public DateTime? SubmissionDate { get; set; }
        public int EnrollmentId { get; set; }
        public int AssignmentId { get; set; }
        public string AssignmentTitle { get; set; } = string.Empty;
        public int StudentId { get; set; }  
        public string StudentName { get; set; } = string.Empty;

    }
}
