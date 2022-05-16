using GraphQlDiplom.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQlDiplom.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<ItemStatus> ItemStatuses { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Client>(b =>
            {
                b.HasData(
                             new Client() { ClientId = 1, Email = "da@mail.ru", Deposit = 100, Bonus = 2, FirstName = "Андрей", LastName = "Бобров", IsBlocked = false, PhoneNumber = 89231313 },
                             new Client() { ClientId = 2, Email = "net@mail.ru", Deposit = 200, Bonus = 0, FirstName = "Настя", LastName = "Рябинкина", IsBlocked = false, PhoneNumber = 89238213 },
                             new Client() { ClientId = 3, Email = "navernoe@mail.ru", Deposit = 0, Bonus = 0, FirstName = "Егор", LastName = "Петров", IsBlocked = false, PhoneNumber = 89131313 },
                             new Client() { ClientId = 4, Email = "hz@mail.ru", Deposit = 150, Bonus = 0, FirstName = "Владислав", LastName = "Чулков", IsBlocked = false, PhoneNumber = 89221313 },
                             new Client() { ClientId = 5, Email = "hz@mail.ru", Deposit = 150, Bonus = 0, FirstName = "Анастасия", LastName = "Любимова", IsBlocked = false, PhoneNumber = 89288313 }
                         );
            }

            );
            modelBuilder.Entity<Item>(b =>
            {
                b.HasData(
                             new Item() { ItemId = 1, OwnerId = 1, OrderId = 1, ProductId = 1, Count = 1, EventDate = DateTime.Parse("28.12.2022") },
                             new Item() { ItemId = 2, OwnerId = 2, OrderId = 1, ProductId = 2, Count = 2, EventDate = DateTime.Parse("11.10.2021") },
                             new Item() { ItemId = 3, OwnerId = 2, OrderId = 2, ProductId = 3, Count = 1, EventDate = DateTime.Parse("25.02.2020") },
                             new Item() { ItemId = 4, OwnerId = 3, OrderId = 2, ProductId = 2, Count = 1, EventDate = DateTime.Parse("28.03.2020") },
                             new Item() { ItemId = 5, OwnerId = 2, OrderId = 3, ProductId = 3, Count = 3, EventDate = DateTime.Parse("15.07.2021") },
                             new Item() { ItemId = 6, OwnerId = 4, OrderId = 3, ProductId = 5, Count = 1, EventDate = DateTime.Parse("19.05.2020") },
                             new Item() { ItemId = 7, OwnerId = 5, OrderId = 3, ProductId = 2, Count = 2, EventDate = DateTime.Parse("12.04.2022") },
                             new Item() { ItemId = 8, OwnerId = 1, OrderId = 3, ProductId = 3, Count = 1, EventDate = DateTime.Parse("8.04.2020") },
                             new Item() { ItemId = 9, OwnerId = 3, OrderId = 4, ProductId = 4, Count = 1, EventDate = DateTime.Parse("28.02.2022") }
                         );
            }

            );
            modelBuilder.Entity<ItemStatus>(b =>
            {
                b.HasData(
                             new ItemStatus() { ItemId = 1, IsValid = true, IsActivated = true },
                             new ItemStatus() { ItemId = 2, IsValid = false, IsActivated = true },
                             new ItemStatus() { ItemId = 3, IsValid = true, IsActivated = false },
                             new ItemStatus() { ItemId = 4, IsValid = true, IsActivated = true },
                             new ItemStatus() { ItemId = 5, IsValid = true, IsActivated = false },
                             new ItemStatus() { ItemId = 6, IsValid = true, IsActivated = true },
                             new ItemStatus() { ItemId = 7, IsValid = true, IsActivated = false },
                             new ItemStatus() { ItemId = 8, IsValid = false, IsActivated = true },
                             new ItemStatus() { ItemId = 9, IsValid = false, IsActivated = true }
                         );
            }

            );

            modelBuilder.Entity<Order>(b =>
            {
                b.HasData(
                             new Order() { OrderId = 1, ClientId = 1, StateId = 1, CreationDate = DateTime.Parse("28.12.2022"), PhoneNumber = 89231313 },
                             new Order() { OrderId = 2, ClientId = 2, StateId = 2, CreationDate = DateTime.Parse("11.10.2021"), PhoneNumber = 89238013 },
                             new Order() { OrderId = 3, ClientId = 5, StateId = 2, CreationDate = DateTime.Parse("25.02.2020"), PhoneNumber = 89231313 },
                             new Order() { OrderId = 4, ClientId = 4, StateId = 3, CreationDate = DateTime.Parse("28.03.2020"), PhoneNumber = 89232313 },
                             new Order() { OrderId = 5, ClientId = 1, StateId = 1, CreationDate = DateTime.Parse("15.07.2021"), PhoneNumber = 89231313 },
                             new Order() { OrderId = 6, ClientId = 2, StateId = 1, CreationDate = DateTime.Parse("19.05.2020"), PhoneNumber = 89231313 },
                             new Order() { OrderId = 7, ClientId = 2, StateId = 3, CreationDate = DateTime.Parse("12.04.2022"), PhoneNumber = 89255313 },
                             new Order() { OrderId = 8, ClientId = 3, StateId = 3, CreationDate = DateTime.Parse("8.04.2020"), PhoneNumber = 89277313 },
                             new Order() { OrderId = 9, ClientId = 4, StateId = 2, CreationDate = DateTime.Parse("28.02.2022"), PhoneNumber = 89239313 }
                         );
            }

           );
            modelBuilder.Entity<Product>(b =>
            {
                b.HasData(
                             new Product() { ProductId = 1, Name = "Билет", Price = 1000, From = DateTime.Parse("18.02.2022"), To = DateTime.Parse("18.02.2022") },
                             new Product() { ProductId = 2, Name = "Абонемент", Price = 1000, From = DateTime.Parse("10.01.2022"), To = DateTime.Parse("10.02.2022") },
                             new Product() { ProductId = 3, Name = "Пропуск", Price = 1000, From = DateTime.Parse("18.02.2022"), To = DateTime.Parse("22.06.2022") },
                             new Product() { ProductId = 4, Name = "Сертификат", Price = 1000, From = DateTime.Parse("18.02.2022"), To = DateTime.Parse("22.02.2023") },
                             new Product() { ProductId = 5, Name = "Билет", Price = 1000, From = DateTime.Parse("18.02.2022"), To = DateTime.Parse("22.02.2022") }
                         );
            }

         );
            modelBuilder.Entity<State>(b =>
            {
                b.HasData(
                             new State() { StateId = 1, Name = "Оплачено" },
                             new State() { StateId = 2, Name = "Возврат" },
                             new State() { StateId = 3, Name = "Ожидает оплаты" }
                         );
            }

         );


            base.OnModelCreating(modelBuilder);


        }





    }
}
