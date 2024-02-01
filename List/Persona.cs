using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Persona
    {
        public string Nome { get; set; }
        public int Eta { get; set; }

        public override string ToString()
        {
            return $"{Nome} che ha {Eta} anni";
        }

        public static Persona Parse(string person)
        {
            string[] subs = person.Split(' ');
            Persona p = new Persona();
            p.Nome = subs[0];
            p.Eta = int.Parse(subs[3]);
            return p;
        }

    }
}
