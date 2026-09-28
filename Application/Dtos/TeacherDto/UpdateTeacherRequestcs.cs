using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.TeacherDto
{
   public class UpdateTeacherRequestcs
    {
        [Required(ErrorMessage = "Teacher name is required.")]
        public string TeacherName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Email format is invalid.")]
        public string TeacherEmail { get; set; } = string.Empty;

        [Required(ErrorMessage = "Phone number is required.")]
        [RegularExpression(@"^(?:\+962|0)(?:7[5789]\d{7}|[2356]\d{7})$", ErrorMessage = "Enter a valid Jordanian phone or mobile number.")]
        public string TeacherPhoneNumber { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
    }
}
