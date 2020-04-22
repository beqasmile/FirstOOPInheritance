using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstOOPInheritance
{
    public class MovieDirector
    {

        private string directorName;
        private int yearBorn;
        private int countryBorn;

        public MovieDirector(string directorName)
        {
            this.directorName = directorName;
        }
        public string DirectorName { get => directorName; set => directorName = value; }
        public int CountryBorn { get => countryBorn; set => countryBorn = value; }
        public int YearBorn { get => yearBorn; set => yearBorn = value; }

        public override string ToString()
        {
            return this.directorName + " " + this.CountryBorn + " " + this.YearBorn;
        }
    }
}
