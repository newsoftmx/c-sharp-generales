using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pila_stack
{
    class Program
    {
        //realice la instancia de la clase Stack indicando el tipo de la instancia
        static Stack<int> Pila = new Stack<int>();
        static void Main(string[] args)
        {
            //aqui va mi codigo principal
            UInt16 opcion = 0;//uint significa que es un entero sin signo
            do
            {
                Console.Clear();
                Console.WriteLine("PILA USANDO COLECCIONES GENÉRICAS\n");
                Console.WriteLine("1.- Insertar dato (Push)");
                Console.WriteLine("2.- Eliminar dato (Pop)");
                Console.WriteLine("3.- Mostrar datos de la pila");
                Console.WriteLine("4.- Eliminar todos los datos de la pila (Vaciar)");
                Console.WriteLine("0.- Salir");
                Console.Write("\nOpción ? ");

                opcion = UInt16.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: InsertarEnPila(); break;
                    case 2: EliminarEnPila(); break;
                    case 3: MostrarDatos(); break;
                    case 4: VaciarPila(); break;
                }

            } while (opcion != 0);
        }
        public static  void InsertarEnPila()
        {
            int dato = 0;
            Console.Clear();
            Console.WriteLine("Insertar dato en la pila generica");
            Console.WriteLine("\n\n Numero entero: ?");
            dato = int.Parse(Console.ReadLine());//leer el numero que desea capturar
            //mandar llamar el metodo push, del objeto Pila de la clase generica Stack
            Pila.Push(dato);//inserta und ato en la pila
        }
        public static void EliminarEnPila()
        {
            Console.Clear();
            Console.WriteLine("Eliminar el último dato que se almaceno en la pila");
            try
            {
                //invocar el metodo pop de la Pila
                int Dato = Pila.Pop();//elimina el dato de la pila y lo recibe en la variable Dato
                Console.WriteLine("\n\n Dato eliminado");
            }
            catch (InvalidOperationException e)//guarda en e una excepción si se present un error
            {
                //desplieque el mesaje de error
                Console.WriteLine("\n\n Sorry, tu proceso de eliminación mando un error"
                    + e.Message);
            }
        }
        public static void MostrarDatos()
        {
            Console.Clear();
            Console.WriteLine("Datos almacenados de la pila generica\n");
            //realizamos el codigo que permite recorrer la pila
            try
            {
                //recorra todo el arreglo de la pila
                foreach(int Dato in Pila)
                {
                    Console.WriteLine(Dato);
                }
                //tengo que mostrar la cantidad de elementos usando el metodo ?
                Console.Write("\n Top = " + Pila.Count);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("\n\n Pila vacia..." + e.Message );
            }
            Console.ReadKey();
        }
        public static void VaciarPila()
        {
            char sn;
            Console.Clear();
            Console.WriteLine("ELIMINAR TODOS LOS ELEMENTOS DE LA PILA (VACIAR)\n");

            // Solicita al usuario que confirme la operación
            do
            {
                Console.Write("¿Está seguro que desea vaciar la pila [S/N] ?");
                sn = char.Parse(Console.ReadLine());
                sn = Char.ToUpper(sn);  // Convierte a mayúsculas el caracter capturado
            } while (sn != 'S' && sn != 'N');

            if (sn == 'S')  // Si se confirma la operación ...
            {
                Pila.Clear();  // Invoca el método para limpiar la pila
                Console.WriteLine("\n\nSe eliminaron todos los elementos de la pila !!!");
                Console.ReadKey();
            }
        }

    }
}
