using System;

namespace contador
{
    class Program
    {
        static void Main(string[] args)
        {
            int positivos = 0; int conta = 0; int numero;
            Console.WriteLine("Introduce número ");
            numero = Int32.Parse(Console.ReadLine());
            while (numero != 999)
            {
                conta = conta + 1;
                if (numero > 0) positivos = positivos + 1;
                Console.WriteLine("Introduce número ");
                numero = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("Has introducido un total de {0}", conta);
            Console.WriteLine("y son positivos {0}", positivos);

        } //fin Main
    }
}

/* programa para sumar 
using System;

namespace contador
{ 
  public class Program
  {
    static void Main(string[] args)
    {
      int contador = 0, suma = 0;
      while(contador < 10)
      {
        suma += contador;   //igual a suma = suma + contador
        contador++;   //igual a contador + 1
        Console.WriteLine(suma);
      }

      Console.WriteLine("La suma final es: " + suma);
    }
  }
}
*/

