﻿using Chapter11.CreatingAndUsingObjects;
using System;
using System.Globalization;
using System.Text;

namespace Chapter11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Welcome
    Below are the list of codes in this project
    1   -   IsLeapYear
    2   -   GenerateRandomNumbers
    3   -   GetWeekDay
    4   -   GetOnTime
    5   -   CalculateHypthenus
    6   -   TriangleArea
    7   -   CreatingAndUsingObjects
    8   -   CreateTenCats
    9   -   WorkingDays
    10  -   GetSum
    11  -   AdvertisingMessage
");
            Console.Write("\nEnter option: ");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    IsLeapYear.CheckIfLeapYear();
                    break;
                case 2:
                    GenerateRandoms.randomNumbers();
                    break;
                case 3:
                    GetDay.WeekDay();
                    break;
                case 4:
                    OnTime.GetOnTime();
                    break;
                case 5:
                    Pythagorean.CalculateHypothenus();
                    break;
                case 6:
                    TriangleArea.GetArea();
                    break;
                case 8:
                    CreateObjects.CreateTenCats();
                    break;
                case 9:
                    WorkingDay.CountWorkDays();
                    break;
                case 10:
                    GetSum.CalculateSum();
                    break;
                case 11:
                    AdvertisingMessage.ShowAdvertisingMessage();
                    break;
                default:
                    break;
            }

            Console.WriteLine("\n\nPress the enter key to exit.");
            Console.ReadLine();
        }
    }

    static class IsLeapYear
    {
        public static void CheckIfLeapYear()
        {
            Console.Write("Enter year: ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine( DateTime.IsLeapYear(year));
        }
    }

    static class GenerateRandoms
    {
        public static void randomNumbers()
        {
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(rand.Next(100, 201));
            }
        }
    }

    static class GetDay
    {
        public static void WeekDay()
        {
            Console.WriteLine(DateTime.Today.DayOfWeek);   
            Console.Write("Testing");
        }
    }

    static class OnTime
    {
        public static void GetOnTime()
        {
            int sec = Environment.TickCount/1000;
            int days = sec / 86400; sec -= (days * 86400);
            int hours = sec / 3600; sec -= (hours * 3600);
            int mins = sec / 60; sec -= (mins * 60);
            Console.WriteLine(days + " days, " + hours + " hours, " + mins + " mins and " + sec + " seconds.");
        }
    }

    static class Pythagorean
    {
        public static void CalculateHypothenus()
        {
            Console.Write("Enter a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Enter b: ");
            double b = double.Parse(Console.ReadLine());

            double c = Math.Sqrt((a * a) + (b * b));
            Console.WriteLine("The magnitude of the Hypthenus is " + c);
        }
    }

    static class TriangleArea
    {
        public static void GetArea()
        {
            Console.WriteLine(@"Which of the following describes the values you have?
    1   -   three sides
    2   -   side and the altitude to it
    3   -   two sides and the angle between them in degrees");
            Console.Write("\nEnter option: ");
            int option = int.Parse(Console.ReadLine());
            double area = 0;
            switch (option)
            {
                case 1:
                    area = ThreeSide();
                    break;
                case 2:
                    area = SideAndAltitude();
                    break;
                case 3:
                    area = TwoSides();
                    break;
                default:
                    break;
            }

            Console.WriteLine("\nThe area of the triangle is " + area);
        }

        static double ThreeSide()
        {
            Console.Write("Enter length of first side: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Enter length of second side: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Enter length of third side: ");
            double c = double.Parse(Console.ReadLine());

            double p = (a + b + c) / 2;
            double Area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return Area;
        }

        static double SideAndAltitude()
        {
            Console.Write("Enter length of side: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Enter height: ");
            double b = double.Parse(Console.ReadLine());

            double Area = (a * b) / 2;
            return Area;
        }

        static double TwoSides()
        {
            Console.Write("Enter length of first side: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Enter length of second side: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Enter angle between the sides (in degrees): ");
            double angle = double.Parse(Console.ReadLine());

            double Area = (a * b * Math.Sin(angle)) / 2;
            return Area;
        }
    }


    namespace CreatingAndUsingObjects
    {
        public class Sequence
        {
            // Static field, holding the current sequence value
            private static int currentValue = 0;
            // Intentionally deny instantiation of this class
            private Sequence()
            {
            }
            // Static method for taking the next sequence value
            public static int NextValue()
            {
                currentValue++;
                return currentValue;

            }
        }
        public class Cat
        {
            // Field name
            private string name;
            // Field color
            private string color;
            public string Name
            {
                // Getter of the property "Name"
                get
                {
                    return this.name;
                }
                // Setter of the property "Name"
                set
                {
                    this.name = value;
                }
            }
            public string Color
            {
                // Getter of the property "Color"
                get
                {
                    return this.color;
                }
                // Setter of the property "Color"
                set
                {
                    this.color = value;
                }
            }
            // Default constructor
            public Cat()
            {
                this.name = "Unnamed";
                this.color = "gray";
            }
            // Constructor with parameters
            public Cat(string name, string color)
            {
                this.name = name;
                this.color = color;
            }
            // Method SayMiau
            public void SayMiau()
            {
                Console.WriteLine("Cat {0} said: Miauuuuuu!", name);
            }
        }
    }
    namespace CallingObjects
    {
        static class Create
        {
            static void CreateCat()
            {
                Cat firstCat = new Cat();
                firstCat.Name = "Tony";
                firstCat.SayMiau();
                Cat secondCat = new Cat("Pepy", "red");
                secondCat.SayMiau();
                Console.WriteLine("Cat {0} is {1}.",
                 secondCat.Name, secondCat.Color);
            }

            static void CreateSequence()
            {
                Console.WriteLine("Sequence[1...3]: {0}, {1}, {2}", Sequence.NextValue(), Sequence.NextValue(), Sequence.NextValue());
            }
        }
    }

    static class CreateObjects
    {
        public static void CreateTenCats()
        {
            Cat[] Cats = new Cat[10];
            foreach (var item in Cats)
            {
                item.Name = "Cat" + Sequence.NextValue().ToString();
            }
            foreach (var item in Cats)
            {
                item.SayMiau();
            }
        }
    }

    static class WorkingDay
    {
        static DayOfWeek[] notworkdays = new DayOfWeek[] { DayOfWeek.Saturday, DayOfWeek.Sunday};

        public static void CountWorkDays()
        {
            string format = "dd/MM/yyyy";
            Console.Write("Enter date (dd/mm/yyyy): ");
            DateTime parsedDate = DateTime.ParseExact(
             Console.ReadLine(), format, CultureInfo.InvariantCulture);
            DateTime present = DateTime.Now.Date;
            int count = 0;
            while(present.CompareTo(parsedDate) != 0)
            {
                bool workDay = true;
                foreach ( DayOfWeek day in notworkdays)
                {
                    if (present.DayOfWeek.CompareTo(day) == 0)
                    {
                        workDay = false;
                    }
                }
                if (workDay)
                {
                    count++;
                }
                present = present.AddDays(1);
            }
            Console.WriteLine("\n\nThere are {0} working days between now({2:dd/MM/yyyy}) and {1:dd/MM/yyyy}.", count, parsedDate, DateTime.Now.Date);
        }        
    }

    static class GetSum
    {
        public static void CalculateSum()
        {
            Console.Write("Enter numbers (seperated by space):  ");
            string numberString = Console.ReadLine();
            string[] strNumbers = numberString.Split(" ");
            int sum = 0;
            foreach (string num in strNumbers)
            {
                sum += int.Parse(num);
            }
            Console.WriteLine("\nThe sum of the numbers is {0}", sum);
        }
    }

    static class AdvertisingMessage
    {
        private static string[] laudatoryPhrases = new string[] {"The product is excellent.", "This is a great product.", "I use this product constantly.", "This is the best product from this category."};
        private static string[] laudatoryStories = new string[] {"Now I feel better.", "I managed to change.", "It made some miracle.", "I can’t believe it, but now I am feeling great.", "You should try it, too. I am very satisfied."};
        private static string[] firstName = new string[] { "Dayan", "Stella", "Hellen", "Kate" };
        private static string[] lastName = new string[] { "Johnson", "Peterson", "Charls" };
        private static string[] cities = new string[] { "London", "Paris", "Berlin", "New York", "Madrid" };

        private static string message;
        public static string Message { get => message; }
        public static void ShowAdvertisingMessage()
        {
            StringBuilder temp = new StringBuilder();
            temp.Append(laudatoryPhrases[new Random().Next(laudatoryPhrases.Length)]);
            temp.Append(" ");
            temp.Append(laudatoryStories[new Random().Next(laudatoryStories.Length)]);
            temp.Append(" -- ");
            temp.Append(firstName[new Random().Next(firstName.Length)]);
            temp.Append(" ");
            temp.Append(lastName[new Random().Next(lastName.Length)]);
            temp.Append(", ");
            temp.Append(cities[new Random().Next(cities.Length)]);

            message = temp.ToString();
            Console.WriteLine(message);
        }
    }
}
