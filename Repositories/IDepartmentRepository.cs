using RecordManagement.Models;
namespace RecordManagement.Repositories;

public interface IDepartmentRepository
{
    Task<Department> GetByIdAsync(int id);
    Task<List<Department>> GetAllAsync();
    Task AddAsync(Department department);
    Task UpdateAsync(Department department);
    Task DeleteAsync(int Id);
}
