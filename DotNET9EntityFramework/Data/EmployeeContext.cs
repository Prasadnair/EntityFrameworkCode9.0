﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using Microsoft.EntityFrameworkCore;

namespace Data.Entities;

public partial class EmployeeContext : DbContext,IDbContext
{
    public EmployeeContext(DbContextOptions<EmployeeContext> options)
        : base(options)
    {
    }

    public virtual DbSet<EmployeeSalary> EmployeeSalaries => Set<EmployeeSalary>();

    public Task ExecuteStoredProcedureAsync(string storedProcName, object parameters = null)
    {
        throw new NotImplementedException();
    }

    async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return await base.SaveChangesAsync(cancellationToken);
    }
    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EmployeeSalary>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EmployeeSalary", "Employee");

            entity.Property(e => e.EmpName)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}