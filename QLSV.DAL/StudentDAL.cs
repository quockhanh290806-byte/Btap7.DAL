using System.Collections.Generic;
using System.Linq;
using QLSV.DAL.Models;

namespace QLSV.DAL
{
    public class StudentDAL
    {
        // Hàm lấy toàn bộ danh sách sinh viên từ CSDL QuanLySinhVien2
        public List<Student> GetAllStudents()
        {
            using (var context = new AppDbContext())
            {
                return context.Students.ToList();
            }
        }
    }
}