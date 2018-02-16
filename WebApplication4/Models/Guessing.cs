using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class Guessing
    {
        public int Number { get; private set; }

        public int Correct { get; private set; }

        public List<int> Tries { get; private set; }



        public Guessing()
        {
            //Random nummer
            Correct = new Random().Next(0, 10);
            Tries = new List<int>();
            // skapa en 
        }

        public string GuessResult(int Guess)
        {
            Number = Guess;
            Tries.Add(Guess);
         
            if (Number == Correct)
            {
               
                return "YOU WON!";
                
            }
            else if (Number < Correct)
            {
                return "too low";

            }
            else //(Number > Correct)
            {
                return "too high";
            }
        }



        //     for (int i = 0; i < 10; i++)
        //{

        //}


        //slumpare
        // försök
        //lista

    }
}