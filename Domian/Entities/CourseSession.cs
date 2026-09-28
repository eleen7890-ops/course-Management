using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class CourseSession
    {
        public int CourseSessionId { get; set; }
        public int CourseId { get; set; }
        public string? SessionTopic { get; set; }
        public Course? Course { get; set; } = null!;
        public DateOnly SessionDate { get; set; }
        public bool IsCancelled { get; set; }
        public ICollection<Attendance> Attendances { get; set; }



    }
}
