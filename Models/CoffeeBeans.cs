using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrewNotes.Models
{
    public class CoffeeBeans
    {
        public string Name { get; set; } = string.Empty;
        public Roast Roast { get; set; }
        public decimal Price { get; set; } 
        public string? From { get; set; }
    }
}

public enum Roast
{
    Light,
    Medium,
    MediumDark,
    Dark,
}
