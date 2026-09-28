using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.TeacherDto
{
   public class TeacherDto
    {
        public int TeacherId { get; set; }
        public string TeacherName { get; set; } = string.Empty;
        public string TeacherEmail { get; set; } = string.Empty;
        public string TeacherPhoneNumber { get; set; } = string.Empty;
        public DateTime? LastEdited { get; set; }
        public bool IsActive { get; set; }
    }
}
