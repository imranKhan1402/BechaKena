using BK.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BK.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                if(!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Cinema1",
                            Logo = "http://dotnetow.net/images/cinemas/cinema-1.jpeg",
                            Description = "Cinema 1"
                        }
                    });
                    context.SaveChanges();
                }
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Actor1",
                            ProfilePictureURL = "http://dotnetow.net/images/actors/actor-1.jpeg",
                            Bio = "Actor 1"
                        }
                    });
                    context.SaveChanges();

                }
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Producer1",
                            ProfilePictureURL = "http://dotnetow.net/images/producers/producer-1.jpeg",
                            Bio = "Producer 1"
                        }
                    });
                    context.SaveChanges();
                }
                if (!context.movies.Any())
                {
                    context.movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Movie 1",
                            ImageURL = "http://dotnetow.net/images/producers/producer-1.jpeg",
                            Description = "Movie 1",
                            Price = 40.3,
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaID = 1,
                            ProducerID =1,
                            MovieCategory = MovieCategory.Action

                        }
                    });
                    context.SaveChanges();

                }
                if (!context.Actor_Movies.Any())
                {
                    context.Actor_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 1
                        }
                    });
                    context.SaveChanges();
                }

            }
        }
    }
}
