using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLSV.DAL.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Sửa lại Server cho đúng máy của bạn trước khi chạy thử
            optionsBuilder.UseSqlServer(
            "Server=KAY\\SQLEXPRESS;" +
            "Database=QuanLySinhVien2;" +
            "Trusted_Connection=True;TrustServerCertificate=True;"
            );
        }
    }
}
