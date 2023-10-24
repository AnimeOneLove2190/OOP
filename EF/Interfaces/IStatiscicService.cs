using System;
using System.Collections.Generic;
using System.Text;
using EFVaiaa.EntitiesCinema;

namespace EFVaiaa.Interfaces
{
    interface IStatiscicService
    {
        public int GetIncome();
        public int GetIncome(DateTime startDate, DateTime endDate);
        public int GetIncome(int movieId);
        public int GetIncome(int movieId, DateTime startDate, DateTime endDate);
        public Dictionary<DateTime, int> GetDictionaryIncomesAllTime();
        public Dictionary<int, int> GetDictionaryIncomesByMovies();
        public Dictionary<int, int> GetDictionaryCountOfTicketsByMovies();
        public Dictionary<int, int> GetIncome(List<Movie> filteredMovies);
        public Dictionary<int, Dictionary<int, int>> GetDictionaryIncomesByMoviesByHallsAllTime();
    }
}
