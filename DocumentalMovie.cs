using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstOOPInheritance
{
    public class DocumentalMovie : Movie
    {
        private int dateOfFilming;
        private bool basedOnReal;

        public int DateOfFilming { get => dateOfFilming; set => dateOfFilming = value; }
        public bool BasedOnReal { get => basedOnReal; set => basedOnReal = value; }
    }
}
