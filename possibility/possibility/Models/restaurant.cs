using System;
using System.Collections.Generic;
using System.Text;

namespace possibility.Models
{
    public class restaurant
    {
        public string restaurantName { get; set; }
        public string Location { get; set; }
        public string ImageUrl { get; set; }
        public override string ToString()
        {
            return restaurantName;
        }
 
    }
}
