using SamuraiApp.Data;
using SamuraiApp.Domain;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp
{
    class Program
    {

        private static SamuraiContext _context = new SamuraiContext();
        static void Main(string[] args)
        {
            //_context.Database.EnsureCreated();
            GetSamurais("Before Add:");
            AddSamurai("Sampson");
            AddSamurai("Gambino");
            AddSamurai("Roberto");
            GetSamurais("After Add:");
            //QueryFilters();
            Console.WriteLine("Press any key...");
            Console.ReadLine();
        }

        private static void AddSamurai(string samuraiName)
        {
            var samurai = new Samurai { Name = samuraiName };
            _context.Samurais.Add(samurai);
            _context.SaveChanges();
        }

        private static void GetSamurais(string text)
        {
            var samurais = _context.Samurais.ToList();
            Console.WriteLine($"{text}: Samurai count is {samurais.Count}");
            foreach(var samurai in samurais)
            {
                Console.WriteLine(samurai.Name);
            }
        }

        private static void QueryFilters()
        {
            var name = "Sampson";
            var samurais = _context.Samurais.Where(s => EF.Functions.Like(s.Name, "J%")).ToList();
        }
    }
}
