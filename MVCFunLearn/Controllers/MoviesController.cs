using MVCFunLearn.Models;
using MVCFunLearn.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFunLearn.Controllers
{
    public class MoviesController : Controller
    {
        public ViewResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movie = GetMovies().SingleOrDefault(c => c.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Ramayan"},
                new Movie { Id = 2, Name = "Mahabaharat"}
            };
        }

        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Ramayan" };

            var customers = new List<Customer>
            {
                new Customer{ Name = "Arun" },
                new Customer{ Name = "Nupur" }
            };


            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
        }

        #region Dummy Methods for learning
        public ActionResult Edit(int Id)
        {
            return Content("Id = " + Id);
        }

        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);

        }
        #endregion

    }
}