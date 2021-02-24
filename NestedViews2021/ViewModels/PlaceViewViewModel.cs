using System;
using System.Collections.Generic;
using System.Text;
using NestedViews2021.Models;
using Prism.Mvvm;

namespace NestedViews2021.ViewModels
{
    public class PlaceViewViewModel : BindableBase
    {

        private Place _place;

        public string City
        {
            get => _place.City;
            set
            {
                _place.City = value;
                RaisePropertyChanged("City");
            }
        }

        public string Street
        {
            get => _place.Street;
            set
            {
                _place.Street = value;
                RaisePropertyChanged("Street");
            }
        }

        public PlaceViewViewModel(Place place)
        {
            _place = place;
        }
    }
}
