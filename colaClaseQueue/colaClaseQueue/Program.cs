using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colaClaseQueue
{
    class Program
    {
        //declaro la instancia hacia la clase Queue para manejar colas
        static Queue<int> colaVirtual = new Queue<int>();
        static void Main(string[] args)
        {
            //este es el cuerpo principal de mi codigo
            UInt16 opcion = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("COLA USANDO COLECCIONES GENÉRICAS\n");
                Console.WriteLine("1.- Agregar dato al final de la cola");
                Console.WriteLine("2.- Eliminar primer dato de la cola");
                Console.WriteLine("3.- Mostrar datos de la cola");
                Console.WriteLine("4.- Eliminar todos los datos de la cola (Vaciar)");
                Console.WriteLine("0.- Salir");
                Console.Write("\nOpción ? ");

                opcion = UInt16.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: InsertarEnCola(); break;
                    case 2: EliminarEnCola(); break;
                    case 3: MostrarDatos(); break;
                    case 4: VaciarCola(); break;
                }

            } while (opcion != 0);
        }
        //fin del cuerpo principal
        public static void  InsertarEnCola()
        {
            int dato = 0;
            Console.Clear();
            Console.WriteLine("Por favor inserta en la cola generica ENQUEUE");
            Console.WriteLine("\n\n Numero entero ? ");
            //permite guardar el dato que se escribe en la consola en la variable dato
            dato = int.Parse(Console.ReadLine());

            //ahora necesito agregar el dato en la COLA
            colaVirtual.Enqueue(dato);
        }
        //creamos el método para eliminar en la cola
        public static void  EliminarEnCola()
        {
            Console.Clear();
            Console.WriteLine("ELIMINATOR EL DATATOR ALMANECATOR EN LA COLATOR");
            //PROBAMOS EJECUTAR LA ELIMINACION DEL PRIMER DATO
            try
            {
                //mandar llamar al metodo DEQUEUE para eliminar el dato
                int datoDevuelto=colaVirtual.Dequeue();
                Console.WriteLine("\n\n Se elimino el dato: " 
                    + datoDevuelto.ToString());
            }
            catch (InvalidOperationException e)
            {
                //aqui va el código para que me mande un mensaje si se presento un problema
                //en elos pasos o codigos dentro del try
                Console.WriteLine("\n\nTu error es: " + e.Message);
            }
            Console.ReadKey();
        }
        //creamos el metodo para mostrarDatos
        public static void MostrarDatos()
        {
            Console.Clear();
            Console.WriteLine("A continuación mostramos los datos almacenados en la cola");
            //recorrer todos los datos almancenados en la cola
            foreach(int dato in colaVirtual)
            {
                Console.WriteLine(dato);
            }
            Console.WriteLine("\n Cantidad de datos almacenados en la cola llamada colaVirtual"
                + colaVirtual.Count());
            Console.ReadKey();
        }
        //metodo para limpiar la cola
        public static void VaciarCola()
        {
            char sn;
            Console.Clear();
            Console.WriteLine("Eliminaremos todos los datos de la cola");
            //pedir al usuario que confirme que desea eliminar o vaciar toda la cola
            do
            {
                Console.WriteLine("Esta seguro que desear vaciar la cola [S/N]");
                sn = char.Parse(Console.ReadLine());//guardo lo que escriba mi cliente
                sn = char.ToUpper(sn);
            } while (sn != 'S' && sn != 'N');
            if (sn=='S')// verifico que lo escrito sea S o s
            {
                colaVirtual.Clear();
                Console.WriteLine("\n\n Se eliminaron todos los datos de la cola");
            }
            Console.ReadKey();
        }




    }
}
