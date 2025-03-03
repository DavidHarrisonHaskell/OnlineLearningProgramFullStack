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

}
