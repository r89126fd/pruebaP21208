using System;

namespace EjercicioPolimorfismo
{
    // Clase base
    class Animal
    {
        public virtual void HacerSonido()
        {
            Console.WriteLine("El animal hace un sonido.");
        }

        public virtual void Moverse()
        {
            Console.WriteLine("El animal se mueve.");
        }
    }

    // Clase derivada 1
    class Perro : Animal
    {
        public override void HacerSonido()
        {
            Console.WriteLine("El perro ladra: ¡Guau guau!");
        }

        public override void Moverse()
        {
            Console.WriteLine("El perro corre rápidamente.");
        }
    }
}

