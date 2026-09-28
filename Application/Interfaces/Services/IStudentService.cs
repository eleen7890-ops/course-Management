using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Dtos.StudentDto;
using Domain.Entities;

namespace Application.Interfaces.Services
{
   public interface IStudentService
    {
        Task<IReadOnlyList<StudentDto>> GetAllStudentsAsync();
        Task<StudentDto?> GetStudentByIdAsync(int studentId);
        Task<int> CreateStudentAsync(CreateStudentRequest createStudentRequest);
        Task<bool> UpdateStudentAsync(UpdateStudentRequest updateStudentRequest);
        Task<bool> DeleteStudentAsync(int studentId);
        Task<IReadOnlyList<StudentDto>> GetAllActiveStudentsAsync();
    }
}
