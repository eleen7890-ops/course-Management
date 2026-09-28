using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Dtos.EnrollmentPaymentDto;
using Domain.Entities;

namespace Application.Interfaces.Repositories
{
   public interface IEnrollmentPaymentRepository
    {
        Task<IReadOnlyList<EnrollmentPaymentDto>>GetPaymentsByEnrollmentAsync(int enrollmentId); 
        Task<PaymentSummaryDto?> GetPaymentSummaryAsync(int enrollmentId);

        Task<int> CreateEnrollmentPaymentAsync(EnrollmentPayment enrollmentPayment);
        Task<bool> UpdateEnrollmentPaymentAsync(EnrollmentPayment enrollmentPayment);
    }
}
