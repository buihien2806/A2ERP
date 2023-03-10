using A2ERP.Data.EF;
using A2ERP.Models.Task;
using A2ERP.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = A2ERP.Data.Entities.Task;

namespace A2ERP.Repository.Services
{
    public class TaskRepository : ITaskRepository
    {
        private readonly MainContext _mainContext;
        public TaskRepository(MainContext mainContext)
        {
            _mainContext = mainContext;
        }

        public async Task<List<TaskViewRequest>> GetAllTasks()
        {
            var query = from a in _mainContext.Tasks
                        select a;
            return await query.Select(x => new TaskViewRequest()
            {
                Id= x.Id,
                Name= x.Name != null? x.Name : "N/A",
                UserId= x.UserId,
                CreatedDate= x.CreatedDate,
                Priority= x.Priority,
                Status= x.Status
            }).ToListAsync();
        }
        public async Task<TaskViewRequest?> GetById(Guid id)
        {
            var t = _mainContext.Tasks.Where(x => x.Id == id);
            return await t.Select(x => new TaskViewRequest()
            {
                Id = x.Id,
                Name = x.Name,
                UserId = x.UserId,
                CreatedDate = x.CreatedDate,
                Priority = x.Priority,
                Status = x.Status
            }).FirstOrDefaultAsync();
        }
        public async Task<bool> Create(TaskCreateRequest request)
        {
            var data = new Task()
            {
                Name = request.Name,
                //UserId = request.UserId,
                CreatedDate = DateTime.Now,
                Priority = request.Priority,
                Status = Data.Enums.Status.Open
            };
            _mainContext.Tasks.Add(data);
            return await _mainContext.SaveChangesAsync() > 0;
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
