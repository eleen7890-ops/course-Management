using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Application.Interfaces.Repositories
{
   public interface IEnrollmentPaymentRepository
    {
        Task<IReadOnlyList<EnrollmentPayment>> GetAllEnrollmentPaymentsAsync();
        Task<EnrollmentPayment?> GetEnrollmentPaymentByIdAsync(int enrollmentPaymentId);
        Task<int> CreateEnrollmentPaymentAsync(EnrollmentPayment enrollmentPayment);
        Task<bool> UpdateEnrollmentPaymentAsync(EnrollmentPayment enrollmentPayment);
    }
}
