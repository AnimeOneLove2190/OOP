using System;
using System.Collections.Generic;
using System.Text;
using EFVaiaa.EntitiesTestDB;
using EFVaiaa.DTOTestDB;
using EFVaiaa.Interfaces;
using System.Linq;

namespace EFVaiaa.Services.TestDBServices
{
    class CourseCRUDService
    {
        public void CreateCourse(CourseCreate courseCreate)
        {
            if (courseCreate == null)
            {
                throw new Exception("CreateCourse: One or more input parameters contain null");
            }
            if (string.IsNullOrEmpty(courseCreate.Name))
            {
                throw new Exception("CreateCourse: Name field is required");
            }
            if (string.IsNullOrEmpty(courseCreate.Description))
            {
                throw new Exception("CreateCourse: Description field is required");
            }
            using (TestDBEFContext context = new TestDBEFContext())
            {
                var course = new Course
                {
                    Name = courseCreate.Name,
                    Description = courseCreate.Description
                };
                context.Add(course);
                context.SaveChanges();
            }
        }
        public CourseView GetCourse(int id)
        {
            using (TestDBEFContext context = new TestDBEFContext())
            {
                var course = context.Courses.FirstOrDefault(x => x.Id == id);
                if (course == null)
                {
                    throw new Exception($"GetCourse: Course with id <{id}> not found");
                }
                return new CourseView
                {
                    Id = course.Id,
                    Name = course.Name,
                    Description = course.Description

                };
            }
        }
        public List<CourseView> GetListCourses()
        {
            using (TestDBEFContext context = new TestDBEFContext())
            {
                var courses = context.Courses.Select(x => new CourseView
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description
                }
                ).ToList();
                return courses;
            }
        }
        public void UpdateCourse(CourseUpdate courseUpdate)
        {
            if (courseUpdate == null)
            {
                throw new Exception("UpdateCourse: One or more input parameters contain null");
            }
            if (string.IsNullOrEmpty(courseUpdate.Name))
            {
                throw new Exception("UpdateCourse: Name field is required");
            }
            if (string.IsNullOrEmpty(courseUpdate.Description))
            {
                throw new Exception("UpdateCourse: Description field is required");
            }
            using (TestDBEFContext context = new TestDBEFContext())
            {
                var course = context.Courses.FirstOrDefault(x => x.Id == courseUpdate.Id);
                if (course == null)
                {
                    throw new Exception($"UpdateCourse: Course with id <{courseUpdate.Id}> not found");
                }
                course.Name = courseUpdate.Name;
                course.Description = courseUpdate.Description;
                context.SaveChanges();
            }
        }
        public void DeleteCourse(int id)
        {
            using (TestDBEFContext context = new TestDBEFContext())
            {
                var course = context.Courses.FirstOrDefault(x => x.Id == id);
                if (course == null)
                {
                    throw new Exception($"DeleteCourse: Course with id <{id}> not found");
                }
                context.Remove(course);
                context.SaveChanges();
            }
        }
    }
}
