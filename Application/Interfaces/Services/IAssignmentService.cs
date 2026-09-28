using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Dtos.AssignmentDto;
using Domain.Entities;

namespace Application.Interfaces.Services
{
   public interface IAssignmentService
    {
        Task<IReadOnlyList<AssignmentDto>> GetAllAssignmentsAsync();
        Task<AssignmentDto?> GetAssignmentByIdAsync(int assignmentId);
        Task<int> CreateAssignmentAsync(CreateAssignmentRequest createAssignmentRequest);
        Task<bool> UpdateAssignmentAsync(UpdateAssignmentRequest updateAssignmentRequest);
        Task<IReadOnlyList<AssignmentDto>> GetActiveAssignmentsByCourseAsync(int courseId);

    }
}
