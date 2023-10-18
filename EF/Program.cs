using System;
using Microsoft.EntityFrameworkCore;
using EFVaiaa.Entities;
using System.Collections.Generic;

namespace EFVaiaa
{
    class Program
    {
        static void Main(string[] args)
        {
            //feature/589
            using (TestDBEFContext context = new TestDBEFContext())
            {
                var course = new Course
                {
                    Name = "Auto recording doll",
                    Description = "Self-recording doll training course"
                };
                var test = new Test
                {
                    Name = "Professional suitability",
                    Description = "Testing the professional skills of the auto-recording doll",
                    CourseId = 1,
                };
                var questionOne = new Question
                {
                    Name = "Letter",
                    Description = "Write a letter on behalf of your sister to your brother",
                    TestId = 1,
                };
                var questionTwo = new Question
                {
                    Name = "Number",
                    Description = "Write 1 or 0",
                    TestId = 1,
                };
                var questionThree = new Question
                {
                    Name = "SomeQuest",
                    Description = "ASDASD",
                    TestId = 1,
                };
                var possibleAnswerOne = new PossibleAnswer
                {
                    Name = "Thank you for being there",
                    IsRight = true,
                    QuestionId = 1,
                };
                var possibleAnswerTwo = new PossibleAnswer
                {
                    Name = "Any meaningful existing text",
                    IsRight = false,
                    QuestionId = 1,
                };
                var possibleAnswerThree = new PossibleAnswer
                {
                    Name = "Null",
                    IsRight = false,
                    QuestionId = 1,
                };
                var possibleAnswerFour = new PossibleAnswer
                {
                    Name = "1",
                    IsRight = true,
                    QuestionId = 2,
                };
                var possibleAnswerFive = new PossibleAnswer
                {
                    Name = "0",
                    IsRight = false,
                    QuestionId = 2,
                };
                var violet = new SomeUser
                {
                    Login = "violet@gmail.ru",
                    RegistrationDate = new DateTime(2018, 09, 04),
                    FullName = "Voilet Evergarden",
                };
                var handji = new SomeUser
                {
                    Login = "hanji@gmail.com",
                    RegistrationDate = new DateTime(2015, 09, 09),
                    FullName = "Hanji Zoe",
                };
                var misato = new SomeUser
                {
                    Login = "misato@gmail.com",
                    RegistrationDate = new DateTime(2005, 09, 04),
                    FullName = "Misato Katsuragi",
                };
                context.Add(course);
                context.SaveChanges();
                context.Add(test);
                context.SaveChanges();
                context.Add(questionOne);
                context.SaveChanges();
                context.Add(questionTwo);
                context.SaveChanges();
                context.Add(questionThree);
                context.SaveChanges();
                context.Add(possibleAnswerOne);
                context.SaveChanges();
                context.Add(possibleAnswerTwo);
                context.SaveChanges();
                context.Add(possibleAnswerThree);
                context.SaveChanges();
                context.Add(possibleAnswerFour);
                context.SaveChanges(); //Ошибка вылетает здесь
                context.Add(possibleAnswerFive);
                context.SaveChanges();
                context.Add(violet);
                context.SaveChanges();
                context.Add(handji);
                context.SaveChanges();
                context.Add(misato);
                context.SaveChanges();
                violet.PossibleAnswers = new List<PossibleAnswer>
                {
                    possibleAnswerOne,
                    possibleAnswerFour
                };
                handji.PossibleAnswers = new List<PossibleAnswer>
                {
                    possibleAnswerTwo,
                    possibleAnswerFive
                };
                misato.PossibleAnswers = new List<PossibleAnswer>
                {
                    possibleAnswerThree,
                };
                possibleAnswerOne.SomeUsers = new List<SomeUser>
                {
                    violet
                };
                possibleAnswerTwo.SomeUsers = new List<SomeUser>
                {
                    handji
                };
                possibleAnswerThree.SomeUsers = new List<SomeUser>
                {
                    misato
                };
                possibleAnswerFour.SomeUsers = new List<SomeUser>
                {
                    violet
                };
                possibleAnswerFive.SomeUsers = new List<SomeUser>
                {
                    handji
                };
                context.SaveChanges();
            };
                Console.WriteLine("Мяв");
        }
    }
}
