using funciones;

namespace Program {
    class TestClass {
        static void Main(string[] args) {

            int Azar() {
                Random r = new Random();
                return r.Next(1, 6 + 1);
            }

            int Suma(int d1, int d2) {
                int x = d1 + d2;
                return x;
            }

            void Imprime(int texto) {
                Console.WriteLine(texto);
            }

            int a = 5;
            int b = 6;

            //int c = a + b;
            int c = Suma(a, b);

            Imprime(c);
            //Console.WriteLine(c);

            b = 10;

            int d = a + b;

            Console.WriteLine(d);

            double z = 100.0;
            float y = (float)100.0;

            Console.WriteLine(Azar());


            //Perro p = new Perro();
            //p.Ladrar("Auuuuu");

            Perro.Ladrar("Auuuuu");

        }
    }
}