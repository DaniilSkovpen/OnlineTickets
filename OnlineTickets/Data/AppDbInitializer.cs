using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using OnlineTickets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDBContext>();

                context.Database.EnsureCreated();

                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Cinema 1",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Description = "This is description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 2",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Description = "This is description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 3",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Description = "This is description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 4",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            Description = "This is description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 5",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            Description = "This is description of the first cinema"
                        },
                    });
                    context.SaveChanges();
                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Actor 1",
                            ProfilePicturesURL = "http://dotnethow.net/images/actors/actor-1.jpeg",
                            Bios = "This is description of the first cinema"
                        },
                        new Actor()
                        {
                            FullName = "Actor 2",
                            ProfilePicturesURL = "http://dotnethow.net/images/actors/actor-2.jpeg",
                            Bios = "This is description of the first cinema"
                        },
                        new Actor()
                        {
                            FullName = "Actor 3",
                            ProfilePicturesURL = "http://dotnethow.net/images/actors/actor-3.jpeg",
                            Bios = "This is description of the first cinema"
                        },
                        new Actor()
                        {
                            FullName = "Actor 4",
                            ProfilePicturesURL = "http://dotnethow.net/images/actors/actor-4.jpeg",
                            Bios = "This is description of the first cinema"
                        },
                        new Actor()
                        {
                            FullName = "Actor 5",
                            ProfilePicturesURL = "http://dotnethow.net/images/actors/actor-5.jpeg",
                            Bios = "This is description of the first cinema"
                        },
                    });
                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                        FullName = "Producer 1",
                        ProfilePicturesURL = "http://dotnethow.net/images/producers/producer-1.jpeg",
                        Bios = "This is description of the first cinema"
                        },
                        new Producer()
                            {
                            FullName = "Producer 2",
                            ProfilePicturesURL = "http://dotnethow.net/images/producers/producer-2.jpeg",
                            Bios = "This is description of the first cinema"
                        },
                          new Producer()
                        {
                            FullName = "Producer 3",
                            ProfilePicturesURL = "http://dotnethow.net/images/producers/producer-3.jpeg",
                            Bios = "This is description of the first cinema"
                        },
                        new Producer()
                        {
                            FullName = "Producer 4",
                            ProfilePicturesURL = "http://dotnethow.net/images/producers/producer-4.jpeg",
                            Bios = "This is description of the first cinema"
                        },
                        new Producer()
                        {
                            FullName = "Producer 5",
                            ProfilePicturesURL = "http://dotnethow.net/images/producers/producer-5.jpeg",
                            Bios = "This is description of the first cinema"
                        },
                });
                    context.SaveChanges();
                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Movie 1",
                            ImgURL = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            Description = "This is description of the first cinema",
                            Price = 34,
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate= DateTime.Now.AddDays(-2),
                            MovieCategory = MovieCategory.Cartoon,
                            CinemaId = 1,
                            ProducerId = 3,
                        },
                        new Movie()
                            {
                            Name = "Movie 2",
                            ImgURL = "http://dotnethow.net/images/movies/movie-2.jpeg",
                            Description = "This is description of the first cinema",
                            Price = 38.40,
                            StartDate = DateTime.Now.AddDays(-5),
                            EndDate = DateTime.Now.AddDays(+3),
                            MovieCategory = MovieCategory.Drama,
                            CinemaId = 1,
                            ProducerId = 1
                        },
                          new Movie()
                        {
                            Name = "Movie 3",
                            ImgURL = "http://dotnethow.net/images/movies/movie-3.jpeg",
                            Description = "This is description of the first cinema",
                            Price = 15.70,
                            StartDate = DateTime.Now.AddDays(-6),
                            EndDate = DateTime.Now.AddDays(+1),
                            MovieCategory = MovieCategory.Horror,
                            CinemaId = 4,
                            ProducerId = 4
                        },
                        new Movie()
                        {
                            Name = "Movie 4",
                            ImgURL = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            Description = "This is description of the first cinema",
                            Price = 43.20,
                            StartDate = DateTime.Now.AddDays(+4),
                            EndDate = DateTime.Now.AddDays(+11),
                            MovieCategory = MovieCategory.Comedy,
                            CinemaId = 5,
                            ProducerId = 5
                        },
                        new Movie()
                        {
                            Name = "Movie 5",
                            ImgURL = "http://dotnethow.net/images/movies/movie-5.jpeg",
                            Description = "This is description of the first cinema",
                            Price = 32.50,
                            StartDate = DateTime.Now.AddDays(-8),
                            EndDate = DateTime.Now.AddDays(-15),
                            MovieCategory = MovieCategory.Documentary,
                            CinemaId = 3,
                            ProducerId = 2
                        },
                });
                    context.SaveChanges();
                }
                //Actors & Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new Actor_Movie
                        {
                            ActorId = 3,
                            MovieId = 1
                        },
                        new Actor_Movie
                        {
                            ActorId = 4,
                            MovieId = 5
                        },
                        new Actor_Movie
                        {
                            ActorId = 5,
                            MovieId = 5
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
