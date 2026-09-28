using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Dtos.CourseDto;
using Domain.Entities;

namespace Application.Interfaces.Services
{
   public interface ICourseService
    {
        Task<IReadOnlyList<CourseDto>> GetAllCoursesAsync();
        Task<CourseDto?> GetCourseByIdAsync(int courseId);
        Task<int> CreateCourseAsync(CreateCourseRequest createCourseRequest);
        Task<bool> UpdateCourseAsync(UpdateCourseRequest updateCourseRequest);
        Task<bool> DeleteCourseAsync(int courseId);
        Task<IReadOnlyList<CourseDto>> GetAllActiveCoursesAsync();
    }
}
