using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using StudentDataAccess;

namespace WebApi1indexing.Controllers
{
    public class StudentsController : ApiController
    {
        public IEnumerable<Student> Get()
        {
            using (StudentDetailsEntities entities = new StudentDetailsEntities())
            {
                return entities.Students.ToList();
            }
        }

    }
}
