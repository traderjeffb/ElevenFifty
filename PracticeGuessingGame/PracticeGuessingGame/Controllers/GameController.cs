using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticeGuessingGame.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        public ActionResult Index()
        {
           Session["answer"] = new Random().Next(1, 11);
            return View();
        }

        private bool GuessIsCorrect(int guess) => guess == (int)Session["answer"];

        [HttpPost]

        public ActionResult index 

    }
}