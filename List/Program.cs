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
                Persona p = new Persona();
                p.Nome = Console.ReadLine();
                p.Eta = int.Parse(Console.ReadLine());
                Persone.Add(p);
            }
            for (int i = 0; i < Persone.Count; i++)
            {
                if (Persone[i].Eta > 17)
                    Console.WriteLine(Persone[i]);
            }
            Console.ReadLine();
        }
    }
}
