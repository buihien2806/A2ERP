﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2ERP.Data.Configurations
{
    public class TaskConfiguration : IEntityTypeConfiguration<A2ERP.Data.Entities.Task>
    {
        public void Configure(EntityTypeBuilder<A2ERP.Data.Entities.Task> builder)
        {
            builder.ToTable("Tasks");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);
            builder.Property(x => x.AssigneeId).IsRequired(false);

            builder.HasOne(x => x.Assignee).WithMany(x => x.Tasks).HasForeignKey(x => x.AssigneeId);

        }
    }
}
