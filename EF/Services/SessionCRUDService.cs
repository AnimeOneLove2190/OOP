using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using EFVaiaa.DTOCinema;
using EFVaiaa.EntitiesCinema;

namespace EFVaiaa.Services
{
    class SessionCRUDService
    {
        public void CreateSession(SessionCreate sessionCreate)
        {
            if (sessionCreate == null)
            {
                throw new Exception("CreateSession: One or more input parameters contain null");
            }
            if (sessionCreate.Start == null)
            {
                throw new Exception("CreateSession: Start field must not be empty or contain a negative value");
            }
            if (sessionCreate.MovieId <= 0)
            {
                throw new Exception("CreateSession: MovieId field must not be empty or contain a negative value");
            }
            if (sessionCreate.HallId <= 0)
            {
                throw new Exception("CreateSession: HallId field must not be empty or contain a negative value");
            }
            using (CinemaEFContext context = new CinemaEFContext())
            {
                var session = new Session
                {
                    Start = sessionCreate.Start,
                    MovieId = sessionCreate.MovieId,
                    HallId = sessionCreate.HallId,
                };
                context.Add(session);
                context.SaveChanges();
            }
        }
        public SessionView GetSession(int id)
        {
            using (CinemaEFContext context = new CinemaEFContext())
            {
                var session = context.Sessions.FirstOrDefault(x => x.Id == id);
                if (session == null)
                {
                    throw new Exception($"GetSession: Session with id <{id}> not found");
                }
                return new SessionView
                {
                    Id = session.Id,
                    Start = session.Start,
                    MovieId = session.MovieId,
                    HallId = session.HallId,
                };
            }
        }
        public List<SessionView> GetListSessions()
        {
            using (CinemaEFContext context = new CinemaEFContext())
            {
                var sessions = context.Sessions.Select(x => new SessionView
                {
                    Id = x.Id,
                    Start = x.Start,
                    MovieId = x.MovieId,
                    HallId = x.HallId,
                }
                ).ToList();
                return sessions;
            }
        }
        public void UpdateSession(SessionUpdate sessionUpdate)
        {
            if (sessionUpdate == null)
            {
                throw new Exception("UpdateSession: One or more input parameters contain null");
            }
            if (sessionUpdate.Start == null)
            {
                throw new Exception("UpdateSession: Start field must not be empty or contain a negative value");
            }
            if (sessionUpdate.MovieId <= 0)
            {
                throw new Exception("UpdateSession: MovieId field must not be empty or contain a negative value");
            }
            if (sessionUpdate.HallId <= 0)
            {
                throw new Exception("UpdateSession: HallId field must not be empty or contain a negative value");
            }
            using (CinemaEFContext context = new CinemaEFContext())
            {
                var session = context.Sessions.FirstOrDefault(x => x.Id == sessionUpdate.Id);
                if (session == null)
                {
                    throw new Exception($"UpdateSession: Session with id <{sessionUpdate.Id}> not found");
                }
                session.Start = sessionUpdate.Start;
                session.MovieId = sessionUpdate.MovieId;
                session.HallId = sessionUpdate.HallId;
                context.SaveChanges();
            }
        }
        public void DeleteSession(int id)
        {
            using (CinemaEFContext context = new CinemaEFContext())
            {
                var session = context.Sessions.FirstOrDefault(x => x.Id == id);
                if (session == null)
                {
                    throw new Exception($"DeleteSession: Session with id <{id}> not found");
                }
                context.Remove(session);
                context.SaveChanges();
            }
        }
    }
}
