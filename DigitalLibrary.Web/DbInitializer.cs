using DigitalLibrary.Web.Models;
using System;
using System.Linq;

namespace DigitalLibrary.Web
{
    public class DbInitializer
    {
        public static void Initialize(DigitalLibraryContext context)
        {
            context.Database.EnsureCreated();

            if (context.Authors.Any())
                return;

            var author = new Author
            {
                FirstName = "Nathan",
                LastName = "Alard",
                Age = 29,
                Id = Guid.NewGuid(),
                IsNarator = true
            };
            context.Authors.Add(author);
            context.SaveChanges();

            var publisher = new Publisher { Id = Guid.NewGuid(), Name = "Orielly"};
            context.Publishers.Add(publisher);
            context.SaveChanges();

            var audioBook = new AudioBook {
                Id = Guid.NewGuid(),
                Author = author,
                Publisher = publisher,
                Narator = author,
                Title = "Machine Learning in C#",
                Subtitle = "Dot Net Core",
                Summary = ""
            };

        }
    }
}
