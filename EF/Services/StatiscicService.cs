using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using EFVaiaa.EntitiesCinema;

namespace EFVaiaa.Services
{
    class StatiscicService
    {
        readonly private TechService techService;
        public StatiscicService()
        {
            this.techService = new TechService();
        }
        public int GetIncomeForWholeTime()
        {
            using (CinemaEFContext context = new CinemaEFContext())
            {
                var soldTickets = context.Tickets.Where(x => x.IsSold == true).ToList();
                var sumOfPrice = soldTickets.Sum(x => x.Price);
                return sumOfPrice;
            }
        }
        public int GetIncomeForSpecifiedPeriod(DateTime startDate, DateTime endDate)
        {
            using (CinemaEFContext context = new CinemaEFContext())
            {
                var soldTickets = context.Tickets.Where(x => x.IsSold == true && x.DateOfSale >= startDate && x.DateOfSale <= endDate).ToList();
                var sumOfPrice = soldTickets.Sum(x => x.Price);
                return sumOfPrice;
            }
        }
        public int GetIncomeForWholeTimeByMovie(int movieId)
        {
            using (CinemaEFContext context = new CinemaEFContext())
            {
                var session = context.Sessions.Where(x => x.Id == movieId).ToList();
                if (session == null)
                {
                    throw new Exception($"GetIncomeForWholeTimeByMovie: Movie with id <{movieId}> not found");
                }
                var income = 0;
                for (int i = 0; i < session.Count; i++)
                {
                    var soldTickets = context.Tickets.Where(x => x.IsSold == true && x.SessionId == session[i].Id).ToList();
                    var sumOfPrice = soldTickets.Sum(x => x.Price);
                    income = +sumOfPrice;
                }
                return income;
            }
        }
        public int GetIncomeForSpecifiedPeriodByMovie(int movieId, DateTime startDate, DateTime endDate)
        {
            using (CinemaEFContext context = new CinemaEFContext())
            {
                var session = context.Sessions.Where(x => x.Id == movieId).ToList();
                if (session == null)
                {
                    throw new Exception($"GetIncomeForWholeTimeByMovie: Movie with id <{movieId}> not found");
                }
                var income = 0;
                for (int i = 0; i < session.Count; i++)
                {
                    var soldTickets = context.Tickets.Where(x => x.IsSold == true && x.SessionId == session[i].Id && x.DateOfSale >= startDate && x.DateOfSale <= endDate).ToList();
                    var sumOfPrice = soldTickets.Sum(x => x.Price);
                    income = +sumOfPrice;
                }
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
                    DateTime startOfDay = (DateTime)allSoldTickets[i].DateOfSale;
                    var year = startOfDay.Year;
                    var month = startOfDay.Month;
                    var day = startOfDay.Day;
                    startOfDay = new DateTime(year, month, day);
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
                var movies = context.Movies.ToList();
                if (movies == null)
                {
                    throw new Exception($"GetDictionaryIncomesByMovies: Movies not found");
                }
                for (int i = 0; i < movies.Count; i++)
                {
                    var sessions = context.Sessions.Where(x => x.MovieId == movies[i].Id).ToList();
                    if (sessions == null)
                    {
                        throw new Exception($"GetDictionaryIncomesByMovies: Sessions not found");
                    }
                    for (int j = 0; j < sessions.Count; j++)
                    {
                        var soldTicketsByMovie = context.Tickets.Where(x => x.IsSold == true && x.SessionId == sessions[j].Id);
                        var sumOfPrice = soldTicketsByMovie.Sum(x => x.Price);
                        if (dictionaryIncomes.ContainsKey(movies[i].Id))
                        {
                            continue;
                        }
                        dictionaryIncomes.Add(movies[i].Id, sumOfPrice);
                    }
                }
                return dictionaryIncomes;
            }
        }
        public Dictionary<int, int> GetDictionaryCountOfTicketsByMovies()
        {
            using (CinemaEFContext context = new CinemaEFContext())
            {
                var dictionaryIncomes = new Dictionary<int, int>();
                var movies = context.Movies.ToList();
                if (movies == null)
                {
                    throw new Exception($"GetDictionaryCountOfTicketsByMovies: Movies not found");
                }
                for (int i = 0; i < movies.Count; i++)
                {
                    var sessions = context.Sessions.Where(x => x.MovieId == movies[i].Id).ToList();
                    if (sessions == null)
                    {
                        throw new Exception($"GetDictionaryCountOfTicketsByMovies: Sessions not found");
                    }
                    for (int j = 0; j < sessions.Count; j++)
                    {
                        var soldTicketsByMovie = context.Tickets.Count(x => x.IsSold == true && x.SessionId == sessions[j].Id);
                        if (dictionaryIncomes.ContainsKey(movies[i].Id))
                        {
                            continue;
                        }
                        dictionaryIncomes.Add(movies[i].Id, soldTicketsByMovie);
                    }
                }
                return dictionaryIncomes;
            }
        }
        public Dictionary<int, int> GetDictionaryIncomesByFilteredListMovies(List<Movie> filteredMovies)
        {
            using (CinemaEFContext context = new CinemaEFContext())
            {
                var dictionaryIncomes = new Dictionary<int, int>();

                if (filteredMovies == null)
                {
                    throw new Exception($"GetDictionaryIncomesByFilteredListMovies: Movies not found");
                }
                for (int i = 0; i < filteredMovies.Count; i++)
                {
                    var sessions = context.Sessions.Where(x => x.MovieId == filteredMovies[i].Id).ToList();
                    if (sessions == null)
                    {
                        throw new Exception($"GetDictionaryIncomesByMovies: Sessions not found");
                    }
                    for (int j = 0; j < sessions.Count; j++)
                    {
                        var soldTicketsByMovie = context.Tickets.Where(x => x.IsSold == true && x.SessionId == sessions[j].Id);
                        var sumOfPrice = soldTicketsByMovie.Sum(x => x.Price);
                        if (dictionaryIncomes.ContainsKey(filteredMovies[i].Id))
                        {
                            continue;
                        }
                        dictionaryIncomes.Add(filteredMovies[i].Id, sumOfPrice);
                    }
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
                var halls = context.Halls.ToList();
                if (halls == null)
                {
                    throw new Exception($"GetDictionaryIncomesByMoviesByHallsAllTime: Halls not found");
                }
                for (int i = 0; i < halls.Count; i++)
                {
                    var sessions = context.Sessions.Where(x => x.HallId == halls[i].Id).ToList();
                    if (sessions == null)
                    {
                        throw new Exception($"GetDictionaryIncomesByMoviesByHallsAllTime: Sessions not found");
                    }
                    for (int j = 0; j < sessions.Count; j++)
                    {
                        var someMovie = context.Movies.FirstOrDefault(x => x.Id == sessions[j].MovieId);
                        filteredMovieList.Add(someMovie);
                        if (filteredMovieList == null)
                        {
                            throw new Exception($"GetDictionaryIncomesByMoviesByHallsAllTime: Movies not found");
                        }
                    }
                    dictionaryOfDictionaries.Add(halls[i].Id, GetDictionaryIncomesByFilteredListMovies(filteredMovieList));
                }
                return dictionaryOfDictionaries;
            }
        }
    }
}

        
