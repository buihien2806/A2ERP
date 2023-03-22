﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2ERP.Data.Entities
{
    public class Role : IdentityRole<Guid>
    {
        public string? Description { get; set; }
    }
}
