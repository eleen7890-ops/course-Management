using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums;

namespace Application.Dtos.EnrollmentDto
{
    public class CreateEnrollmentRequest
    {
        [Required(ErrorMessage = "Enrollment date is required.")]
        public DateOnly? EnrollmentDate { get; set; }
        [Required(ErrorMessage = "Enrollment status is required.")]
        [EnumDataType(typeof(EnrollmentStatusEnum))]

        public EnrollmentStatusEnum? EnrollmentStatus { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime? LastEdited { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Please select a Student.")]

        public int StudentId { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Please select a Course.")]
        public int CourseId { get; set; }

    }
}
