using System;
using System.Collections.Generic;
using System.Text;

namespace MovieTheater.Core.Models
{
    public class Movie
    {
            public string MovieName { get; set; }
            public int RunTime { get; set; }
            public string DirectorName { get; set; }
            public int Id { get; set; }
            public int MovieId { get; set; }
            public int AuditoriumId { get; set; }
    }

}
