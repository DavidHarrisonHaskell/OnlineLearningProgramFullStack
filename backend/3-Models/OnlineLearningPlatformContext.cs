using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace backend;

public class OnlineLearningPlatformContext : DbContext
{
    public OnlineLearningPlatformContext()
    {

    }

    public OnlineLearningPlatformContext(DbContextOptions<OnlineLearningPlatformContext> options) : base(options)
    {

    }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<Enrollment> Enrollments { get; set; }

    public virtual DbSet<Lesson> Lessons { get; set; }

    public virtual DbSet<Progress> Progresses { get; set; }

    public virtual DbSet<User> Users { get; set; }
}
