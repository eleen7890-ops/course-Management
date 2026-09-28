using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Dtos.AttendanceDto;
using Domain.Entities;

namespace Application.Interfaces.Repositories
{
    public interface IAttendanceRepository
    {
        Task<AttendanceDto?> GetAttendanceBySessionAsync(int courseSessionId);
        Task<int> CreateAttendanceAsync(Attendance attendance);
        Task<bool> UpdateAttendanceAsync(Attendance attendance);



    }
}

