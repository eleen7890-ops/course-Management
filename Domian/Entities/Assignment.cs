using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Entities
{
    public class Assignment
    {
        public int AssignmentId { get; set; }
        public string AssignmentTitle { get; set; }
        public string AssignmentDescription { get; set; }
        public DateTime DueDate { get; set; }
        public int MaximumMark { get; set; }
        public bool IsActive { get; set; }
        public string? AttachmentFilePath { get; set; }
        public string? AttachmentFileName { get; set; }
        public int CourseId { get; set; }
        public Course? Course { get; set; } 
        public ICollection<StudentAssignment> StudentAssignments { get; set; } = new List<StudentAssignment>();


    }
}
