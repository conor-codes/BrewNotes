using BrewNotes.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrewNotes.ViewModels
{
    public partial class AddBeansViewModel : ObservableObject
    {
        [ObservableProperty]
        private string name;

        [ObservableProperty]
        private string from;

        [ObservableProperty]
        private Roast roast;

        public Array BrewMethods => Enum.GetValues(typeof(Roast));

        [ObservableProperty]
        private decimal price;

        public AddBeansViewModel() 
        {
        }

        [RelayCommand]
        public async Task SaveBean()
        {
            var bean = new CoffeeBeans()
            {
                Name = name,
                From = from,
                Roast = roast,
                Price = price,
            };
        }
    }
}
