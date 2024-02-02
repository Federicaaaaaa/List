using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Persona> Persone = new List<Persona>();
            for (int i = 0; i < 4; i++)
            {
                Persone.Add(Persona.Parse(Console.ReadLine()));
            }
            //Utilizzare il foreach e  non il for
            foreach(Persona p in Persone)
            {
                if (p.Eta > 17)
                    Console.WriteLine(p);
            }
            Console.ReadLine();
        }
    }
}
