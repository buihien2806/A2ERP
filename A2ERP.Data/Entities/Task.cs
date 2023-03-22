using A2ERP.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2ERP.Data.Entities
{
    public class Task
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public Guid? AssigneeId { get; set; }
        public User? Assignee { get; set; }
        public DateTime CreatedDate { get; set; }
        public Priority Priority { get; set; }
        public Status Status { get; set; }
    }
}
