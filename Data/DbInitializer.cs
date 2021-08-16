using Prueba_1.Models;
using System;
using System.Linq;

namespace Prueba_1.Data
{
    public static class DbInitializer
    {
        public static void Initialize(BankContext context)
        {
            context.Database.EnsureCreated();

            // Look for any clients.
            if (context.Clients.Any())
            {
                return;   // DB has been seeded
            }

            var clients = new Client[]
            {
            new Client{Name="Carson",LastName="Alexanders",BirthDate=DateTime.Parse("2005-09-01")},
            new Client{Name="Meredith",LastName="Alonso",BirthDate=DateTime.Parse("2002-09-01")},
            new Client{Name="Arturo",LastName="Anand",BirthDate=DateTime.Parse("2003-09-01")},
            new Client{Name="Gytis",LastName="Barzdukas",BirthDate=DateTime.Parse("2002-09-01")},
            new Client{Name="Yan",LastName="Li",BirthDate=DateTime.Parse("2002-09-01")},
            new Client{Name="Peggy",LastName="Justice",BirthDate=DateTime.Parse("2001-09-01")},
            new Client{Name="Laura",LastName="Norman",BirthDate=DateTime.Parse("2003-09-01")},
            new Client{Name="Nino",LastName="Olivetto",BirthDate=DateTime.Parse("2005-09-01")}
            };
            foreach (Client s in clients)
            {
                context.Clients.Add(s);
            }
            context.SaveChanges();

            var bills = new Bill[]
            {
            new Bill{Balance=1050,Alias="Chemistry",AccountNumber="31"},
            new Bill{Balance=4022,Alias="Microeconomics",AccountNumber="32"},
            new Bill{Balance=4041,Alias="Macroeconomics",AccountNumber="33"},
            new Bill{Balance=1045,Alias="Calculus",AccountNumber="41"},
            new Bill{Balance=3141,Alias="Trigonometry",AccountNumber="42"},
            new Bill{Balance=2021,Alias="Composition",AccountNumber="34"},
            new Bill{Balance=2042,Alias="Literature",AccountNumber="43"}
            };
            foreach (Bill c in bills)
            {
                context.Bills.Add(c);
            }
            context.SaveChanges();
        }
    }
}