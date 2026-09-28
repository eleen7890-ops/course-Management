using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Dtos.CourseSessionDto;
using Domain.Entities;

namespace Application.Interfaces.Services
{
   public interface ICourseSessionService
    {
        Task<IReadOnlyList<CourseSessionDto>> GetAllCourseSessionsAsync();
        Task<IReadOnlyList<CourseSessionDto>> GetCourseSessionsByCourseAsync(int courseId);
        Task<CourseSessionDto?> GetCourseSessionByIdAsync(int courseSessionId);
        Task<int> CreateCourseSessionAsync(CreateCourseSessionRequest createCourseSessionRequest);
        Task<bool> UpdateCourseSessionAsync(UpdateCourseSessionRequest updateCourseSessionRequest);
    }
}
