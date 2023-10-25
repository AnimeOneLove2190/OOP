using System;
using System.Collections.Generic;
using System.Text;
using EFVaiaa.EntitiesTestDB;
using EFVaiaa.DTOTestDB;
using EFVaiaa.Interfaces.TestDB;
using System.Linq;

namespace EFVaiaa.Services.TestDBServices
{
    class SomeUserCRUDService : ISomeUserCRUDService
    {
        public void CreateSomeUser(SomeUserCreate someUserCreate)
        {
            if (someUserCreate == null)
            {
                throw new Exception("CreateSomeUser: One or more input parameters contain null");
            }
            if (string.IsNullOrEmpty(someUserCreate.Login))
            {
                throw new Exception("CreateSomeUser: Login field is required");
            }
            if (someUserCreate.RegistrationDate == null)
            {
                throw new Exception("CreateSomeUser: RegistrationDate field is required");
            }
            if (someUserCreate.RegistrationDate < new DateTime(0, 0, 0))
            {
                throw new Exception("CreateSomeUser: RegistrationDate field must not be empty or contain a negative value");
            }
            if (string.IsNullOrEmpty(someUserCreate.FullName))
            {
                throw new Exception("CreateQuestion: FullName field is required");
            }
            using (TestDBEFContext context = new TestDBEFContext())
            {
                var someUser = new SomeUser
                {
                    Login = someUserCreate.Login,
                    RegistrationDate = someUserCreate.RegistrationDate,
                    FullName = someUserCreate.FullName
                };
                context.Add(someUser);
                context.SaveChanges();
            }
        }
        public SomeUserView GetSomeUser(int id)
        {
            using (TestDBEFContext context = new TestDBEFContext())
            {
                var someUser = context.SomeUsers.FirstOrDefault(x => x.Id == id);
                if (someUser == null)
                {
                    throw new Exception($"GetSomeUser: SomeUser with id <{id}> not found");
                }
                return new SomeUserView
                {
                    Id = someUser.Id,
                    Login = someUser.Login,
                    RegistrationDate = someUser.RegistrationDate,
                    FullName = someUser.FullName,
                    PossibleAnswers = someUser.PossibleAnswers
                };
            }
        }
        public List<SomeUserView> GetListSomeUsers()
        {
            using (TestDBEFContext context = new TestDBEFContext())
            {
                var someUsers = context.SomeUsers.Select(x => new SomeUserView
                {
                    Id = x.Id,
                    Login = x.Login,
                    RegistrationDate = x.RegistrationDate,
                    FullName = x.FullName,
                    PossibleAnswers = x.PossibleAnswers
                }
                ).ToList();
                return someUsers;
            }
        }
        public void UpdateSomeUser(SomeUserUpdate someUserUpdate)
        {
            if (someUserUpdate == null)
            {
                throw new Exception("UpdateSomeUser: One or more input parameters contain null");
            }
            if (string.IsNullOrEmpty(someUserUpdate.Login))
            {
                throw new Exception("UpdateSomeUser: Login field is required");
            }
            if (someUserUpdate.RegistrationDate == null)
            {
                throw new Exception("UpdateSomeUser: RegistrationDate field is required");
            }
            if (someUserUpdate.RegistrationDate < new DateTime(0, 0, 0))
            {
                throw new Exception("UpdateSomeUser: RegistrationDate field must not be empty or contain a negative value");
            }
            if (string.IsNullOrEmpty(someUserUpdate.FullName))
            {
                throw new Exception("UpdateSomeUser: FullName field is required");
            }
            using (TestDBEFContext context = new TestDBEFContext())
            {
                var someUser = context.SomeUsers.FirstOrDefault(x => x.Id == someUserUpdate.Id);
                if (someUser == null)
                {
                    throw new Exception($"UpdateSomeUser: SomeUser with id <{someUserUpdate.Id}> not found");
                }
                someUser.Login = someUserUpdate.Login;
                someUser.RegistrationDate = someUserUpdate.RegistrationDate;
                someUser.FullName = someUserUpdate.FullName;
                context.SaveChanges();
            }
        }
        public void DeleteSomeUser(int id)
        {
            using (TestDBEFContext context = new TestDBEFContext())
            {
                var someUser = context.SomeUsers.FirstOrDefault(x => x.Id == id);
                if (someUser == null)
                {
                    throw new Exception($"DeleteSomeUser: SomeUser with id <{id}> not found");
                }
                context.Remove(someUser);
                context.SaveChanges();
            }
        }
    }
}
