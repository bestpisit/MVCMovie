using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "When Best Date Bybua",
                    ReleaseDate = DateTime.Parse("2023-3-31"),
                    Genre = "Romantic Comedy",
                    Price = 7.99M
                },
                new Movie
                {
                    Title = "One months With Bybua",
                    ReleaseDate = DateTime.Parse("2023-5-1"),
                    Genre = "Romance",
                    Price = 8.99M
                },
                new Movie
                {
                    Title = "Two months With Bybua",
                    ReleaseDate = DateTime.Parse("2023-6-1"),
                    Genre = "Romance",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "Three months With Bybua",
                    ReleaseDate = DateTime.Parse("2023-7-1"),
                    Genre = "Romance",
                    Price = 10.99M
                },
                new Movie
                {
                    Title = "Four months With Bybua",
                    ReleaseDate = DateTime.Parse("2023-8-1"),
                    Genre = "Romance and Drama",
                    Price = 11.01M
                }
            );
            context.SaveChanges();
        }
    }
}