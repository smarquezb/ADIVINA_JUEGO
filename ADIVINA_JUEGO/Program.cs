

namespace juegodeadivinar
{
   public class juego
    {
        public static void Main(string[] args)
        {
            // Título 
            Console.WriteLine("¡ingresaste al juego Adivina el número!");

            
            Console.Write("Ingrese el número de jugadores (2-4): ");
            int numJugadores = Convert.ToInt32(Console.ReadLine());

            // Validar número de jugadores
            while (numJugadores < 2 || numJugadores > 4)
            {
                Console.Write("Número de jugadores inválido. Ingrese un valor entre 2 y 4: ");
                numJugadores = Convert.ToInt32(Console.ReadLine());
            }

            // Generar número aleatorio según número de jugadores
            int maxNumero;
            switch (numJugadores)
            {
                case 2:
                    maxNumero = 50;
                    break;
                case 3:
                    maxNumero = 100;
                    break;
                default:
                    maxNumero = 200;
                    break;
            }

            Random random = new Random();
            int numeroAleatorio = random.Next(0, maxNumero + 1);

            // Juego
            bool juegoActivo = true;
            int turno = 1;
            while (juegoActivo)
            {
                Console.Clear();
                Console.WriteLine($"Turno {turno} de {numJugadores}");
                Console.Write($"Ingrese un número entre 0 y {maxNumero}: ");
                int numeroIngresado = Convert.ToInt32(Console.ReadLine());

                if (numeroIngresado < numeroAleatorio)
                {
                    Console.WriteLine("MAYOR");
                }
                else if (numeroIngresado > numeroAleatorio)
                {
                    Console.WriteLine("MENOR");
                }
                else
                {
                    Console.WriteLine("¡HAS GANADO!");
                    juegoActivo = false;
                }

                turno++;
                if (turno > numJugadores)
                {
                    turno = 1;
                }
            }

            
            Console.Write("¿Desea jugar de nuevo? (s/n): ");
            string respuesta = Console.ReadLine();
            if (respuesta.ToLower() == "s")
            {
                Main(args);
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
