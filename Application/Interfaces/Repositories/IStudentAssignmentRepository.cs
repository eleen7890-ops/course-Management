using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Dtos.StudentAssignmentDto;
using Domain.Entities;

namespace Application.Interfaces.Repositories
{
    public interface IStudentAssignmentRepository
    {
        Task<StudentAssignmentDto?> GetStudentAssignmentByIdAsync(int studentAssignmentId);
        Task<int> CreateStudentAssignmentAsync(StudentAssignment studentAssignment);
        Task<bool> UpdateStudentAssignmentAsync(StudentAssignment studentAssignment);
        
    }
}
