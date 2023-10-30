using System;
using System.Collections.Generic;
using System.Text;
using EFVaiaa.DTOTestDB;
using EFVaiaa.Services.TestDBServices;

namespace EFVaiaa.Interfaces.TestDB
{
    interface ISomeUserCRUDService
    {
        public void CreateSomeUser(SomeUserCreate someUserCreate);
        public SomeUserView GetSomeUser(int id);
        public List<SomeUserView> GetListSomeUsers();
        public void UpdateSomeUser(SomeUserUpdate someUserUpdate);
        public void DeleteSomeUser(int id);
    }
}
