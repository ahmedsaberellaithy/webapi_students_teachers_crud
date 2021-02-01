using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI_Students_Teachers_CRUD.Models;

namespace WebAPI_Students_Teachers_CRUD.Controllers
{
    public class TeacherController : ApiController
    {
        DataClasses1DataContext dataClass = new DataClasses1DataContext();

        public IHttpActionResult getTeachers()
        {
            var teachers = dataClass.Teachers.ToList();
            return Ok(teachers);
        }

        public IHttpActionResult getTeacherRecords(int Id)
        {
            var teacherDetails = (from x in dataClass.Teachers where x.Id == Id select x).FirstOrDefault();
            return Ok(teacherDetails);
        }

        [HttpPost]
        public IHttpActionResult insertTeacher(Teacher teacher)
        {
            dataClass.Teachers.InsertOnSubmit(teacher);
            dataClass.SubmitChanges();
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult updateTeacher(Teacher updateAttributes)
        {
            Teacher teacherDetails = (from x in dataClass.Teachers where x.Id == updateAttributes.Id select x).FirstOrDefault();

            if (teacherDetails != null)
            {
                teacherDetails.firstname = updateAttributes.firstname;
                teacherDetails.lastname = updateAttributes.lastname;
                dataClass.SubmitChanges();
            }
            else
            {
                return NotFound();
            }
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult deleteTeacher(int Id)
        {
            Teacher teacherDetails = (from x in dataClass.Teachers where x.Id == Id select x).FirstOrDefault();

            if (teacherDetails != null)
            {
                dataClass.Teachers.DeleteOnSubmit(teacherDetails);
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
