﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCFunLearn.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public byte GenreId { get; set; }

        //Calling the GenreDto to get the name
        public GenreDto Genre { get; set; }

        public DateTime DateAdded { get; set; }

        [Required]
        public DateTime? ReleasedDate { get; set; }

        [Range(1, 20)]
        public byte NumberInStock { get; set; }
    }
}