﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeDisney.Models
{
    public class Character
    {
        public int CharacterId { get; set; }
        public byte Image { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float Weight { get; set; }
        public string History { get; set; }
        public ICollection<Movie> Movies { get; set; }

    }
}
