using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class Human
    {
        public int Tempature { get; set; }


        public string BodyTempature()
        {


            //Human.BodyTempature();

            if(Tempature <= 36)
            {
                return("you should search for a doctor your body tempature is below standard");
            }
            else if(Tempature == 37)
            {
                return("woohoo your fine!!!");
            }
            else if(Tempature >= 38)
            {
                return("owh crap dude you look abit sweaty friend");
            }
            return "you really screwed up now";
        }
    }
    
}