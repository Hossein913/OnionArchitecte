using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.core.Student.AppService;
using App.Domain.core.Student.Dtos;

namespace App.Domain.Services.Student
{
    internal class StudentAppService : IStudentService
    {

        public Task<List<StudentGetAllDto>> GetAllStudent(CancellationToken cancellationToken)
        {
            
        }
    }
}
