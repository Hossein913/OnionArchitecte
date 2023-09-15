using App.Domain.core.Student.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.core.Student.AppService
{
    public interface IStudentService
    {
        Task<List<StudentGetAllDto>> GetAllStudent(CancellationToken cancellationToken);
    }
}
