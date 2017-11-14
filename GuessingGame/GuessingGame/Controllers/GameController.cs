using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GuessingGame.Models;

namespace GuessingGame.Controllers
{
    public class GameController : Controller
    {

        // GET: Game
        public ActionResult Index()
        {
          Session["answer"]=  new Random().Next(1, 10);

            return View();
        }
        private bool GuessWasCorrect(int guess) =>
            guess == (int)Session["answer"];


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(GameModel model)
        {

            if (ModelState.IsValid)
            {
                ViewBag.Win = GuessWasCorrect(model.Guess);
            }

            return View(model);
        }

    }
}