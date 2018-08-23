﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRentals.Model
{
    public class MovieTraceDto : ResourceBaseDto
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Genre { get; set; }
    }
}
