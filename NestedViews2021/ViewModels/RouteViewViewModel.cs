using System;
using System.Collections.Generic;
using System.Text;
using Prism.Mvvm;
using NestedViews2021.Models;

namespace NestedViews2021.ViewModels
{
    public class RouteViewViewModel : BindableBase
    {
        private PlaceViewViewModel _startingPlace;
        public PlaceViewViewModel StartingPlace
        {
            get => _startingPlace;
            set => SetProperty(ref _startingPlace, value);
        }
        private PlaceViewViewModel _targetPlace;
        public PlaceViewViewModel TargetPlace
        {
            get => _targetPlace;
            set => SetProperty(ref _targetPlace, value);
        }      

        public string Message
        {
            get {
                if (!(string.IsNullOrEmpty(_startingPlace.Street)
                    || string.IsNullOrEmpty(_startingPlace.City)
                    || string.IsNullOrEmpty(_targetPlace.Street)
                    || string.IsNullOrEmpty(_targetPlace.City)
                    ))
                    return $"You selected to fly from {_startingPlace.Street} in {_startingPlace.City} to {_targetPlace.Street} in {_targetPlace.City}";
                else
                    return "";
            }
        }

        public RouteViewViewModel()
        {
            _startingPlace = new PlaceViewViewModel(new Place());
            _targetPlace = new PlaceViewViewModel(new Place());
            _startingPlace.PropertyChanged += _place_PropertyChanged;
            _targetPlace.PropertyChanged += _place_PropertyChanged;
        }

        private void _place_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            RaisePropertyChanged("Message");
        }   
    }
}
