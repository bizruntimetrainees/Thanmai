using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class StudentDetailsController : ApiController
    {
     //Get deatils
        public IHttpActionResult GetAllStudents()
        {
            IList<StudentDetailsview> students = null;

            using (var ctx = new BizruntimeEntities1())
            {
                students = ctx.StudentDetails.Include("StudentAddress")
                            .Select(s => new StudentDetailsview()
                            {
                                Id = s.Id,
                                FirstName = s.FirstName,
                                LastName = s.LastName
                            }).ToList<StudentDetailsview>();
            }

            if (students.Count == 0)
            {
                return NotFound();
            }

            return Ok(students);


        }

        public StudentDetailsController()
        {
        }

        //Get action methods of the previous section
        public IHttpActionResult PostNewStudent(StudentDetailsview student)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");

            using (var ctx = new BizruntimeEntities1())
            {
                ctx.StudentDetails.Add(new StudentDetail()
                {
                    StudentId = student.Id.ToString(),
                    FirstName = student.FirstName,
                    LastName = student.LastName
                }) ;

                ctx.SaveChanges();
            }

            return Ok();
        }

    }
}
