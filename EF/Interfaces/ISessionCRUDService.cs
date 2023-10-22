using System;
using System.Collections.Generic;
using System.Text;
using EFVaiaa.DTOCinema;

namespace EFVaiaa.Interfaces
{
    interface ISessionCRUDService
    {
        public void CreateSession(SessionCreate sessionCreate);
        public SessionView GetSession(int id);
        public List<SessionView> GetListSessions();
        public void UpdateSession(SessionUpdate sessionUpdate);
        public void DeleteSession(int id);
    }
}
