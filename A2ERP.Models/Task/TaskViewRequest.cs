using A2ERP.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2ERP.Models.Task
{
    public class TaskViewRequest
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public Guid? UserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public Priority Priority { get; set; }
        public Status Status { get; set; }
    }
}
