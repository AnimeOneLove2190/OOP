using System;
using System.Collections.Generic;
using Quest01.Interfaces;
using Quest01.Messages;
using Quest01.Transports;
using Quest01.Computers;
using Quest01.Flats;
using Quest01.Shapes;
using Quest01.Operations;
using Quest01.Employees;
using Quest01.Services;
using Newtonsoft.Json;
using System.IO;
using System.Xml.Serialization;
using Quest01.Products;
using Quest01.PlayLists;
using Quest01.AllPersons;

namespace Quest01
{
    class Program
    {
        static void Main(string[] args)
        {
            var FlatAutoProp = new FlatWithAutoProperties
            {
                FullName = "Зубенко Михаил Петрович",
                Id = 0,
                Type = Flats.Type.fiveRooms
            };
            var employeeOne = new Employee
            {
                FullName = "Зубенко Михаил Петрович",
                Id = 0,
                Job = JobTitle.Mafia,
                Wage = 22500,
                DayOfBirth = new DateTime(1983, 07, 18),
                EmploymentDate = new DateTime(2001, 08, 19)
            };
            var employeeTwo = new Employee
            {
                FullName = "Violet Evergarden",
                Id = 1,
                Job = JobTitle.AutoRecordingDoll,
                Wage = 63567,
                DayOfBirth = new DateTime(2004, 02, 17),
                EmploymentDate = new DateTime(2018, 05, 03)
            };
            var employeeThree = new Employee
            {
                FullName = "Hanji Zoe",
                Id = 2,
                Job = JobTitle.CommanderOfTheParadiseIslandSurveyCorps,
                Wage = 116116,
                DayOfBirth = new DateTime(1982, 06, 06),
                EmploymentDate = new DateTime(2018, 10, 15)
            };
            var employeeList = new List<Employee>
            {
                employeeOne,
                employeeTwo,
                employeeThree
            };
            var employeeService = new EmployeeService();
            var employeesMaxWageList = employeeService.GetEmployeesListMaxWage(employeeList);
            employeesMaxWageList[0].GetInfo();
            var employeesMinWageList = employeeService.GetEmployeesListMinWage(employeeList);
            employeesMinWageList[0].GetInfo();
            var employeesMaxAgeList = employeeService.GetEmployeesListMaxAge(employeeList);
            employeesMaxAgeList[0].GetInfo();
            var employeesMinAgeList = employeeService.GetEmployeesListMinAge(employeeList);
            employeesMinAgeList[0].GetInfo();
            //Feature530
            var helicopter = new Helicopter
            {
                Owner = "Ростех",
                Speed = 250,
                Carrying = 4000
            };
            Console.WriteLine(helicopter.GetInfo());
            var hayachi = new Car
            {
                Owner = "Давлетшин Даниил",
                Speed = 110,
                Сonsumption = 6
            };
            Console.WriteLine(hayachi.GetInfo());
            var meteor = new Boat
            {
                Owner = "Зеленодольский завод имени А. М.Горького",
                Speed = 77,
                Displacement = 53
            };
            Console.WriteLine(meteor.GetInfo());
            //feature531
            var desktop = new DesktopComputer
            {
                Model = "TopComp LP 111902013",
                VideoCard = "AMD Radeon R2",
                RAM = 1,
                CPU = "AMD E1 6010",
                TypeOfShell = TypeOfShell.Vertical,
                BodyMaterial = BodyMaterial.Plastic
            };
            Console.WriteLine(desktop.GetInfo());
            var monoblock = new Monoblock
            {
                Model = "Lenovo C20-05",
                VideoCard = "AMD Radeon R2",
                RAM = 4,
                CPU = "AMD E1-6010",
                BodyMaterial = BodyMaterial.Plastic,
                ScreenDiagonal = 19.5,
                Webcam = true
            };
            Console.WriteLine(monoblock.GetInfo());
            var veteranOfLabourran = new Laptop
            {
                Model = "Lenovo B590",
                VideoCard = "NVIDIA GeForce GT 720M",
                RAM = 8,
                CPU = "Intel(R) Core(TM) i5-3230M",
                BodyMaterial = BodyMaterial.Plastic,
                Webcam = true,
                BatteryCapacity = 202
            };
            Console.WriteLine(veteranOfLabourran.GetInfo());
            //Feature532
            //feature533
            //Мяв
            string meow = "Мяв";
            Console.WriteLine(meow);
            //Ня
            string nya = "Ня";
            Console.WriteLine(nya);
            //feature541
            var tech = new TechnicalService();
            var textService = new TextService();
            var charService = new CharService();
            var text = "Эрвин Смит - 13-й Главнокомандующий Разведкорпуса. Рассудительный, умный и уважаемый человек. Несмотря на аналогичную Леви заботу о членах своего отряда, в случае необходимости без колебаний готов пожертвовать ими ради остального человечества. Он также разработал вид военного построения, позволяющего заранее обнаружить находящегося далеко противника. Также на протяжении большой части своей службы в качестве командира отстаивал независимость Разведкорпуса, тем самым спасая его от расформирования.";
            var charsCount = charService.GetCharStatistics(text);
            tech.WriteDictionary(charsCount);
            //feature542
            var wordsStatistic = textService.GetWordStatistics(text);
            tech.WriteDictionary(wordsStatistic);
            //feature557
            var nagatoro = new Person
            {
                Name = "Nagatoro",
                Hobbies = new List<string>()
            };
            nagatoro.Hobbies.Add("Cats");
            nagatoro.Hobbies.Add("Judo");
            nagatoro.Hobbies.Add("Bullying Hachioji");
            string json = JsonConvert.SerializeObject(nagatoro, Formatting.Indented);
            using (StreamWriter file = File.CreateText("Nagatoro.json"))
            {
                file.Write(json);
            }
            string readFile = string.Empty;
            using (StreamReader reading = File.OpenText("Nagatoro.Json"))
            {
                readFile = reading.ReadToEnd();
            }
            var readPerson = JsonConvert.DeserializeObject<Person>(readFile);
            Console.WriteLine(readPerson.Name);
            for (int i = 0; i < readPerson.Hobbies.Count; i++)
            {
                Console.WriteLine(readPerson.Hobbies[i]);
            }
            //feature559
            var shingekiNoKyojin = new Book
            {
                Title = "Attack on Titan",
                Author = "Hajime Isayama",
                PublicationYear = 2009
            };
            var vampireMaid = new Book
            {
                Title = "The Maid and the Vampire",
                Author = "Yujeong Ju, Yi Dolce",
                PublicationYear = 2019
            };
            var daily = new Book
            {
                Title = "A Pervert's Daily Life",
                Author = "﻿Alice Crazy",
                PublicationYear = 2017
            };
            var bookListOne = new List<Book>
            {
                shingekiNoKyojin,
                vampireMaid,
                daily
            };
            string bookListjson = JsonConvert.SerializeObject(bookListOne, Formatting.Indented);
            Console.WriteLine(bookListjson);
            using (StreamWriter someBookList = File.CreateText("Some Book List.json"))
            {
                someBookList.Write(bookListjson);
            }
            string bookListInfo = string.Empty;
            using (StreamReader readBookList = File.OpenText("Some Book List.json"))
            {
                bookListInfo = readBookList.ReadToEnd();
            }
            var bookListTwo = JsonConvert.DeserializeObject<List<Book>>(bookListInfo);
            for (int i = 0; i < bookListTwo.Count; i++)
            {
                Console.WriteLine($"Title: {bookListTwo[i].Title}");
                Console.WriteLine($"Author: {bookListTwo[i].Author}");
                Console.WriteLine($"PublicationYear: {bookListTwo[i].PublicationYear}");
                Console.WriteLine();
            }
            //feature562
            var houseOne = new House
            {
                Address = "Japan, Tokio",
                Owner = nagatoro
            };
            string houseJson = JsonConvert.SerializeObject(houseOne, Formatting.Indented);
            Console.WriteLine(houseJson);
            using (StreamWriter someHouse = File.CreateText("Some House.json"))
            {
                someHouse.Write(houseJson);
            }
            string someHouseInfo = string.Empty;
            using (StreamReader reading = File.OpenText("Some House.Json"))
            {
                someHouseInfo = reading.ReadToEnd();
            }
            var readHouse = JsonConvert.DeserializeObject<House>(someHouseInfo);
            Console.WriteLine($"Address: {readHouse.Address}");
            Console.WriteLine($"Owner: {readHouse.Owner.Name}");
            //feature561
            var dreamWar = new Song
            {
                Name = "Dream War",
                Author = "Nomico",
                TechDuration = 395,
            };
            var autumWind = new Song
            {
                Name = "Autum Wind",
                Author = "DVRST",
                TechDuration = 129,
            };
            var zeroTwo = new Song
            {
                Name = "Zero Two (So Kawaiina)",
                Author = "Bemax",
                TechDuration = 130,
            };
            var songs = new List<Song>
            {
                dreamWar,
                autumWind,
                zeroTwo
            };
            var playlistOne = new Playlist
            {
                Name = "Some Name",
                Songs = songs
            };
            string playlistJson = JsonConvert.SerializeObject(playlistOne, Formatting.Indented);
            using (StreamWriter somePlaylist = File.CreateText("Some Playlist.json"))
            {
                somePlaylist.Write(playlistJson);
            }
            string playlistInfo = string.Empty;
            using (StreamReader readPlaylist = File.OpenText("Some Playlist.json"))
            {
                playlistInfo = readPlaylist.ReadToEnd();
            }
            var playListTwo = JsonConvert.DeserializeObject<Playlist>(playlistInfo);
            Console.WriteLine($"Name: {playListTwo.Name}");
            Console.WriteLine("Songs:");
            for (int i = 0; i < playListTwo.Songs.Count; i++)
            {
                Console.WriteLine($"Name: {playListTwo.Songs[i].Name}");
                Console.WriteLine($"Author: {playListTwo.Songs[i].Author}");
                Console.WriteLine($"Duration: {playListTwo.Songs[i].Duration}");
                Console.WriteLine();
            }
            //feature558
            var phoneCase = new Product
            {
                Name = "Case for phone",
                Price = 450,
                Category = Categories.PhoneCases
            };
            var passportCover = new Product
            {
                Name = "Passport Cover",
                Price = 150,
                Category = Categories.PassportCovers
            };
            var productListOne = new List<Product>
            {
                phoneCase,
                passportCover
            };
            XmlSerializer xmlConverter = new XmlSerializer(typeof(List<Product>));
            using (FileStream someProductList = new FileStream("Some Product List.xml", FileMode.OpenOrCreate))
            {
                xmlConverter.Serialize(someProductList, productListOne);
            }
            var productListTwo = new List<Product>();
            using (FileStream readProductList = new FileStream("Some Product List.xml", FileMode.OpenOrCreate))
            {
                productListTwo = (List<Product>)xmlConverter.Deserialize(readProductList);
            }
            for (int i = 0; i < productListTwo.Count; i++)
            {
                Console.WriteLine(productListTwo[i].Name);
                Console.WriteLine(productListTwo[i].Price);
                Console.WriteLine(productListTwo[i].Category);
            }
            //feature560
            var laputa = new Movie
            {
                Title = "Tenkuu no Shiro Laputa",
                Director = "Hayao Miyazaki",
                PublicationYear = 1986
            };
            XmlSerializer xmlConverterMovie = new XmlSerializer(typeof(Movie));
            using (FileStream someMovie = new FileStream("Movie.xml", FileMode.OpenOrCreate))
            {
                xmlConverterMovie.Serialize(someMovie, laputa);
            }
            var laputaPlus = new Movie();
            using (FileStream readMovie = new FileStream("Movie.xml", FileMode.OpenOrCreate))
            {
                laputaPlus = (Movie)xmlConverterMovie.Deserialize(readMovie);
            }
            Console.WriteLine(laputaPlus.Title);
            Console.WriteLine(laputaPlus.Director);
            Console.WriteLine(laputaPlus.PublicationYear);
            //feature540
            var morzeService = new MorzeService();
            var textMessage = "Pizdec nahu blyat eti slovari pisat, tam eche probel daze ne pridumali";
            var morzeMessage = morzeService.TranslateIntoMorze(textMessage);
            Console.WriteLine(morzeMessage);
            var textMessageAgain = morzeService.TranslateFromMorze(morzeMessage);
            Console.WriteLine(textMessageAgain);
            var linqService = new LinqService();
            var misato = new Student
            {
                Name = "Misato",
                Age = 29,
                CountOfFriends = 4,
                Spezialisation = Spezialitations.EvangelionSquadTacticalOperationsCommander,
            };
            var asuna = new Student
            {
                Name = "Asuna",
                Age = 19,
                CountOfFriends = 14,
                Spezialisation = Spezialitations.SubleaderOfTheBloodKnightsGuild,
            };
            var violet = new Student
            {
                Name = "Violet",
                Age = 18,
                CountOfFriends = 6,
                Spezialisation = Spezialitations.AutoRecordingDoll,
            };
            var senko = new Student
            {
                Name = "Senko",
                Age = 804,
                CountOfFriends = 4,
                Spezialisation = Spezialitations.GoddessOfFertility,
            };
            var hanji = new Student
            {
                Name = "Hanji",
                Age = 31,
                CountOfFriends = 2,
                Spezialisation = Spezialitations.CommanderOfTheParadiseIslandSurveyCorps,
            };
            var jotaro = new Student
            {
                Name = "Jotaro",
                Age = 53,
                CountOfFriends = 5,
                Spezialisation = Spezialitations.StandUserStandoPawarZaWarudo,
            };
            var studentList = new List<Student>
            {
                misato,
                asuna,
                violet,
                senko,
                hanji,
                jotaro
            };
            //feature565
            Console.WriteLine();
            Console.WriteLine("feature565:");
            linqService.GetFirstStudentWithName(studentList, "Violet");
            //feature566
            linqService.GetProductWithMinPrice(productListOne);
            //feature567
            Console.WriteLine();
            Console.WriteLine("f567:");
            linqService.GetFirstStudentWithAge(studentList, 20);
            //feature568
            Console.WriteLine();
            Console.WriteLine("f568:");
            linqService.GetStdentsWithAgeList(studentList, 19);
            //feature569
            Console.WriteLine();
            Console.WriteLine("f569:");
            //feature570
            Console.WriteLine();
            Console.WriteLine("f570:");
            linqService.GetStudentsListWithSpec(studentList, Spezialitations.AutoRecordingDoll);
            //feature571
            Console.WriteLine();
            Console.WriteLine("f571:");
        }
    }
}
