using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.AssignmentDto
{
    public class AssignmentDto
    {
        public int AssignmentId { get; set; }
        public string AssignmentTitle { get; set; } = string.Empty;
        public string AssignmentDescription { get; set; } = string.Empty;
        public DateTime DueDate { get; set; }
        public int MaximumMark { get; set; }
        public bool IsActive { get; set; }
        public string? AttachmentFilePath { get; set; }
        public string? AttachmentFileName { get; set; }
        public int CourseId { get; set; }
        public string CourseName { get; set; } = string.Empty;

    }
}
