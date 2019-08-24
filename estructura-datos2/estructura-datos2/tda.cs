using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace estructura_datos2
{
    public class tda
    {
        private int px, py, pz;
        string tipoArreglo;
        
        /*****************/
        //creamos el constructor de vector de 3 puntos
        public void crearVector3D(int valor1, int valor2, int valor3)
        {
            this.px = valor1;
            this.py = valor2;
            this.pz = valor3;
        }
        public void crearVector2D(int v1, int v2)
        {
            this.px = v1;
            this.py = v2;
        }
        /**********************/
        //defino metodos
        public int traerPX()
        {
            return px;
        }
        public int traerPY()
        {
            return py;
        }
        public int traerPz()
        {
            return pz;
        }
        public void leerPX(int valorX)
        {
            this.px = valorX;
        }
        public void leerPY(int valorY)
        {
            this.py = valorY;
        }
        public void leerPZ(int valorZ)
        {
            this.pz = valorZ;
        }
    }
}