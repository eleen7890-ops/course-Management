using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Dtos.TeacherDto;
using Domain.Entities;

namespace Application.Interfaces.Services
{
   public interface ITeacherService
    {
        Task<IReadOnlyList<TeacherDto>> GetAllTeachersAsync();
        Task<TeacherDto?> GetTeacherByIdAsync(int teacherId);
        Task<int> CreateTeacherAsync(CreateTeacherRequest createTeacherRequest);
        Task<bool> UpdateTeacherAsync(UpdateTeacherRequest updateTeacherRequest);
        Task<bool> DeleteTeacherAsync(int teacherId);
        Task<IReadOnlyList<TeacherDto>> GetAllActiveTeachersAsync();
    }
}
