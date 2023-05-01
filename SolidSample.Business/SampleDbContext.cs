using Microsoft.EntityFrameworkCore;
using SolidSample.Entity;
using System.Globalization;

namespace SolidSample.Business
{
    public class SampleDbContext : DbContext
    {
        public DbSet<Person> People => Set<Person>();
        public DbSet<FoodItem> FoodItems => Set<FoodItem>();
        public DbSet<Meal> Meals => Set<Meal>();
        public DbSet<MealComponent> MealComponents => Set<MealComponent>();
        public DbSet<MealRecord> MealRecords => Set<MealRecord>();
    }
}