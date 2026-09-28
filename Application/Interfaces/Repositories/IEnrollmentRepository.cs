using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Application.Interfaces.Repositories
{
    public interface IEnrollmentRepository
    {
        Task<IReadOnlyList<Enrollment>> GetAllEnrollmentsAsync();
        Task<Enrollment?> GetEnrollmentByIdAsync(int enrollmentId);
        Task<int> CreateEnrollmentAsync(Enrollment enrollment);
        Task<bool> UpdateEnrollmentAsync(Enrollment enrollment);
        Task<bool> DeleteEnrollmentAsync(int enrollmentId);
        Task<IReadOnlyList<Enrollment>> GetAllActiveEnrollmentsAsync();
    }
}
