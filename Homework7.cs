using System;
namespace Vehicles
{
    class Program
    {
        class Motorcycle
        {
            private string model;
            private string colour;
            private int year;
            private int speed;
            public Motorcycle()
            {
                model = null;
                colour = null;
                year = 0;
                speed = 0;
            }
            public Motorcycle(string model, string colour, int year, int speed)
            {
                this.model = model;
                this.colour = colour;
                this.year = year;
                this.speed = speed;
            }
            public string Model
            {
                set
                {
                    model = value;
                }
                get
                {
                    return model;
                }
            }
            public string Colour
            {
                set
                {
                    colour = value;
                }
                get
                {
                    return colour;
                }
            }
            public int Year
            {
                set
                {
                    year = value;
                }
                get
                {
                    return year;
                }
            }
            public int Speed
            {
                set
                {
                    speed = value;
                }
                get
                {
                    return speed;
                }
            }
        }
        class Car
        {
            private string brand;
            private string model;
            private string colour;
            private int registrationNumber;
            private int years;
            private int seatsNumber;
            private bool isDiesel;
            public Car()
            {
                brand = null;
                model = null;
                colour = null;
                registrationNumber = 0;
                years = 0;
                SeatsNumber = 0;
                isDiesel = false;
            }
            public Car(string brand, string model, string colour, int RegistrationNumber, int years, int SeatsNumber, bool isDiesel)
            {
                this.brand = brand;
                this.model = model;
                this.colour = colour;
                this.registrationNumber = RegistrationNumber;
                this.years = years;
                this.SeatsNumber = SeatsNumber;
                this.isDiesel = isDiesel;
            }
            public string Brand
            {
                set
                {
                    brand = value;
                }
                get
                {
                    return brand;
                }
            }
            public string Model
            {
                set
                {
                    model = value;
                }
                get
                {
                    return model;
                }
            }
            public string Colour
            {
                set
                {
                    colour = value;
                }
                get
                {
                    return colour;
                }
            }
            public int RegistrationNumber
            {
                set
                {
                    registrationNumber = value;
                }
                get
                {
                    return registrationNumber;
                }
            }
            public int Years
            {
                set
                {
                    years = value;
                }
                get
                {
                    return years;
                }
            }
            public int SeatsNumber
            {
                set
                {
                    seatsNumber = value;
                }
                get
                {
                    return seatsNumber;
                }
            }
            public bool IsDiesel
            {
                set
                {
                    isDiesel = value;
                }
                get
                {
                    return isDiesel;
                }
            }
            public void Print()
            {
                Console.WriteLine("Brand:{0}", brand);
                Console.WriteLine("Model:{0}", Model);
                Console.WriteLine("Colour:{0}", Colour);
                Console.WriteLine("RegistrationNumber:{0}", RegistrationNumber);
                Console.WriteLine("Years:{0}", Years);
                Console.WriteLine("SeatsNumber:{0}", SeatsNumber);
                Console.WriteLine("IsDiesel:{0}", isDiesel);
            }
        }
        class Person
        {
            private string name;
            private string egn;
            public Person()
            {
                name = null;
                egn = null;
            }
            public Person(string name, string egn)
            {
                this.name = name;
                this.egn = egn;
            }
            public string Name
            {
                set
                {
                    name = value;
                }
                get
                {
                    return name;
                }
            }
            public string Egn
            {
                set
                {
                    egn = value;
                }
                get
                {
                    return egn;
                }
            }
        }
        struct Flower
        {
            public string Name { set; get; }
            public string Colour { set; get; }
            public double Height { set; get; }
            public void Blossom()
            {
                Console.WriteLine("Flower {0} with colour {1} and height {2} blossoms", Name, Colour, Height);
            }
        }
        class Temperature
        {
            public const int p = 32;
            public const double k = 1.8;
            public static double Convert(int degree)
            {
                return (degree * k) / p;
            }
        }
        class Library
        {
            private string location;
            private int area;
            private int year;
            public Library()
            {
                location = null;
                area = 0;
                year = 0;
            }
            public Library(string location,int area,int year)
            {
                this.location = location;
                this.area = area;
                this.year = year;
            }
            public string Location
            {
                set
                {
                    location = null;
                }
                get
                {
                    return location;
                }
            }
            public int Area
            {
                set
                {
                    area = value;
                }
                get
                {
                    return area;
                }
            }
            public int Year
            {
                set
                {
                    year = value;
                }
                get
                {
                    return year;
                }
            }
        }
        class Book
        {
            private int pages;
            private int year;
            private string author;
            private string caption;
            public Book()
            {
                pages = 0;
                year = 0;
                author = null;
                caption = null;
            }
            public Book(int pages,int year,string author,string caption)
            {
                this.pages = pages;
                this.year = year;
                this.author = author;
                this.caption = caption;
            }
            public int Pages
            {
                set
                {
                    pages = value;
                }
                get
                {
                    return pages;
                }
            }
            public int Year
            {
                set
                {
                    year = value;
                }
                get
                {
                    return year;
                }
            }
            public string Author
            {
                set
                {
                    author = value;
                }
                get
                {
                    return author;
                }
            }
            public string Caption
            {
                set
                {
                    caption = value;
                }
                get
                {
                    return caption;
                }
            }
            public int Print(int page)
            {
                if(page>0 && page<=this.Pages)
                {
                    return page;
                }
                else
                {
                    return -1;
                }
            }
        }
        static void Main()
        {
            Motorcycle motor1 = new Motorcycle("Yahama", "Green", 1987, 200);
            Motorcycle motor2 = new Motorcycle("Honda", "Red", 1996, 250);
            Motorcycle motor3 = new Motorcycle("Kazawaki", "Blue", 2000, 300);
            Motorcycle[] motors = new Motorcycle[3] { motor1, motor2, motor3 };
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Motor {0}:", i + 1);
                Console.WriteLine("Model:{0}", motors[i].Model);
                Console.WriteLine("Colour:{0}", motors[i].Colour);
                Console.WriteLine("Year:{0}", motors[i].Year);
                Console.WriteLine("Speed:{0}", motors[i].Speed);
                Console.WriteLine();
            }
            Car car1 = new Car();
            car1.Brand = "Mazda";
            car1.Model = "CX-30";
            car1.Colour = "Red";
            car1.RegistrationNumber = 9616;
            car1.Years = 1;
            car1.SeatsNumber = 5;
            car1.IsDiesel = false;
            car1.Print();
            Console.WriteLine();
            Person person1 = new Person("Ivan", "9707133429");
            Person person2 = new Person("Toni", "9606153894");
            Person person3 = new Person("Milen", "9502133784");
            Person person4 = new Person("George", "1315328204");
            Person person5 = new Person("Nikolay", "3208756489");
            Person person6 = new Person("Desi", "4840482421");
            Person person7 = new Person("Hristo", "3245678391");
            Person person8 = new Person("Stanislav", "9901153162");
            Person person9 = new Person("Stefan", "9137830121");
            Person person10 = new Person("Milena", "3821932142");
            Person[] people = new Person[10] { person1, person2, person3, person4, person5, person6, person7, person8, person9, person10 };
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Person {0}", i + 1);
                Console.WriteLine("Name:{0}", people[i].Name);
                Console.WriteLine("Egn:{0}", people[i].Egn);
                Console.WriteLine();
            }
            Console.WriteLine();
            Flower flower = new Flower();
            flower.Name = "Roza";
            flower.Colour = "Red";
            flower.Height = 2.5;
            Console.WriteLine("Name:{0}", flower.Name);
            Console.WriteLine("Colour:{0}", flower.Colour);
            Console.WriteLine("Height:{0}", flower.Height);
            flower.Blossom();
            Console.WriteLine();
            Console.WriteLine("50 degrees in Celsius is {0} in Fahrenheit", Temperature.Convert(50));
            Library library = new Library("Pazardjik", 2000, 2019);
            Console.WriteLine();
            Console.WriteLine("Location:{0}", library.Location);
            Console.WriteLine("Area:{0}", library.Area);
            Console.WriteLine("Year:{0}", library.Year);
            Console.WriteLine();
            Book book = new Book(500, 1900, "Ivan Vazov", "Pod Igoto");
            Console.WriteLine("Pages:{0}", book.Pages);
            Console.WriteLine("Year:{0}", book.Year);
            Console.WriteLine("Author:{0}", book.Author);
            Console.WriteLine("Caption:{0}", book.Caption);
            if(book.Print(100)!=-1)
            {
                Console.WriteLine("Page is:{0}", book.Print(100));
            }
            else
            {
                Console.WriteLine("No such page in the book");
            }

              
          }
      }
  }

