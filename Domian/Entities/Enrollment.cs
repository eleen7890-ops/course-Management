using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums;

namespace Domain.Entities
{
   public class Enrollment
    {
        public int EnrollmentId { get; set; }
        public DateOnly EnrollmentDate { get; set; }
        public EnrollmentStatusEnum EnrollmentStatus { get; set; }
        public bool IsActive { get; set; }
        public DateTime? LastEdited { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public Student? Student { get; set; }
        public Course? Course { get; set; }
        public ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();
        public ICollection<StudentAssignment> StudentAssignments { get; set; } = new List<StudentAssignment>();
        public ICollection<EnrollmentPayment> Payments { get; set; }  = new List<EnrollmentPayment>();
    }
}
