using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiExample.Models.classes;

namespace WebApiExample.Controllers
{
    public class StudentController : ApiController
    {
        Context c = new Context();
        public IEnumerable<Student> Get()
        {
            return c.students.ToList();
        }

        public Student Get(int id)
        {
            return c.students.FirstOrDefault(x => x.StudentID == id);
        }
        
    }
}
