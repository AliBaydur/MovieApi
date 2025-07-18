﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSdesingPattern.Commands.MovieCommands
{
    public class UpdateMovieCommand
    {
        public int MovieId { get; set; }
        public string MovieTitle { get; set; }
        public string CoverImageUrl { get; set; }
        public decimal Rating { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string CreatedYear { get; set; }
        public bool Status { get; set; }
    }
}
