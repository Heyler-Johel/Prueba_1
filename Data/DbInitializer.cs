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
            new Client{Name="Carson",LastName="Alexanders",IdentificationCard="117",BirthDate=DateTime.Parse("2005-09-01")},
            new Client{Name="Meredith",LastName="Alonso",IdentificationCard="118",BirthDate=DateTime.Parse("2002-09-01")},
            new Client{Name="Arturo",LastName="Anand",IdentificationCard="119",BirthDate=DateTime.Parse("2003-09-01")},
            new Client{Name="Gytis",LastName="Barzdukas",IdentificationCard="120",BirthDate=DateTime.Parse("2002-09-01")},
            new Client{Name="Yan",LastName="Li",IdentificationCard="121",BirthDate=DateTime.Parse("2002-09-01")},
            new Client{Name="Peggy",LastName="Justice",IdentificationCard="122",BirthDate=DateTime.Parse("2001-09-01")},
            new Client{Name="Laura",LastName="Norman",IdentificationCard="123",BirthDate=DateTime.Parse("2003-09-01")},
            new Client{Name="Nino",LastName="Olivetto",IdentificationCard="124",BirthDate=DateTime.Parse("2005-09-01")}
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

            var user = new User[]
            {
            new User{IdentificationCard="117", Password="ka1212"},
            new User{IdentificationCard="118", Password="lslsjk"},
            new User{IdentificationCard="120", Password="aaam12"}
            };
            foreach (User c in user)
            {
                context.User.Add(c);
            }
            context.SaveChanges();
        }
    }
}