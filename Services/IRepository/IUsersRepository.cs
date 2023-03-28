using MetrosoftForm.Models;
using MetrosoftForm.Models.Dto;

namespace MetrosoftForm.Services.IRepository
{
    public interface IUsersRepository<Employee> 
    {
        public Task<Employee> Create(EmployeesDto details);
    }
}
