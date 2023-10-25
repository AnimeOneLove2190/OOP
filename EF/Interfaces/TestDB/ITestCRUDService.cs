using System;
using System.Collections.Generic;
using System.Text;
using EFVaiaa.DTOTestDB;
using EFVaiaa.Services.TestDBServices;

namespace EFVaiaa.Interfaces.TestDB
{
    interface ITestCRUDService
    {
        public void CreateTest(TestCreate testCreate);
        public TestView GetTest(int id);
        public List<TestView> GetListTests();
        public void UpdateTest(TestUpdate testUpdate);
        public void DeleteTest(int id);
    }
}
