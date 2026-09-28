using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Enums;

namespace Application.Dtos.EnrollmentPaymentDto
{
    public class EnrollmentPaymentDto
    {
        public int PaymentId { get; set; }
        public int EnrollmentId { get; set; }
        public string StudentName { get; set; } = string.Empty;
        public string CourseName { get; set; } = string.Empty;
        public int Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public DateTime? LastEdited { get; set; }
        public PaymentMethodEnum PaymentMethod { get; set; }
        public string? Notes { get; set; }
        
    }
}
