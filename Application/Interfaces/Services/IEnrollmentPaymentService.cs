using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Dtos.EnrollmentPaymentDto;
using Domain.Entities;

namespace Application.Interfaces.Services
{
   public interface IEnrollmentPaymentService
    {
        Task<IReadOnlyList<EnrollmentPaymentDto>> GetPaymentsByEnrollmentAsync(int enrollmentId);
        Task<PaymentSummaryDto?> GetPaymentSummaryAsync(int enrollmentId);

        Task<int> CreateEnrollmentPaymentAsync(CreateEnrollmentPaymentRequest createEnrollmentPaymentRequest);
        Task<bool> UpdateEnrollmentPaymentAsync(UpdateEnrollmentPaymentRequest updateEnrollmentPaymentRequest);
    }
}

