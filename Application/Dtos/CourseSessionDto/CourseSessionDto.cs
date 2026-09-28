using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Application.Dtos.CourseSessionDto
{
   public class CourseSessionDto
    {
        public int CourseSessionId { get; set; }
        public int CourseId { get; set; }
        public string CourseName { get; set; } = string.Empty;
        public string? SessionTopic { get; set; }
        public DateOnly SessionDate { get; set; }
        public bool IsCancelled { get; set; } 
    }
}
