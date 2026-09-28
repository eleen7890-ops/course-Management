using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Application.Interfaces.Repositories
{
    public interface IAssignmentRepository
    {
        Task<IReadOnlyList<Assignment>> GetAllAssignmentsAsync();
        Task<Assignment?> GetAssignmentByIdAsync(int assignmentId);
        Task<int> CreateAssignmentAsync(Assignment assignment);
        Task<bool> UpdateAssignmentAsync(Assignment assignment);
        Task<IReadOnlyList<Assignment>>GetActiveAssignmentsByCourseAsync(int courseId);
    }
}
