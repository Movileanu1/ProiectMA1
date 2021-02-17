using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProiectMA.Models;


namespace ProiectMA.Data
{
    public class DbInitializer
    {
        public static void Initialize(LibraryContext context)
        {
            context.Database.EnsureCreated();
            if (context.Cars.Any())
            {
                return; // BD a fost creata anterior
            }
            var books = new Car[]
            {
 new Car{Model="A1",Brand="Audi",Price=Decimal.Parse("22")},
 new Car{Model="A2 Otiliei",Brand="Audi",Price=Decimal.Parse("18")},
 new Car{Model="A3",Brand="Audi",Price=Decimal.Parse("27")},
 new Car{Model="A4",Brand="Audi",Price=Decimal.Parse("45")},
 new Car{Model="A5",Brand="Audi",Price=Decimal.Parse("38")},
 new Car{Model="A6",Brand="Audi",Price=Decimal.Parse("28")},
            };
            foreach (Car b in books)
            {
                context.Cars.Add(b);
            }
            context.SaveChanges();
            var customers = new Customer[]
            {

 new Customer{CustomerID=1050,Name="PopescuMarcela",BirthDate=DateTime.Parse("1979-09-01")},
 new Customer{CustomerID=1045,Name="MihailescuCornel",BirthDate=DateTime.Parse("1969-07-08")},

            };
            foreach (Customer c in customers)
            {
                context.Customers.Add(c);
            }
            context.SaveChanges();
            var orders = new Order[]
            {
 new Order{CarID=1,CustomerID=1050,OrderDate=DateTime.Parse("02-25-2020")},
 new Order{CarID=3,CustomerID=1045,OrderDate=DateTime.Parse("09-28-2020")},
 new Order{CarID=1,CustomerID=1045,OrderDate=DateTime.Parse("10-28-2020")},
 new Order{CarID=2,CustomerID=1050,OrderDate=DateTime.Parse("09-28-2020")},
 new Order{CarID=4,CustomerID=1050,OrderDate=DateTime.Parse("09-28-2020")},
 new Order{CarID=6,CustomerID=1050,OrderDate=DateTime.Parse("10-28-2020")},
 };
            foreach (Order e in orders)
            {
                context.Orders.Add(e);
            }
            context.SaveChanges();
            var publishers = new publisher[]
            {

 new Publisher{PublisherName="Humanitas",Adress="Str. Aviatorilor, nr. 40,Bucuresti"},
 new Publisher{PublisherName="Nemira",Adress="Str. Plopilor, nr. 35,Ploiesti"},
 new Publisher{PublisherName="Paralela 45",Adress="Str. Cascadelor, nr.22, Cluj-Napoca"},
            };
            foreach (Publisher p in publishers)
            {
                context.Publishers.Add(p);
            }
            context.SaveChanges();
            var publishedcars = new PublishedCar[]
            {
 new PublishedCar {
 CarID = cars.Single(c => c.Model == "A1" ).ID, PublisherID = publishers.Single(i => i.PublisherName =="Audi").ID
 },
 new PublishedCar {
 CarID = cars.Single(c => c.Model == "A2" ).ID,PublisherID = publishers.Single(i => i.PublisherName =="Audi").ID
 },
 new PublishedCar {
 CarID = cars.Single(c => c.Model == "A3" ).ID,PublisherID = publishers.Single(i => i.PublisherName =="Audi").ID
 },
 new PublishedCar {
 CarID = cars.Single(c => c.Model == "A4" ).ID,PublisherID = publishers.Single(i => i.PublisherName == "Audi").ID
 },
 new PublishedCar {
 CarID = cars.Single(c => c.Model == "A4" ).ID,PublisherID = publishers.Single(i => i.PublisherName == "Audi").ID
 },
 new PublishedCar {CarID = cars.Single(c => c.Model == "A6" ).ID,PublisherID = publishers.Single(i => i.PublisherName == "Audi").ID
 },
            };
            foreach (PublishedCar pb in publishedcars)
            {
                context.PublishedCars.Add(pb);
            }
            context.SaveChanges();
        }
    }
}
