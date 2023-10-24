using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using EFVaiaa.EntitiesCinema;
using EFVaiaa.Interfaces;

namespace EFVaiaa.Services
{
    class StatiscicService : IStatiscicService
    {
        public int GetIncome()
        {
            using (CinemaEFContext context = new CinemaEFContext())
            {
                var soldTickets = context.Tickets.Where(x => x.IsSold == true).ToList();
                var sumOfPrice = soldTickets.Sum(x => x.Price);
                return sumOfPrice;
            }
        }
        public int GetIncome(DateTime startDate, DateTime endDate)
        {
            using (CinemaEFContext context = new CinemaEFContext())
            {
                var soldTickets = context.Tickets.Where(x => x.IsSold == true && x.DateOfSale >= startDate && x.DateOfSale <= endDate).ToList();
                var sumOfPrice = soldTickets.Sum(x => x.Price);
                return sumOfPrice;
            }
        }
        public int GetIncome(int movieId)
        {
            using (CinemaEFContext context = new CinemaEFContext())
            {
                var session = context.Sessions.Where(x => x.Id == movieId).ToList();
                if (session == null)
                {
                    throw new Exception($"GetIncomeForWholeTimeByMovie: Movie with id <{movieId}> not found");
                }
                var sessionIds = session.Select(x => x.Id);
                var soldTickets = context.Tickets.Where(x => x.IsSold == true && sessionIds.Contains(x.SessionId)).ToList();
                var income = soldTickets.Sum(x => x.Price);
                return income;
            }
        }
        public int GetIncome(int movieId, DateTime startDate, DateTime endDate)
        {
            using (CinemaEFContext context = new CinemaEFContext())
            {
                var sessionsIds = context.Sessions.Where(x => x.Id == movieId).Select(x => x.Id).ToList();
                if (sessionsIds == null)
                {
                    throw new Exception($"GetIncomeForWholeTimeByMovie: Movie with id <{movieId}> not found");
                }
                var soldTickets = context.Tickets.Where(x => x.IsSold == true && sessionsIds.Contains(x.SessionId) && x.DateOfSale >= startDate && x.DateOfSale <= endDate).ToList();
                var income = soldTickets.Sum(x => x.Price);
                return income;
            }
        }
        public Dictionary<DateTime, int> GetDictionaryIncomesAllTime()
        {
            using (CinemaEFContext context = new CinemaEFContext())
            {
                var dictionaryIncomes = new Dictionary<DateTime, int>();
                var allSoldTickets = context.Tickets.Where(x => x.IsSold == true).ToList();
                for (int i = 0; i < allSoldTickets.Count; i++)
                {
                    var startOfDay = allSoldTickets[i].DateOfSale.Value.Date;
                    DateTime endOfDay = startOfDay.AddDays(1);
                    var soldTicketsInDay = allSoldTickets.Where(x => x.DateOfSale >= startOfDay && x.DateOfSale < endOfDay);
                    var sumOfPrice = soldTicketsInDay.Sum(x => x.Price);
                    if (dictionaryIncomes.ContainsKey(startOfDay))
                    {
                        continue;
                    }
                    dictionaryIncomes.Add(startOfDay, sumOfPrice);
                }
                return dictionaryIncomes;
            }
        }
        public Dictionary<int, int> GetDictionaryIncomesByMovies()
        {
            using (CinemaEFContext context = new CinemaEFContext())
            {
                var dictionaryIncomes = new Dictionary<int, int>();
                var moviesIds = context.Movies.Select(x => x.Id).ToList();
                if (moviesIds == null)
                {
                    throw new Exception($"GetDictionaryIncomesByMovies: Movies not found");
                }
                var sessions = context.Sessions.Where(x => moviesIds.Contains(x.MovieId)).ToList();
                if (sessions == null)
                {
                    throw new Exception($"GetDictionaryIncomesByMovies: Sessions not found");
                }
                var sessionsIds = sessions.Select(x => x.Id).ToList();
                var soldTickets = context.Tickets.Where(x => x.IsSold == true && sessionsIds.Contains(x.SessionId)).ToList();
                for (int i = 0; i < moviesIds.Count; i++)
                {
                    var sumOfPrice = 0;
                    var sessionsByMovie = sessions.Where(x => x.MovieId == moviesIds[i]).Select(x => x.Id).ToList();
                    var soldTicketsByMovieBySession = soldTickets.Where(x => sessionsByMovie.Contains(x.SessionId)).ToList();
                    sumOfPrice = soldTicketsByMovieBySession.Sum(x => x.Price);
                    dictionaryIncomes.Add(moviesIds[i], sumOfPrice);
                }
                return dictionaryIncomes;
            }
        }
        public Dictionary<int, int> GetDictionaryCountOfTicketsByMovies()
        {
            using (CinemaEFContext context = new CinemaEFContext())
            {
                var dictionaryIncomes = new Dictionary<int, int>();
                var moviesIds = context.Movies.Select(x => x.Id).ToList();
                if (moviesIds == null)
                {
                    throw new Exception($"GetDictionaryIncomesByMovies: Movies not found");
                }
                var sessions = context.Sessions.Where(x => moviesIds.Contains(x.MovieId)).ToList();
                if (sessions == null)
                {
                    throw new Exception($"GetDictionaryIncomesByMovies: Sessions not found");
                }
                var sessionsIds = sessions.Select(x => x.Id);
                var soldTickets = context.Tickets.Where(x => x.IsSold == true && sessionsIds.Contains(x.SessionId)).ToList();
                for (int i = 0; i < moviesIds.Count; i++)
                {
                    var sessionsByMovie = sessions.Where(x => x.MovieId == moviesIds[i]).Select(x => x.Id).ToList();
                    var countOfTickets = soldTickets.Count(x => sessionsByMovie.Contains(x.SessionId));
                    dictionaryIncomes.Add(moviesIds[i], countOfTickets);
                }
                return dictionaryIncomes;
            }
        }
        public Dictionary<int, int> GetIncome(List<Movie> filteredMovies)
        {
            using (CinemaEFContext context = new CinemaEFContext())
            {
                var dictionaryIncomes = new Dictionary<int, int>();
                var moviesIds = filteredMovies.Select(x => x.Id).ToList();
                if (moviesIds == null)
                {
                    throw new Exception($"GetDictionaryIncomesByMovies: Movies not found");
                }
                var sessions = context.Sessions.Where(x => moviesIds.Contains(x.MovieId)).ToList();
                if (sessions == null)
                {
                    throw new Exception($"GetDictionaryIncomesByMovies: Sessions not found");
                }
                var sessionsIds = sessions.Select(x => x.Id).ToList();
                var soldTickets = context.Tickets.Where(x => x.IsSold == true && sessionsIds.Contains(x.SessionId)).ToList();
                for (int i = 0; i < moviesIds.Count; i++)
                {
                    var sumOfPrice = 0;
                    var sessionsByMovie = sessions.Where(x => x.MovieId == moviesIds[i]).Select(x => x.Id).ToList();
                    var soldTicketsByMovieBySession = soldTickets.Where(x => sessionsByMovie.Contains(x.SessionId)).ToList();
                    sumOfPrice = soldTicketsByMovieBySession.Sum(x => x.Price);
                    dictionaryIncomes.Add(moviesIds[i], sumOfPrice);
                }
                return dictionaryIncomes;
            }
        }
        public Dictionary<int, Dictionary<int, int>> GetDictionaryIncomesByMoviesByHallsAllTime()
        {
            using (CinemaEFContext context = new CinemaEFContext())
            {
                var dictionaryOfDictionaries = new Dictionary<int, Dictionary<int, int>>();
                var filteredMovieList = new List<Movie>();
                var hallsIds = context.Halls.Select(x => x.Id).ToList();
                if (hallsIds == null)
                {
                    throw new Exception($"GetDictionaryIncomesByMoviesByHallsAllTime: Halls not found");
                }
                var sessions = context.Sessions.Where(x => hallsIds.Contains(x.HallId)).ToList();
                if (sessions == null)
                {
                    throw new Exception($"GetDictionaryIncomesByMovies: Sessions not found");
                }
                var sessionsMovieIds = sessions.Select(x => x.MovieId).ToList();
                var movies = context.Movies.Where(x => sessionsMovieIds.Contains(x.Id)).ToList();
                for (int i = 0; i < hallsIds.Count; i++)
                {
                    var filteredSessionsMovieIds = sessions.Where(x => x.HallId == hallsIds[i]).Select(x => x.MovieId).ToList();
                    filteredMovieList = movies.Where(x => filteredSessionsMovieIds.Contains(x.Id)).ToList();
                    dictionaryOfDictionaries.Add(hallsIds[i], GetIncome(filteredMovieList));
                }
                return dictionaryOfDictionaries;
            }
        }
    }
}

        
