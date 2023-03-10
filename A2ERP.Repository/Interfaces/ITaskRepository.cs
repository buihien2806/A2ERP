using A2ERP.Models.Task;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2ERP.Repository.Interfaces
{
    public interface ITaskRepository
    {
        Task<List<TaskViewRequest>> GetAllTasks();
        Task<TaskViewRequest?> GetById(Guid id);
        Task<bool> Create(TaskCreateRequest request);
        Task<bool> Update(TaskUpdateRequest request);
        Task<bool> Delete(Guid id);
    }
}
