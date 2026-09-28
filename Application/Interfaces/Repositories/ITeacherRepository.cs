using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Application.Interfaces.Repositories
{
    public interface ITeacherRepository
    {
        Task<IReadOnlyList<Teacher>> GetAllTeachersAsync();
        Task<Teacher?> GetTeacherByIdAsync(int teacherId);
        Task<int> CreateTeacherAsync(Teacher teacher);
        Task<bool> UpdateTeacherAsync(Teacher teacher);
        Task<bool> DeleteTeacherAsync(int teacherId);
        Task<IReadOnlyList<Teacher>> GetAllActiveTeachersAsync();
    }
}
