using System.Collections.Generic;

namespace SchoolApp.Services
{
    public interface IClassroomService
    {
        bool AddStudent(Student student);

        IEnumerable<Student> GetAllStudents();


    }
}