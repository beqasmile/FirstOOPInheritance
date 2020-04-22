using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstOOPInheritance
{
    public class ComedyMovie: Movie
    {
        private int numberOfComicHeroes;

        public int NumberOfComicHeroes { get => numberOfComicHeroes; set => numberOfComicHeroes = value; }
    }
}
