using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstOOPInheritance
{
    public class DramaMovie:Movie
    {
        private string dramaticHeroName;
        private List<string> nameOfDramaticParts;

        public string DramaticHeroName { get => dramaticHeroName; set => dramaticHeroName = value; }
        public List<string> NameOfDramaticParts { get => nameOfDramaticParts; set => nameOfDramaticParts = value; }
    }
}
