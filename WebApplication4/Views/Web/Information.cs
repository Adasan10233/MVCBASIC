using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4.Views.Web
{
    public class Weather
    {
        public static List<Weather> Value { get; set; }
        public int Counts { get; set; }

        public string Name { get; set; }


        public Weather(int counts, string name)
        {
            Counts = counts;
            Name = name;
        }
    }
}