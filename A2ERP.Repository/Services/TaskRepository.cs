using A2ERP.Data.EF;
using A2ERP.Models.Task;
using A2ERP.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2ERP.Repository.Services
{
    public class TaskRepository : ITaskRepository
    {
        private readonly MainContext _mainContext;
        public TaskRepository(MainContext mainContext)
        {
            _mainContext = mainContext;
        }

        public Task<IEnumerable<TaskViewRequest>> GetAllTasks()
        {
            throw new NotImplementedException();
        }
        public Task<TaskViewRequest?> GetById(Guid id)
        {
            throw new NotImplementedException();
        }
        public Task<bool> Create(TaskCreateRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }
        public Task<bool> Update(TaskUpdateRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
