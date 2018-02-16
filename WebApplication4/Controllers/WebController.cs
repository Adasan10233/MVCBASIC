using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class WebController : Controller
    {
        // mainpage
        [HttpGet]
        public ActionResult Home()
        {

            return View();
        }
        // about me
        [HttpGet]
        public ActionResult About()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Contact()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Project()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Tempature()//hmm
        {
            return View();
        }
        [HttpPost]
        public ActionResult Tempature(int msg)
        {
            Human someone = new Human();
            someone.Tempature = msg;
            ViewBag.somebody = someone.BodyTempature();
            return View();
        }
        [HttpGet]
        public ActionResult GuessingGame()
        {
            Guessing game = new Guessing();
            Session["game"] = game;

            HttpCookie myCookie = Request.Cookies.Get("Highscore");
            if (myCookie != null)
            {
                List<int> nummerna = new List<int>();
                string[] stringNumbers = myCookie.Value.Split('C');
                foreach (string item in stringNumbers)
                {
                    nummerna.Add(int.Parse(item));
                }
                Session["numabares"] = nummerna;
            }
            return View();
        }
        [HttpPost]
        public ActionResult GuessingGame(int Number)
        {
            Guessing game = (Guessing)Session["game"];
            ViewBag.Spel = game.GuessResult(Number);
            ViewBag.Fries = game.Tries.Count;

            Session["game"] = game;
            //KAKA
            HttpCookie myCookie;

            List<int> numbers = new List<int>();

            myCookie = Request.Cookies.Get("Highscore");

            if (myCookie == null)
            {
                // skapa cookie
                myCookie = new HttpCookie("Highscore");
                myCookie.Expires = DateTime.Now.AddHours(1);
            }
            else
            {
                string[] stringTries = myCookie.Value.Split('C');
                foreach (string item in stringTries)
                {
                    numbers.Add(int.Parse(item));
                }
            }
            numbers.Add(Number);
            numbers.Sort();
            myCookie.Value = "";

            foreach (int item in numbers)
            {
                myCookie.Value += item.ToString() + 'C';
            }

            myCookie.Value = myCookie.Value.Remove(myCookie.Value.Length - 1, 1);


            Response.Cookies.Add(myCookie);
            ViewBag.numbers = numbers;

            return View();
        }


    }


}