using GreenGuys.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;

namespace GreenGuys.Data
{
    public class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            AppDbContext context =
                applicationBuilder.ApplicationServices.GetRequiredService<AppDbContext>();

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if (!context.Plants.Any())
            {
                context.AddRange
                (
                    new Plant
                    {
                        Name = "Yukka",
                        Price = 32M,
                        ShortDescription = "The recipe for a happy yucca is easy: sun, sun, and more sun.",
                        LongDescription = "The recipe for a happy yucca is easy: sun, sun, and more sun.Plant in a container deep enough to balance the top-heavy woody stems and water sparingly. ",
                        Category = categories["Common House Plants"],
                        ImageURL = "https://www.houseplantsexpert.com/image-files/rose-of-china-flower.jpg",
                        ImageThumbnailURL = "https://www.houseplantsexpert.com/image-files/rose-of-china-flower.jpg",
                        InStock = true,
                        IsMostPopular = true,
                    },
                    new Plant
                    {
                        Name = "Rose",
                        Price = 5.5M,
                        ShortDescription = "The Hibiscus rosa-sinensis has the common name of Rose of China, and originated in China.",
                        LongDescription = "The flowers are a kind of trumpet shape and bright in color. These are fairly easy-to-care for, but need plenty of light.",
                        Category = categories["Flowering Plants"],
                        ImageURL = "https://www.houseplantsexpert.com/image-files/rose-of-china-flower.jpg",
                        ImageThumbnailURL = "https://www.houseplantsexpert.com/image-files/rose-of-china-flower.jpg",
                        InStock = true,
                        IsMostPopular = true,
                    },
                    new Plant
                    {
                        Name = "Cactus",
                        Price = 10M,
                        ShortDescription = "This cactus is more suitable for growing in rockery settings within a garden.",
                        LongDescription = "They do flower, although it seems to be quite hard to get them to bloom. This globular shaped cacti is available with spines and spineless.",
                        Category = categories["Cactus Plants"],
                        ImageURL = "https://www.houseplantsexpert.com/image-files/rose-of-china-flower.jpg",
                        ImageThumbnailURL = "https://www.houseplantsexpert.com/image-files/rose-of-china-flower.jpg",
                        IsMostPopular = true,
                    },
                    new Plant
                    {
                        Name = "Aloe",
                        Price = 15.5M,
                        ShortDescription = "Aloe Vera is a succulent leaf plant ",
                        LongDescription = "These are said to originate from Africa and they are grown/cultivated in various countries and homes, because they tolerate various conditions very well.",
                        Category = categories["Easy & Low Light"],
                        ImageURL = "https://www.houseplantsexpert.com/image-files/rose-of-china-flower.jpg",
                        ImageThumbnailURL = "https://www.houseplantsexpert.com/image-files/rose-of-china-flower.jpg",
                        InStock = true,
                        IsMostPopular = true,
                    },
                    new Plant
                    {
                        Name = "Venus Fly Trap",
                        Price = 37.5M,
                        ShortDescription = "The dionaea muscipula is unusual in the way that it traps insects and ingests them",
                        LongDescription = "It's the most commonly kept insectivore indoors, although it's quite hard to extend their life span to the level they live up to outdoors.",
                        Category = categories["Unusual Plants"],
                        ImageURL = "https://www.houseplantsexpert.com/image-files/rose-of-china-flower.jpg",
                        ImageThumbnailURL = "https://www.houseplantsexpert.com/image-files/rose-of-china-flower.jpg",
                        InStock = true,
                        IsMostPopular = false,
                    }

                );
            }

            context.SaveChanges();
        }

        private static Dictionary<string, Category> categories;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var genresList = new Category[]
                    {
                    new Category{ CategoryName = "Common House Plants", Description = "Common and popular plants found inside many homes"},
                        new Category{ CategoryName = "Flowering Plants", Description = "It's impossible to resist growing flowering plant types indoors."},
                        new Category{ CategoryName = "Cactus Plants", Description = "If you have enough light and warmth you can grow cacti."},
                        new Category{ CategoryName = "Easy & Low Light", Description = "Plants best for the begginers"},
                        new Category{ CategoryName = "Unusual Plants", Description = "A collection of plants grown indoors that have an unusual appearance"}
                    };

                    categories = new Dictionary<string, Category>();

                    foreach (Category genre in genresList)
                    {
                        categories.Add(genre.CategoryName, genre);
                    }
                }

                return categories;
            }
        }
    }
}