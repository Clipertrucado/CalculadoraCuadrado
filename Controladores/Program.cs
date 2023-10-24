using CalcularCuadrado.Servicios;
using System.ComponentModel;

namespace CalcularCuadradro;

class Program
{
    static void Main(string[] args) 
    {
        int n1;
        bool cerrar = false;

        while (!cerrar)
        {
            MenuInterfaz mi = new MenuImplementacion();

            int selec = mi.Menu();

            switch (selec)
            {
                case 0:
                    Console.WriteLine("[INFO] - se ejecuta caso uno 0");
                    cerrar = true;
                break;

                case 1:
                    Console.WriteLine("Ingresa un número");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    double raiz = Math.Sqrt(n1);
                    int raizChica = Convert.ToInt32(raiz);
                     Console.WriteLine(raiz);

                    double resul = raiz - raizChica;

                    if (resul == 0)
                    {
                        Console.WriteLine("Tiene raiz entera: "+raiz);
                    }
                    else
                    {
                        Console.WriteLine("No tiene raiz entera, su raiz es: " + raiz);
                    }

                break;

                default:
                    Console.WriteLine("");
                break;

            }

        }
    }
}

