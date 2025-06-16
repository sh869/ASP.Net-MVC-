using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Crud_2nd.Models;

public partial class AppleContext : DbContext
{
    public AppleContext()
    {
    }

    public AppleContext(DbContextOptions<AppleContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
