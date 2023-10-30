using System;
using System.Collections.Generic;
using System.Text;
using EFVaiaa.EntitiesTestDB;
using EFVaiaa.DTOTestDB;
using EFVaiaa.Interfaces.TestDB;
using System.Linq;

namespace EFVaiaa.Services.TestDBServices
{
    class TestCRUDService : ITestCRUDService
    {
        public void CreateTest(TestCreate testCreate)
        {
            if (testCreate == null)
            {
                throw new Exception("CreateTest: One or more input parameters contain null");
            }
            if (string.IsNullOrEmpty(testCreate.Name))
            {
                throw new Exception("CreateTest: Name field is required");
            }
            if (string.IsNullOrEmpty(testCreate.Description))
            {
                throw new Exception("CreateTest: Description field is required");
            }
            if (testCreate.CourseId <= 0)
            {
                throw new Exception("CreateTest: CourseId field must not be empty or contain a negative value");
            }
            using (TestDBEFContext context = new TestDBEFContext())
            {
                var test = new Test
                {
                    Name = testCreate.Name,
                    Description = testCreate.Description,
                    CourseId = testCreate.CourseId
                };
                context.Add(test);
                context.SaveChanges();
            }
        }
        public TestView GetTest(int id)
        {
            using (TestDBEFContext context = new TestDBEFContext())
            {
                var test = context.Tests.FirstOrDefault(x => x.Id == id);
                if (test == null)
                {
                    throw new Exception($"GetTest: Test with id <{id}> not found");
                }
                return new TestView
                {
                    Id = test.Id,
                    Name = test.Name,
                    Description = test.Description,
                    CourseId = test.CourseId
                };
            }
        }
        public List<TestView> GetListTests()
        {
            using (TestDBEFContext context = new TestDBEFContext())
            {
                var tests = context.Tests.Select(x => new TestView
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    CourseId = x.CourseId
                }
                ).ToList();
                return tests;
            }
        }
        public void UpdateTest(TestUpdate testUpdate)
        {
            if (testUpdate == null)
            {
                throw new Exception("UpdateTest: One or more input parameters contain null");
            }
            if (string.IsNullOrEmpty(testUpdate.Name))
            {
                throw new Exception("UpdateTest: Name field is required");
            }
            if (string.IsNullOrEmpty(testUpdate.Description))
            {
                throw new Exception("UpdateTest: Description field is required");
            }
            if (testUpdate.CourseId <= 0)
            {
                throw new Exception("UpdateTest: CourseId field must not be empty or contain a negative value");
            }
            using (TestDBEFContext context = new TestDBEFContext())
            {
                var test = context.Tests.FirstOrDefault(x => x.Id == testUpdate.Id);
                if (test == null)
                {
                    throw new Exception($"UpdateTest: Test with id <{testUpdate.Id}> not found");
                }
                test.Name = testUpdate.Name;
                test.Description = testUpdate.Description;
                test.CourseId = testUpdate.CourseId;
                context.SaveChanges();
            }
        }
        public void DeleteTest(int id)
        {
            using (TestDBEFContext context = new TestDBEFContext())
            {
                var test = context.Tests.FirstOrDefault(x => x.Id == id);
                if (test == null)
                {
                    throw new Exception($"DeleteTest: Test with id <{id}> not found");
                }
                context.Remove(test);
                context.SaveChanges();
            }
        }
    }
}
