using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.CourseSessionDto
{
    public class CreateCourseSessionRequest
    {
        [Range(1, int.MaxValue, ErrorMessage = "Please select a Course.")]
        public int CourseId { get; set; }
        public string? SessionTopic { get; set; }
        [Required(ErrorMessage = "Session Date is required.")]
        public DateOnly? SessionDate { get; set; }
        public bool IsCancelled { get; set; } = false;
    }
}
