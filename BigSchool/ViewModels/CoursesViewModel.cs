using BigSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BigSchool.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
        public List<Category> Categories { get; internal set; }
        public int Id { get; internal set; }
        public string Place { get; internal set; }
        public byte Category { get; internal set; }

        internal object GetDateTime()
        {
            throw new NotImplementedException();
        }
    }
    
}