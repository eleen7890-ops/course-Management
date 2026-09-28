using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums;

namespace Application.Dtos.StudentAssignmentDto
{
   public class UpdateStudentAssignmentRequest
    {
        [Range(0, int.MaxValue, ErrorMessage = "Mark cannot be negative.")]
        public int? Mark { get; set; }
        public string? Feedback { get; set; }
        [Required(ErrorMessage = "Assignment status is required.")]
        [EnumDataType(typeof(AssignmentStatusEnum))]
        public AssignmentStatusEnum? AssignmentStatus { get; set; }
        public DateTime? SubmissionDate { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Please select an enrollment.")]
        public int EnrollmentId { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Please select an assignment.")]

        public int AssignmentId { get; set; }
    }
}
