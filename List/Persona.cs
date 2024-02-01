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
            return $"Persona di nome {Nome} che ha {Eta}";
        }
    }
}
