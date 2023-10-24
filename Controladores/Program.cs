using CalcularCuadrado.Servicios;
using System.ComponentModel;
using System.Security.AccessControl;

namespace CalcularCuadradro;


/// <summary>
/// Clase principal del programa
/// 241023 - sav
/// </summary>
class Program 
{
    /// <summary>
    /// Metodo de entrada a la aplicación
    /// 241023 - sav
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args) 
    {   
        //creamos el objeto mi que es tipo interfaz y contienen una copia de MenuImplementacion
        MenuInterfaz mi = new MenuImplementacion();
        //creamos la variable a la que le asignaremos el numero con el que se va a operar
        int n1;
        //variable con la que cerraremos el while
        bool cerrar = false;

        //controla que la aplicacion no se cierre hasta que nosotros lo digamos 
        while (!cerrar)
        {
            
            //creamos un numero entero "selec" y le asignamos el int de vuelve el metodo
            int selec = mi.Menu();

            //dependiendo de la opcion seleccinada entra en un caso u otro
            switch (selec)
            {
                //cierra la aplicacion
                case 0:
                    Console.WriteLine("[INFO] - se ejecuta caso uno 0");
                    cerrar = true;
                break;

                //aqui se ejecuta la logina 
                case 1:
                    //muesetra por conlola "Ingresa un número"
                    Console.WriteLine("Ingresa un número");
                    //asigna a n1 el valor que el usuario ingrese mediante consola
                    n1 = Convert.ToInt32(Console.ReadLine());
                    //creamo raiz que es tipo double y le adignamos el valor de hacerle la raiz cuadrada a n1
                    double raiz = Math.Sqrt(n1);
                    //creamos raizchica que es la parte entera de el resultado de hacer la raiz cuadrada
                    int raizChica = Convert.ToInt32(raiz);

                     Console.WriteLine(raiz);

                    //creamos resul que es tipo double y le asignamos el resultado de restar el resultado de la raiz compleco menos su parte entera 
                    double resul = raiz - raizChica;

                    //aqui compraramos resul ya que si la resta de la raiz completa menos la parte entera es == a 0 esto significara que
                    //las dos partes eran iguales al tipo mas chico(int) es decir es un entero entero
                    //ejemplo 1: resul = 3.00 - 3 | resul = 0 la raiz es un numero entero
                    //ejemplo 2: resul = 3.10 - 3 | resul = 0.1 la raiz no es un numero entero

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

