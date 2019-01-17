//using System;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata;
//using VesselBlenders.Models;

//namespace VesselBlenders.Models
//{
//    public partial class VesselBlenderContext : DbContext
//    {
//        public virtual DbSet<Customer> Customer { get; set; }
//        public virtual DbSet<Employee> Employee { get; set; }
//        public virtual DbSet<Invoice> Invoice { get; set; }
//        public virtual DbSet<Status> Status { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer(@"Server=mis-sql.uhcl.edu;Database=VesselBlender;User ID=KundapuraShaS9726;Password=!1615655$");
//            }
//        }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            modelBuilder.Entity<Customer>(entity =>
//            {
//                entity.HasKey(e => e.CustId);

//                entity.ToTable("customer");

//                entity.HasIndex(e => e.CustName)
//                    .HasName("customer$customercust_name");

//                entity.Property(e => e.CustId).HasColumnName("cust_id");

//                entity.Property(e => e.CustAddr)
//                    .HasColumnName("cust_addr")
//                    .HasMaxLength(255);

//                entity.Property(e => e.CustEmail)
//                    .HasColumnName("cust_email")
//                    .HasMaxLength(255);

//                entity.Property(e => e.CustName)
//                    .HasColumnName("cust_name")
//                    .HasMaxLength(255);

//                entity.Property(e => e.CustPhone)
//                    .HasColumnName("cust_phone")
//                    .HasMaxLength(255);
//            });

//            modelBuilder.Entity<Employee>(entity =>
//            {
//                entity.HasKey(e => e.EmpId);

//                entity.ToTable("employee");

//                entity.HasIndex(e => e.EmpFname)
//                    .HasName("employee$employeeemp_fname");

//                entity.HasIndex(e => e.EmpLname)
//                    .HasName("employee$employeeemp_lname");

//                entity.Property(e => e.EmpId).HasColumnName("emp_id");

//                entity.Property(e => e.EmpEmail)
//                    .HasColumnName("emp_email")
//                    .HasMaxLength(255);

//                entity.Property(e => e.EmpFname)
//                    .HasColumnName("emp_fname")
//                    .HasMaxLength(255);

//                entity.Property(e => e.EmpHdate)
//                    .HasColumnName("emp_hdate")
//                    .HasColumnType("datetime2(0)");

//                entity.Property(e => e.EmpLname)
//                    .HasColumnName("emp_lname")
//                    .HasMaxLength(255);

//                entity.Property(e => e.EmpPhone)
//                    .HasColumnName("emp_phone")
//                    .HasMaxLength(255);

//                entity.Property(e => e.EmpSal)
//                    .HasColumnName("emp_sal")
//                    .HasDefaultValueSql("((0))");

//                entity.Property(e => e.EmpTitle)
//                    .HasColumnName("emp_title")
//                    .HasMaxLength(255);
//            });

//            modelBuilder.Entity<Invoice>(entity =>
//            {
//                entity.HasKey(e => e.InvId);

//                entity.ToTable("invoice");

//                entity.HasIndex(e => e.CustId)
//                    .HasName("invoice$cust_id1");

//                entity.HasIndex(e => e.InvDate)
//                    .HasName("invoice$cust_id");

//                entity.HasIndex(e => e.OrderId)
//                    .HasName("invoice$orderinvoice")
//                    .IsUnique();

//                entity.Property(e => e.InvId).HasColumnName("inv_id");

//                entity.Property(e => e.CustId)
//                    .HasColumnName("cust_id")
//                    .HasDefaultValueSql("((0))");

//                entity.Property(e => e.DueDate)
//                    .HasColumnName("due_date")
//                    .HasMaxLength(255);

//                entity.Property(e => e.InvAmt)
//                    .HasColumnName("inv_amt")
//                    .HasColumnType("money")
//                    .HasDefaultValueSql("((0))");

//                entity.Property(e => e.InvDate)
//                    .HasColumnName("inv_date")
//                    .HasColumnType("datetime2(0)");

//                entity.Property(e => e.OrderId)
//                    .HasColumnName("order_id")
//                    .HasDefaultValueSql("((0))");
//            });

//            modelBuilder.Entity<Status>(entity =>
//            {
//                entity.ToTable("status");

//                entity.Property(e => e.StatusId).HasColumnName("status_id");

//                entity.Property(e => e.StatusName)
//                    .HasColumnName("status_name")
//                    .HasMaxLength(255);
//            });
//        }

//        public DbSet<VesselBlenders.Models.EmployeeIncentive> EmployeeIncentive { get; set; }
//    }
//}
