using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI_Students_Teachers_CRUD.Models;

namespace WebAPI_Students_Teachers_CRUD.Controllers
{
    public class StudentController : ApiController
    {
        DataClasses1DataContext dataClass = new DataClasses1DataContext();

        public IHttpActionResult getStudents()
        {
            var students = dataClass.Students.ToList();
            return Ok(students);
        }

        public IHttpActionResult getStudentRecords(int Id)
        {
            var studentDetails = (from x in dataClass.Students where x.Id == Id select x).FirstOrDefault();
            return Ok(studentDetails);
        }

        [HttpPost]
        public IHttpActionResult insertStudent(Student student)
        {
            dataClass.Students.InsertOnSubmit(student);
            dataClass.SubmitChanges();
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult updateStudent(Student updateAttributes)
        {
            Student studentDetails = (from x in dataClass.Students where x.Id == updateAttributes.Id select x).FirstOrDefault();

            if (studentDetails != null)
            {
                studentDetails.firstname = updateAttributes.firstname;
                studentDetails.lastname = updateAttributes.lastname;
                dataClass.SubmitChanges();
            }
            else
            {
                return NotFound();
            }
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult deleteStudent(int Id)
        {
            Student studentDetails = (from x in dataClass.Students where x.Id == Id select x).FirstOrDefault();

            if (studentDetails != null)
            {
                dataClass.Students.DeleteOnSubmit(studentDetails);
                dataClass.SubmitChanges();
            }
            else
            {
                return NotFound();
            }
            return Ok();
        }
    }
}
