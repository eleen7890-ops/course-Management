using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums;

namespace Application.Dtos.EnrollmentPaymentDto
{
   public class PaymentSummaryDto
    {
        public int EnrollmentId { get; set; }
        public string StudentName { get; set; } = string.Empty;
        public string CourseName { get; set; } = string.Empty;
        public int CoursePrice { get; set; } 
        public int TotalPaid { get; set; }
        public int RemainingAmount { get; set; }
        public string PaymentStatus { get; set; } = string.Empty;

    }
}
