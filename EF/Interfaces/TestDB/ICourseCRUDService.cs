using System;
using System.Collections.Generic;
using System.Text;
using EFVaiaa.DTOTestDB;
using EFVaiaa.Services.TestDBServices;

namespace EFVaiaa.Interfaces.TestDB
{
    interface ICourseCRUDService
    {
        public void CreateCourse(CourseCreate courseCreate);
        public CourseView GetCourse(int id);
        public List<CourseView> GetListCourses();
        public void UpdateCourse(CourseUpdate courseUpdate);
        public void DeleteCourse(int id);
    }
}
