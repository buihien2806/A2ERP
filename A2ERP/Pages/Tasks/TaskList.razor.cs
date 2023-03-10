using A2ERP.Models.Task;
using A2ERP.Repository.Interfaces;
using Microsoft.AspNetCore.Components;

namespace A2ERP.Pages.Tasks
{
    public partial class TaskList
    {
        [Inject] private ITaskRepository taskRepository { get; set; }

        private List<TaskViewRequest> taskViewRequests;

        protected override async Task OnInitializedAsync()
        {
            taskViewRequests = await taskRepository.GetAllTasks();
        }
    }
}
 