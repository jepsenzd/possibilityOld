using System;
using System.Collections.Generic;
using System.Text;

namespace possibility.Models
{
        public readonly struct Restaurant
        {
            public string Name { get; }

            public string City { get; }

            public double Latitude { get; }

            public double Longitude { get; }

            public Restaurant(string name, string city, double latitude, double longitude)
            {
                Name = name;
                City = city;
                Latitude = latitude;
                Longitude = longitude;
            }
        }
}
