using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Application.Interfaces.Repositories
{
   public interface ICourseSessionRepository
    {
        Task<IReadOnlyList<CourseSession>> GetAllCourseSessionsAsync();
        Task<CourseSession?> GetCourseSessionByIdAsync(int courseSessionId);
        Task<IReadOnlyList<CourseSession>> GetCourseSessionsByCourseAsync(int courseId);
        Task<int> CreateCourseSessionAsync(CourseSession courseSession);
        Task<bool> UpdateCourseSessionAsync(CourseSession courseSession);
    }
}
