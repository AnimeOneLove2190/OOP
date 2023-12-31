﻿using System;
using Microsoft.EntityFrameworkCore;
using EFVaiaa.EntitiesTestDB;
using System.Collections.Generic;
using EFVaiaa.EntitiesCinema;
using EFVaiaa.EntitiesTaskTrack;
using EFVaiaa.DTOCinema;
using EFVaiaa.Interfaces;
using EFVaiaa.Services;
using EFVaiaa.Services.TestDBServices;
using EFVaiaa.DTOTestDB;

namespace EFVaiaa
{
    class Program
    {
        static void Main(string[] args)
        {
            //feature/589
            //using (TestDBEFContext context = new TestDBEFContext())
            //{
            //    var course = new Course
            //    {
            //        Name = "Auto recording doll",
            //        Description = "Self-recording doll training course"
            //    };
            //    var test = new Test
            //    {
            //        Name = "Professional suitability",
            //        Description = "Testing the professional skills of the auto-recording doll",
            //        CourseId = 1,
            //    };
            //    var questionOne = new Question
            //    {
            //        Name = "Letter",
            //        Description = "Write a letter on behalf of your sister to your brother",
            //        TestId = 1,
            //    };
            //    var questionTwo = new Question
            //    {
            //        Name = "Number",
            //        Description = "Write 1 or 0",
            //        TestId = 1,
            //    };
            //    var questionThree = new Question
            //    {
            //        Name = "SomeQuest",
            //        Description = "ASDASD",
            //        TestId = 1,
            //    };
            //    var possibleAnswerOne = new PossibleAnswer
            //    {
            //        Name = "Thank you for being there",
            //        IsRight = true,
            //        QuestionId = 1,
            //    };
            //    var possibleAnswerTwo = new PossibleAnswer
            //    {
            //        Name = "Any meaningful existing text",
            //        IsRight = false,
            //        QuestionId = 1,
            //    };
            //    var possibleAnswerThree = new PossibleAnswer
            //    {
            //        Name = "Null",
            //        IsRight = false,
            //        QuestionId = 1,
            //    };
            //    var possibleAnswerFour = new PossibleAnswer
            //    {
            //        Name = "1",
            //        IsRight = true,
            //        QuestionId = 2,
            //    };
            //    var possibleAnswerFive = new PossibleAnswer
            //    {
            //        Name = "0",
            //        IsRight = false,
            //        QuestionId = 2,
            //    };
            //    var violet = new SomeUser
            //    {
            //        Login = "violet@gmail.ru",
            //        RegistrationDate = new DateTime(2018, 09, 04),
            //        FullName = "Voilet Evergarden",
            //    };
            //    var handji = new SomeUser
            //    {
            //        Login = "hanji@gmail.com",
            //        RegistrationDate = new DateTime(2015, 09, 09),
            //        FullName = "Hanji Zoe",
            //    };
            //    var misato = new SomeUser
            //    {
            //        Login = "misato@gmail.com",
            //        RegistrationDate = new DateTime(2005, 09, 04),
            //        FullName = "Misato Katsuragi",
            //    };
            //    context.Add(course);
            //    context.SaveChanges();
            //    context.Add(test);
            //    context.SaveChanges();
            //    context.Add(questionOne);
            //    context.SaveChanges();
            //    context.Add(questionTwo);
            //    context.SaveChanges();
            //    context.Add(questionThree);
            //    context.SaveChanges();
            //    context.Add(possibleAnswerOne);
            //    context.SaveChanges();
            //    context.Add(possibleAnswerTwo);
            //    context.SaveChanges();
            //    context.Add(possibleAnswerThree);
            //    context.SaveChanges();
            //    context.Add(possibleAnswerFour);
            //    context.SaveChanges(); //Ошибка вылетает здесь
            //    context.Add(possibleAnswerFive);
            //    context.SaveChanges();
            //    context.Add(violet);
            //    context.SaveChanges();
            //    context.Add(handji);
            //    context.SaveChanges();
            //    context.Add(misato);
            //    context.SaveChanges();
            //    violet.PossibleAnswers = new List<PossibleAnswer>
            //    {
            //        possibleAnswerOne,
            //        possibleAnswerFour
            //    };
            //    handji.PossibleAnswers = new List<PossibleAnswer>
            //    {
            //        possibleAnswerTwo,
            //        possibleAnswerFive
            //    };
            //    misato.PossibleAnswers = new List<PossibleAnswer>
            //    {
            //        possibleAnswerThree,
            //    };
            //    possibleAnswerOne.SomeUsers = new List<SomeUser>
            //    {
            //        violet
            //    };
            //    possibleAnswerTwo.SomeUsers = new List<SomeUser>
            //    {
            //        handji
            //    };
            //    possibleAnswerThree.SomeUsers = new List<SomeUser>
            //    {
            //        misato
            //    };
            //    possibleAnswerFour.SomeUsers = new List<SomeUser>
            //    {
            //        violet
            //    };
            //    possibleAnswerFive.SomeUsers = new List<SomeUser>
            //    {
            //        handji
            //    };
            //    context.SaveChanges();
            //};
            //    Console.WriteLine("Мяв589");
            //feature590
            //using (CinemaEFContext context = new CinemaEFContext())
            //{
            //    var hallOne = new Hall
            //    {
            //        Name = "Hall One"
            //    };
            //    context.Add(hallOne);
            //    context.SaveChanges();
            //    for (int i = 1; i <= 5; i++)
            //    {
            //        var row = new Row
            //        {
            //            Number = i,
            //            HallId = 1,
            //        };
            //        context.Add(row);
            //        context.SaveChanges();
            //        for(int j = 1; j <= 10; j++)
            //        {
            //            var place = new Place
            //            {
            //                Capacity = 1,
            //                RowId = i,
            //                Number = j
            //            };
            //            context.Add(place);
            //            context.SaveChanges();
            //        }
            //    }
            //    var violet = new Movie
            //    {
            //        Name = "Violet Evergarden. Movie",
            //        Description = "Her job is to write letters. Her name is Violet Evergarden. Several years have passed since the end of the war, which inflicted deep wounds on many. The world is gradually regaining peace, people are returning to their normal lives. Violet is trying to learn to live without the person most important to her, but one day she receives a letter, and the flame of hope flares up in her chest again.",
            //        Duration = 139
            //    };
            //    context.Add(violet);
            //    context.SaveChanges();
            //    var laputa = new Movie
            //    {
            //        Name = "Tenkuu no Shiro Laputa",
            //        Description = "Альтернативная реальность, соответствующая началу XX века. В руках девочки по имени Сита находится Летающий Камень. За ним охотятся агенты правительства и пираты, потому что Камень представляет огромную ценность. Пытаясь скрыться от преследователей, Сита встречает Падзу, своего ровесника, работающего в шахтерском городке. Вместе дети выясняют, что Камень — ключ к таинственному летающему острову Лапута.",
            //        Duration = 125
            //    };
            //    context.Add(laputa);
            //    context.SaveChanges();
            //    var yourName = new Movie
            //    {
            //        Name = "Your Name",
            //        Description = "Токийский парень Таки и провинциальная девушка Мицуха обнаруживают, что между ними существует странная связь. Во сне они меняются телами и проживают жизни друг друга. Но однажды эта способность исчезает так же внезапно, как появилась. Таки решает во что бы то ни стало отыскать Мицуху.",
            //        Duration = 110
            //    };
            //    context.Add(yourName);
            //    context.SaveChanges();
            //    var genreOne = new Genre
            //    {
            //        Name = "Romance",
            //        Description = "Emotionally elevated attitude created by various ideas, feelings, emotions, and living conditions",
            //    };
            //    context.Add(genreOne);
            //    context.SaveChanges();
            //    var genreTwo = new Genre
            //    {
            //        Name = "Multfilm",
            //        Description = "",
            //    };
            //    context.Add(genreTwo);
            //    context.SaveChanges();
            //    var genreThree = new Genre
            //    {
            //        Name = "Drama",
            //        Description = "",
            //    };
            //    context.Add(genreThree);
            //    context.SaveChanges();
            //    var genreFour = new Genre
            //    {
            //        Name = "Melodrama",
            //        Description = "",
            //    };
            //    context.Add(genreFour);
            //    context.SaveChanges();
            //    var sessionOne = new Session
            //    {
            //        Start = new DateTime(2020, 04, 15, 09, 00, 00),
            //        MovieId = 1,
            //        HallId = 1,
            //    };
            //    context.Add(sessionOne);
            //    context.SaveChanges();
            //    var sessionTwo = new Session
            //    {
            //        Start = new DateTime(2008, 02, 28, 09, 00, 00),
            //        MovieId = 2,
            //        HallId = 1,
            //    };
            //    context.Add(sessionTwo);
            //    context.SaveChanges();
            //    var sessionThree = new Session
            //    {
            //        Start = new DateTime(2017, 06, 07, 09, 00, 00),
            //        MovieId = 3,
            //        HallId = 1,
            //    };
            //    context.Add(sessionThree);
            //    context.SaveChanges();
            //    var ticketOne = new Ticket
            //    {
            //        IsSold = true,
            //        DateOfSale = new DateTime(2020, 04, 14, 00, 00, 00),
            //        Price = 450,
            //        PlaceId = 1,
            //        SessionId =1,
            //    };
            //    context.Add(ticketOne);
            //    context.SaveChanges();
            //    var ticketTwo = new Ticket
            //    {
            //        IsSold = true,
            //        DateOfSale = new DateTime(2020, 04, 14, 01, 00, 00),
            //        Price = 450,
            //        PlaceId = 4,
            //        SessionId = 1,
            //    };
            //    context.Add(ticketTwo);
            //    context.SaveChanges();
            //    var ticketThree = new Ticket
            //    {
            //        IsSold = false,
            //        DateOfSale = null,
            //        Price = 450,
            //        PlaceId = 2,
            //        SessionId = 1,
            //    };
            //    context.Add(ticketThree);
            //    context.SaveChanges();
            //    var ticketFour = new Ticket
            //    {
            //        IsSold = true,
            //        DateOfSale = new DateTime(2008, 02, 27, 00, 00, 00),
            //        Price = 300,
            //        PlaceId = 2,
            //        SessionId = 2,
            //    };
            //    context.Add(ticketFour);
            //    context.SaveChanges();
            //    violet.Genres = new List<Genre>
            //    {
            //        genreOne,
            //        genreTwo,
            //        genreThree,
            //        genreFour,
            //    };
            //    genreOne.Movies = new List<Movie>
            //    {
            //        violet,
            //    };
            //    genreTwo.Movies = new List<Movie>
            //    {
            //        violet,
            //    };
            //    genreThree.Movies = new List<Movie>
            //    {
            //        violet,
            //    };
            //    genreFour.Movies = new List<Movie>
            //    {
            //        violet,
            //    };
            //    context.SaveChanges();
            //}
            //Console.WriteLine("Мяв590");
            //feature/591
            //using (TaskTrackEFContext context = new TaskTrackEFContext())
            //{
            //    var violet = new SomeUserTasks
            //    {
            //        Name = "Violet",
            //        Email = "violet.evergarden@gmail.ru",
            //        RegistrationDate = new DateTime(2018, 03, 05)
            //    };
            //    context.Add(violet);
            //    context.SaveChanges();
            //    var handji = new SomeUserTasks
            //    {
            //        Name = "Handji",
            //        Email = "hanji@gmail.com",
            //        RegistrationDate = new DateTime(2015, 09, 09)
            //    };
            //    context.Add(handji);
            //    context.SaveChanges();
            //    var misato = new SomeUserTasks
            //    {
            //        Name = "Misato",
            //        Email = "misato@gmail.com",
            //        RegistrationDate = new DateTime(2005, 09, 09)
            //    };
            //    context.Add(misato);
            //    context.SaveChanges();
            //    var violetRole = new Role
            //    {
            //        Name = "Auto Recording Doll"
            //    };
            //    context.Add(violetRole);
            //    context.SaveChanges();
            //    var handjiRole = new Role
            //    {
            //        Name = "14th Commander-in-Chief of the Survey Corps"
            //    };
            //    context.Add(handjiRole);
            //    context.SaveChanges();
            //    var misatoRole = new Role
            //    {
            //        Name = "Evangelion Squad Tactical Operations Commander"
            //    };
            //    context.Add(misatoRole);
            //    context.SaveChanges();
            //    var taskOne = new Task
            //    {
            //        Name = "Find Gilbert",
            //        IsCompleted = true,
            //    };
            //    context.Add(taskOne);
            //    context.SaveChanges();
            //    var taskTwo = new Task
            //    {
            //        Name = "Get both your hands back",
            //        IsCompleted = false,
            //    };
            //    context.Add(taskTwo);
            //    context.SaveChanges();
            //    var taskThree = new Task
            //    {
            //        Name = "Prevent the third impact",
            //        IsCompleted = false,
            //    };
            //    context.Add(taskThree);
            //    context.SaveChanges();
            //    var taskFour = new Task
            //    {
            //        Name = "Save Eldia",
            //        IsCompleted = true,
            //    };
            //    context.Add(taskFour);
            //    context.SaveChanges();
            //    var taskFive = new Task
            //    {
            //        Name = "Save humanity",
            //        IsCompleted = false,
            //    };
            //    context.Add(taskFive);
            //    context.SaveChanges();
            //    var taskSix = new Task
            //    {
            //        Name = "Head Wille",
            //        IsCompleted = true,
            //    };
            //    context.Add(taskSix);
            //    context.SaveChanges();
            //    var taskSeven = new Task
            //    {
            //        Name = "Recover after the war",
            //        IsCompleted = true,
            //    };
            //    context.Add(taskSeven);
            //    context.SaveChanges();
            //    violet.Tasks = new List<Task>
            //    {
            //        taskOne,
            //        taskTwo,
            //        taskSeven
            //    };
            //    handji.Tasks = new List<Task>
            //    {
            //        taskFour,
            //        taskFive
            //    };
            //    misato.Tasks = new List<Task>
            //    {
            //        taskThree,
            //        taskFive,
            //        taskSix
            //    };
            //    taskOne.SomeUsers = new List<SomeUserTasks>
            //    {
            //        violet
            //    };
            //    taskTwo.SomeUsers = new List<SomeUserTasks>
            //    {
            //        violet
            //    };
            //    taskThree.SomeUsers = new List<SomeUserTasks>
            //    {
            //        misato
            //    };
            //    taskFour.SomeUsers = new List<SomeUserTasks>
            //    {
            //        handji
            //    };
            //    taskFive.SomeUsers = new List<SomeUserTasks>
            //    {
            //        handji,
            //        misato
            //    };
            //    taskSix.SomeUsers = new List<SomeUserTasks>
            //    {
            //        misato
            //    };
            //    taskSeven.SomeUsers = new List<SomeUserTasks>
            //    {
            //        violet
            //    };
            //    violet.Roles = new List<Role>
            //    {
            //        violetRole
            //    };
            //    handji.Roles = new List<Role>
            //    {
            //        handjiRole
            //    };
            //    misato.Roles = new List<Role>
            //    {
            //        misatoRole
            //    };
            //    violetRole.SomeUsers = new List<SomeUserTasks>
            //    {
            //        violet
            //    };
            //    handjiRole.SomeUsers = new List<SomeUserTasks>
            //    {
            //        handji
            //    };
            //    misatoRole.SomeUsers = new List<SomeUserTasks>
            //    {
            //        misato
            //    };
            //    context.SaveChanges();
            //}
            //Console.WriteLine("Мяв591");
            //system preparation
            //using (CinemaEFContext context = new CinemaEFContext())
            //{
            //    var hallOne = new Hall
            //    {
            //        Name = "Hall One"
            //    };
            //    context.Add(hallOne);
            //    context.SaveChanges();
            //    for (int i = 1; i <= 5; i++)
            //    {
            //        var row = new Row
            //        {
            //            Number = i,
            //            HallId = 1,
            //        };
            //        context.Add(row);
            //        context.SaveChanges();
            //        for(int j = 1; j <= 10; j++)
            //        {
            //            var place = new Place
            //            {
            //                Capacity = 1,
            //                RowId = i,
            //                Number = j
            //            };
            //            context.Add(place);
            //            context.SaveChanges();
            //        }
            //    }
            //    var violet = new Movie
            //    {
            //        Name = "Violet Evergarden. Movie",
            //        Description = "Her job is to write letters. Her name is Violet Evergarden. Several years have passed since the end of the war, which inflicted deep wounds on many. The world is gradually regaining peace, people are returning to their normal lives. Violet is trying to learn to live without the person most important to her, but one day she receives a letter, and the flame of hope flares up in her chest again.",
            //        Duration = 139
            //    };
            //    context.Add(violet);
            //    context.SaveChanges();
            //    var laputa = new Movie
            //    {
            //        Name = "Tenkuu no Shiro Laputa",
            //        Description = "Альтернативная реальность, соответствующая началу XX века. В руках девочки по имени Сита находится Летающий Камень. За ним охотятся агенты правительства и пираты, потому что Камень представляет огромную ценность. Пытаясь скрыться от преследователей, Сита встречает Падзу, своего ровесника, работающего в шахтерском городке. Вместе дети выясняют, что Камень — ключ к таинственному летающему острову Лапута.",
            //        Duration = 125
            //    };
            //    context.Add(laputa);
            //    context.SaveChanges();
            //    var yourName = new Movie
            //    {
            //        Name = "Your Name",
            //        Description = "Токийский парень Таки и провинциальная девушка Мицуха обнаруживают, что между ними существует странная связь. Во сне они меняются телами и проживают жизни друг друга. Но однажды эта способность исчезает так же внезапно, как появилась. Таки решает во что бы то ни стало отыскать Мицуху.",
            //        Duration = 110
            //    };
            //    context.Add(yourName);
            //    context.SaveChanges();
            //    var genreOne = new Genre
            //    {
            //        Name = "Romance",
            //        Description = "Emotionally elevated attitude created by various ideas, feelings, emotions, and living conditions",
            //    };
            //    context.Add(genreOne);
            //    context.SaveChanges();
            //    var genreTwo = new Genre
            //    {
            //        Name = "Multfilm",
            //        Description = "",
            //    };
            //    context.Add(genreTwo);
            //    context.SaveChanges();
            //    var genreThree = new Genre
            //    {
            //        Name = "Drama",
            //        Description = "",
            //    };
            //    context.Add(genreThree);
            //    context.SaveChanges();
            //    var genreFour = new Genre
            //    {
            //        Name = "Melodrama",
            //        Description = "",
            //    };
            //    context.Add(genreFour);
            //    context.SaveChanges();
            //    var sessionOne = new Session
            //    {
            //        Start = new DateTime(2020, 04, 15, 09, 00, 00),
            //        MovieId = 1,
            //        HallId = 1,
            //    };
            //    context.Add(sessionOne);
            //    context.SaveChanges();
            //    var sessionTwo = new Session
            //    {
            //        Start = new DateTime(2008, 02, 28, 09, 00, 00),
            //        MovieId = 2,
            //        HallId = 1,
            //    };
            //    context.Add(sessionTwo);
            //    context.SaveChanges();
            //    var sessionThree = new Session
            //    {
            //        Start = new DateTime(2017, 06, 07, 09, 00, 00),
            //        MovieId = 3,
            //        HallId = 1,
            //    };
            //    context.Add(sessionThree);
            //    context.SaveChanges();
            //    var ticketOne = new Ticket
            //    {
            //        IsSold = true,
            //        DateOfSale = new DateTime(2020, 04, 14, 00, 00, 00),
            //        Price = 450,
            //        PlaceId = 1,
            //        SessionId =1,
            //    };
            //    context.Add(ticketOne);
            //    context.SaveChanges();
            //    var ticketTwo = new Ticket
            //    {
            //        IsSold = true,
            //        DateOfSale = new DateTime(2020, 04, 14, 01, 00, 00),
            //        Price = 450,
            //        PlaceId = 4,
            //        SessionId = 1,
            //    };
            //    context.Add(ticketTwo);
            //    context.SaveChanges();
            //    var ticketThree = new Ticket
            //    {
            //        IsSold = false,
            //        DateOfSale = null,
            //        Price = 450,
            //        PlaceId = 2,
            //        SessionId = 1,
            //    };
            //    context.Add(ticketThree);
            //    context.SaveChanges();
            //    var ticketFour = new Ticket
            //    {
            //        IsSold = true,
            //        DateOfSale = new DateTime(2008, 02, 27, 00, 00, 00),
            //        Price = 300,
            //        PlaceId = 2,
            //        SessionId = 2,
            //    };
            //    context.Add(ticketFour);
            //    context.SaveChanges();
            //    violet.Genres = new List<Genre>
            //    {
            //        genreOne,
            //        genreTwo,
            //        genreThree,
            //        genreFour,
            //    };
            //    genreOne.Movies = new List<Movie>
            //    {
            //        violet,
            //    };
            //    genreTwo.Movies = new List<Movie>
            //    {
            //        violet,
            //    };
            //    genreThree.Movies = new List<Movie>
            //    {
            //        violet,
            //    };
            //    genreFour.Movies = new List<Movie>
            //    {
            //        violet,
            //    };
            //    context.SaveChanges();
            //}
            //Console.WriteLine("Мяв590");
            //system preparation
            //feature/595
            //var genreCRUDService = new GenreCRUDService();
            //var createComedy = new GenreCreate
            //{
            //    Name = "Comedy",
            //    Description = "Жанр художественного произведения, характеризующийся юмористическим или сатирическим подходами, и также вид драмы, в котором специфически разрешается момент действенного конфликта или борьбы"
            //};
            //var createAnime = new GenreCreate
            //{
            //    Name = "Anime"
            //};
            //var updateDrama = new GenreUpdate
            //{
            //    Id = 3,
            //    Name = "Drama",
            //    Description = "литературный (драматический) и сценический жанр. Получил особое распространение в литературе XVIII−XXI веков, постепенно вытеснив другой жанр драматургии — трагедию, противопоставив ему преимущественно бытовой сюжет и более приближенный к обыденной реальности стиль."
            //};
            //genreCRUDService.Create(createComedy);
            //genreCRUDService.Create(createAnime);
            //genreCRUDService.Update(updateDrama);
            //genreCRUDService.Delete(6);
            //Console.WriteLine("Мяв595");
            //feature/596
            //var hallCRUDService = new HallCRUDService();
            //var places = hallCRUDService.GetAllPlacesInHall(1);
            //for (int i= 0; i < places.Count; i++)
            //{
            //    Console.WriteLine($"Id: {places[i].Id} Capacity: {places[i].Capacity} Number: {places[i].Number} RowId: {places[i].RowId}");
            //}
            //var seansService = new SeansService();
            //seansService.CreateSeans(1, 3, 350);
            //feature/597
            var statisticService = new StatiscicService();
            var techService = new TechService();
            int allIncome = statisticService.GetIncome();
            Console.WriteLine(allIncome);
            int incomeForSpecifiedPeriod = statisticService.GetIncome(new DateTime(2015, 01, 01), new DateTime(2025, 01, 01));
            Console.WriteLine(incomeForSpecifiedPeriod);
            var incomeAllTimeByMovie = statisticService.GetIncome(1);
            Console.WriteLine(incomeAllTimeByMovie);
            var incomeForSpecifiedPeriodByMovie = statisticService.GetIncome(1, new DateTime(2020, 04, 14, 00, 30, 00), new DateTime(2020, 04, 15));
            Console.WriteLine(incomeForSpecifiedPeriodByMovie);
            var dictionaryIncomesAllTime = statisticService.GetDictionaryIncomesAllTime();
            techService.WriteDictionary(dictionaryIncomesAllTime);
            var dictionaryIncomesByMovies = statisticService.GetDictionaryIncomesByMovies();
            techService.WriteDictionary(dictionaryIncomesByMovies);
            var dictionaryTicketsByMovies = statisticService.GetDictionaryCountOfTicketsByMovies();
            techService.WriteDictionary(dictionaryTicketsByMovies);
            var dictionaryOfDictionaries = statisticService.GetDictionaryIncomesByMoviesByHallsAllTime();
            techService.WriteDictionary(dictionaryOfDictionaries);
            //var hallCRUDService = new HallCRUDService();
            //var places = hallCRUDService.GetAllPlacesInHall(1);
            //for (int i= 0; i < places.Count; i++)
            //{
            //    Console.WriteLine($"Id: {places[i].Id} Capacity: {places[i].Capacity} Number: {places[i].Number} RowId: {places[i].RowId}");
            //}
            //var seansService = new SeansService();
            //seansService.CreateSeans(1, 3, 350);
            //feature/598
            var recordAnswerCRDService = new RecordAnswerCRUDService();
            //var recordAnswerCreate = new RecordAnswerCreate
            //{
            //    SomeUserId = 3,
            //    PossibleAnswerId = 5
            //};
            //recordAnswerCRDService.CreateRecordAnswer(recordAnswerCreate);
            var allRecordAnswers = recordAnswerCRDService.GetRecordAnswersList();
            for (int i= 0; i < allRecordAnswers.Count; i++)
            {
                Console.WriteLine($"User: {allRecordAnswers[i].SomeUserId}){allRecordAnswers[i].SomeUserName} - Answer: {allRecordAnswers[i].PossibleAnswerId}){allRecordAnswers[i].PossibleAnswerName}");
            }
        }
    }
}
