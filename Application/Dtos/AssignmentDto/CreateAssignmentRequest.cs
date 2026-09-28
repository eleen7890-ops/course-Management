using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.AssignmentDto
{
   public class CreateAssignmentRequest
    {
        
        [Required(ErrorMessage = "Assignment title is required.")]
        public string AssignmentTitle { get; set; }=string.Empty;
        [Required(ErrorMessage = "Assignment Description is required.")]
        public string AssignmentDescription { get; set; } = string.Empty;
        [Required(ErrorMessage = "Due date is required.")]
        public DateTime DueDate { get; set; }

        [Range(1, int.MaxValue,
            ErrorMessage = "Maximum mark must be greater than zero.")]
        public int MaximumMark { get; set; }
        public bool IsActive { get; set; } = true;
        public string? AttachmentFilePath { get; set; }
        public string? AttachmentFileName { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Please select a course.")]
        public int CourseId { get; set; }
    }
}
