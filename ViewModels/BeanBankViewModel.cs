using BrewNotes.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BrewNotes.ViewModels
{
    public partial class BeanBankViewModel : ObservableObject
    {
        public ObservableCollection<CoffeeBeans> CoffeeBeans { get; set; }
            
        public BeanBankViewModel() 
        {
            CoffeeBeans = new ObservableCollection<CoffeeBeans>()
            {
                new CoffeeBeans() {Name = "Test 1" , From = "Test" , Price = 2, Roast = Roast.Light},
                new CoffeeBeans() {Name = "Test 2" , From = "Test" , Price = 2, Roast = Roast.Light}
            };
        }  
    }
}
