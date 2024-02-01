using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using RazorMovieApp.Data;

namespace RazorMovieApp.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorMovieAppContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorMovieAppContext>>()))
            {
                if (context == null || context.Movie == null || context.Student == null)
                {
                    throw new ArgumentException("Null RazorPageMovieContext");
                }

                //Look for any movies.
                if (context.Movie.Any() == false)
                {
                    context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M
                    },

                new Movie
                {
                    Title = "Ghostbusters ",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Price = 8.99M
                },

                new Movie
                {
                    Title = "Ghostbusters 2",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy",
                    Price = 9.99M
                },

                new Movie
                {
                    Title = "Rio Bravo",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "Western",
                    Price = 3.99M
                });
                    context.SaveChanges();
                }

                //Look for any Student.
                if (context.Student.Any() == false)
                {
                    context.Student.AddRange(
                    new Student
                    {
                        StudentId = 1,
                        Name = "hung",
                        DateOfBirth = DateTime.Parse("1998-12-23"),
                        Genre = "Male",
                        Place = "Ha Noi",
                        PhoneNumber = "033720123",
                        Email = "whysoez2312@gmail.com"
                    },
                    new Student
                    {
                        StudentId = 2,
                        Name = "chung",
                        DateOfBirth = DateTime.Parse("1998-12-23"),
                        Genre = "Male",
                        Place = "Ha Noi",
                        PhoneNumber = "0345521111",
                        Email = "chung96@gmail.com"
                    },
                    new Student
                    {
                        StudentId = 3,
                        Name = "thanh",
                        DateOfBirth = DateTime.Parse("1998-12-23"),
                        Genre = "Male",
                        Place = "Ha Noi",
                        PhoneNumber = "033720123",
                        Email = "thanh98@gmail.com"
                    }
                    );
                }
            }
        }
    }
}
