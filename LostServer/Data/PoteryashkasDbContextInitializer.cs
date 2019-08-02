using LostServer.Models;
using System;
using System.Data.Entity;
using System.Linq;

namespace LostServer.Data
{
    public class PoteryashkasDbContextInitializer : CreateDatabaseIfNotExists<ApplicationContext>
    {
        protected override void Seed(ApplicationContext context)
        {
            var props = new[] { "Hair", "Nose", "Eyes" };
            for (int i = 0; i < 10; i++)
            {
                context.Poteryashkas.Add(new Poteryashka()
                {
                    Name = Faker.NameFaker.FirstName(),
                    Surname = Faker.NameFaker.LastName(),
                    AdditionalInfo = $"{Faker.ArrayFaker.SelectFrom(props)} {Faker.EnumFaker.SelectFrom<ConsoleColor>()}",
                    Lost = Faker.DateTimeFaker.DateTime().Date,
                    Found = null,
                    Phone = Faker.PhoneFaker.Phone(),
                    Age = Faker.NumberFaker.Number(1, 100),
                    IsFound = false
                });

            }
            context.SaveChanges();
        }
    }
}
