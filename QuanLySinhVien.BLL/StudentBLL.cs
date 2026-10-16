using System.Collections.Generic;
using QLSV.DAL;
using QLSV.DAL.Models;

namespace QLSV.BLL
{
    public class StudentBLL
    {
        private readonly StudentDAL _studentDAL = new StudentDAL();

        // Gọi xuống tầng DAL để lấy danh sách sinh viên
        public List<Student> GetStudentList()
        {
            return _studentDAL.GetAllStudents();
        }
    }
}