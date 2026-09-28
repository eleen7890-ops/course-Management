using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Enums;

namespace Application.Dtos.EnrollmentPaymentDto
{
  public  class CreateEnrollmentPaymentRequest
    {
        [Range(1, int.MaxValue, ErrorMessage = "Please select an Enrollment.")]
        public int EnrollmentId { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Amount must be greater than zero.")]
        public int Amount { get; set; }
        [Required(ErrorMessage = "Payment date is required.")]
        public DateTime? PaymentDate { get; set; }
        [Required(ErrorMessage = "Payment method is required.")]
        [EnumDataType(typeof(PaymentMethodEnum), ErrorMessage = "Invalid payment method.")]
        public PaymentMethodEnum? PaymentMethod { get; set; }
        public string? Notes { get; set; }
  
    }
}
