using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Dtos.AttendanceDto;
using Domain.Entities;

namespace Application.Interfaces.Services
{
    public interface IAttendanceService
    {
        Task<AttendanceDto?> GetAttendanceBySessionAsync(int courseSessionId);
        Task<int> CreateAttendanceAsync(CreateAttendanceRequest createAttendanceRequest);
        Task<bool> UpdateAttendanceAsync(UpdateAttendanceRequest updateAttendanceRequest);

    }
}
