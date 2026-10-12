using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using JobTracker.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobTracker.Infrastructure.Configurations;

public class ReminderConfiguration : IEntityTypeConfiguration<Reminder>
{
    public void Configure(EntityTypeBuilder<Reminder> builder)
    {
        builder.Property(x => x.Note)
            .HasMaxLength(500);
        builder.HasOne(x => x.JobApplication)
            .WithMany()
            .HasForeignKey(x => x.JobApplicationId);
    }
}
