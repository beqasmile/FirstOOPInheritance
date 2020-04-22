using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstOOPInheritance
{
    public class ActionMovie : Movie
    {
        private List<String> nameOfStuntmen;

        public List<string> NameOfStuntmen { get => nameOfStuntmen; set => nameOfStuntmen = value; }
    }
}
