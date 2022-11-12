using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp2
{
    internal class Mobile
    {
        public string? Name;
        public string? Model;
        public int Price;
        public string? Company;


        public void Set(string name, string model, int price, string company)
        { 
            Name = name;
            Model = model;
            Price = price; 
            Company = company; 
        }

        public void Set(string name, string model, int price)
        {
            Name = name;
            Model = model;
            Price = price;
            Company = "One Plus";
        }
        public void Get()
        {
            Console.WriteLine($"\nName: {Name}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Company: {Company}");
            Console.WriteLine($"Price: {Price}\n");

        }

    };
}

