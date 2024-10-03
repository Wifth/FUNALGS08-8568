using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funciones {
    internal class Perro {
        public string Nombre { get; set; }

        public static string Ladrar() {
            int a = 5;
            return "Guau";
        }

        public static void Ladrar(string lad) {
            Console.WriteLine(lad);
            
        }
    }
}
