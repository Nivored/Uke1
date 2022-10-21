using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BackAgain
{
    public class Movies
    {
        public string Name { get; set; }
        public string Description { get; set; }
        
        public Categorys Category;


        public Movies(string name, string description, Categorys category)
        {
            Name = name;
            Description = description;
            Category = category;
        }

        public void PrintMovie()
        {
            Console.WriteLine($"Name: {Name}! Description: {Description}! Category: {Category}!\n");
        }

        public enum Categorys
        {
            Action,
            Adventure,
            Comedy,
            Drama,
            Fantasy,
            Horror,
            Romance,
            SiFi,
            Thriller,
        }
    }
}
