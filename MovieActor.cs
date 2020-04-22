using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstOOPInheritance
{
    public class MovieActor
    {
        private int id;
        private string actorName;
        private string actorSurname;
        private int birthDay;
        private string actorType;

        public MovieActor(int id, string actorName, string actorSurname, int birthDay, string actorType)
        {
            this.id = id;
            this.actorName = actorName;
            this.actorSurname = actorSurname;
            this.birthDay = birthDay;
            this.actorType = actorType;
        }

        public int Id { get => id;}
        public string ActorName { get => actorName; set => actorName = value; }
        public string ActorSurname { get => actorSurname; set => actorSurname = value; }
        public int BirthDay { get => birthDay; set => birthDay = value; }
        public string ActorType { get => actorType; set => actorType = value; }


        public override string ToString()
        {
            return "Name = " + this.ActorName + " Surname " + this.actorSurname + " Birthday " + this.birthDay + " Actor type " + this.actorType;
        }
    }
}
