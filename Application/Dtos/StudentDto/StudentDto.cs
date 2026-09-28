using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.StudentDto
{
   public class StudentDto
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; } = string.Empty;
        public string StudentEmail { get; set; } = string.Empty;
        public string StudentPhoneNumber { get; set; } = string.Empty;
        public DateTime? LastEdited { get; set; }
        public bool IsActive { get; set; }
    }
}
