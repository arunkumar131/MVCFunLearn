using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCFunLearn.Models
{
    public class MovieStockRange : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var movies = (Movie)validationContext.ObjectInstance;

            if (movies.NumberInStock > Movie.MinStock || movies.NumberInStock < Movie.MaxStock)
                return ValidationResult.Success;
            else
            return new ValidationResult("The movie stock must be in between 1 to 20");  
        }
    }
}