using System;
using System.Collections.Generic;
using System.Text;

namespace NestedViews2021.Models
{
    public class Place
    {
        private String _city;
        public String City
        {
            get => _city;
            set => _city = value;
        }

        private String _street;
        public String Street
        {
            get => _street;
            set => _street = value;
        }
    }
}
