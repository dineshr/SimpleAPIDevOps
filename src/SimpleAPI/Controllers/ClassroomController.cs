using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SchoolApp.Services;

namespace SchoolApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClassRoomController : ControllerBase
    {
        private IClassroomService _classroomService;
        public ClassRoomController(IClassroomService classroomService)
        {
            _classroomService = classroomService;
        }

        [HttpPost]
        public ActionResult<bool> AddStudent(Student student)
        {
            if (_classroomService == null)
            {
                return NotFound();
            }
            var result = _classroomService.AddStudent(student);
            return result;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Student>> GetStudents()
        {
            if (_classroomService == null)
            {
                return NotFound();
            }
            var result = _classroomService.GetAllStudents().ToList();
            return result;

        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            string result = string.Empty;
            result = "Something goes here with id: brake test" + id.ToString();
            return result;
        }
    }
}