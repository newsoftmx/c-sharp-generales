using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//esta libreria se agrega para poder trabajar arraylist
using System.Collections;

namespace estructura_datos_2
{
    public class tda
    {
        //defino tipos de datos abstractos
        private int px, py, pz;
        string tipoArreglo;
        string[] array = new string[5];
        int[] empleados = new int[100];

        //datos dinamicos, no olviden agregar la libreria
        ArrayList lista = new ArrayList();

        /*array[0] = "Socrates";
        array[1] = "Plato";
        // Loop over array by indexes.
        for (int i = 0; i<array.Length; i++)
        {
            string element = array[i];
        Console.WriteLine(element);
        }

    /*************************/
    //defino constructores, se le dice constructor porque 
    //recibe valores*/
    public void crearVector3D(int valor1, int valor2, int valor3)
        {
            this.px = valor1;
            this.py = valor2;
            this.pz = valor3;
        }
        public void crearVector2D(int valor1, int valor2)
        {
            this.px = valor1;
            this.py = valor2;
        }
        public void crearVectorCero()
        {
            this.px = 0;
            this.py = 0;
        }

        /**********defino metodos*/
        public int traerPX()
        {
            return px;
        }
        public int traerPY()
        {
            return py;
        }
        public int traerPZ()
        {
            return pz;
        }
        public string traerTipoArreglo()
        {
            return tipoArreglo;
        }
        //defino metodos que  insertan valores uno por uno
        public int leerPX(int valorX)
        {
            this.px = valorX;
            return px;
        }
        public int leerPY(int valorY)
        {
            this.py = valorY;
            return py;
        }
        public int leerPZ(int valorZ)
        {
            this.pz = valorZ;
            return pz;
        }
        public string leerTipoArreglo(string tipoArregloLeido)
        {
            this.tipoArreglo = tipoArregloLeido;
            return tipoArreglo;
        }

    }
}