using MVCFunLearn.Models;
using MVCFunLearn.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace MVCFunLearn.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            // var movies = GetMovies();
            var movies = _context.Movies.Include(m => m.Genre).ToList();
            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }

        //Display the New customer page
        public ActionResult New()
        {
            var geners = _context.Genres.ToList();
            var viewModel = new MovieFormViewModel
            {
                Geners = geners
            };
            return View("MovieForm", viewModel);
        }

        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.Single(m => m.Id == id);
            if (movie == null)
                return HttpNotFound();
            var viewModel = new MovieFormViewModel
            {
                Movie = movie,
                Geners = _context.Genres.ToList()
            };

            return View("MovieForm", viewModel);
        }

        public ActionResult Save(Movie movie)
        {
            if (movie.Id == 0)
                _context.Movies.Add(movie);
            else
            {
                var movieInDb = _context.Movies.Single(m => m.Id == movie.Id);

                movieInDb.Name = movie.Name;
                movieInDb.ReleasedDate = movie.ReleasedDate;
                movieInDb.GenreId = movie.GenreId;
                movieInDb.NumberInStock = movie.NumberInStock;
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Movies");
        }

        #region Dummy Methods for learning
        public ActionResult Edit1(int Id)
        {
            return Content("Id = " + Id);
        }

        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);

        }

        //Hard coded data
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
        #endregion

    }
}