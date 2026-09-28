using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Dtos.StudentAssignmentDto;
using Domain.Entities;

namespace Application.Interfaces.Services
{
   public interface IStudentAssignmentService
    {
        Task<IReadOnlyList<StudentAssignmentDto>> GetStudentAssignmentsByAssignmentAsync(int assignmentId);
        Task<int> CreateStudentAssignmentAsync(CreateStudentAssignmentRequest createStudentAssignmentRequest);
        Task<bool> UpdateStudentAssignmentAsync(UpdateStudentAssignmentRequest updateStudentAssignmentRequest);
    }
}
