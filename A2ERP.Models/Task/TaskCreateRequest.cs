using A2ERP.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2ERP.Models.Task
{
    public class TaskCreateRequest
    {
        [MaxLength(100, ErrorMessage = "You cannot fill task name over than 100 characters")]
        [Required(ErrorMessage = "Please enter your task name")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Please select your task priority")]
        public Priority Priority { get; set; }
    }
}
