using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Dtos.EnrollmentDto;
using Domain.Entities;

namespace Application.Interfaces.Services
{
   public interface IEnrollmentService
    {
        Task<IReadOnlyList<EnrollmentDto>> GetAllEnrollmentsAsync();
        Task<EnrollmentDto?> GetEnrollmentByIdAsync(int enrollmentId);
        Task<int> CreateEnrollmentAsync(CreateEnrollmentRequest createEnrollmentRequest);
        Task<bool> UpdateEnrollmentAsync(UpdateEnrollmentRequest updateEnrollmentRequest);
        Task<bool> DeleteEnrollmentAsync(int enrollmentId);
        Task<IReadOnlyList<EnrollmentDto>> GetAllActiveEnrollmentsAsync();
    }
}
