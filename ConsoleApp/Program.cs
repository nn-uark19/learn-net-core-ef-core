﻿using SamuraiApp.Data;
using SamuraiApp.Domain;
using System;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        private static SamuraiContext context = new SamuraiContext();
        private static void Main(string[] args)
        {
            context.Database.EnsureCreated();
            GetSamurais("Before Add:");
            AddSamurai();
            GetSamurais("After Add:");
        }

        private static void AddSamurai()
        {
            var samurai = new Samurai { Name = "Mena" };
            context.Samurais.Add(samurai);
            context.SaveChanges();
        }

        private static void GetSamurais(string text)
        {
            var samurais = context.Samurais.ToList();

            Console.WriteLine($"{text} Samurai count is {samurais.Count}");

            foreach (var samurai in samurais)
                Console.WriteLine(samurai.Name);

        }
    }
}
