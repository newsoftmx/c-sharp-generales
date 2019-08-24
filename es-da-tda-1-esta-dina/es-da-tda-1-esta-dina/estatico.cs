using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace es_da_tda_1_esta_dina
{
    public class estatico
    {
        tda_estatico td1 = new tda_estatico();
        #region "variables"
        //declaracion de arreglo unidimensional
        int[] valores = new int[5];
        //la sig. forma solo se permite en los metodos
        //valores = new int[5];
        int[] valores2 = new int[5];
        //tambien puede ser así
        int[] numeros = new int[5];

        int[] valor= new int[5];
        int aa;
        
        //declarar arreglo multidimensional
        string[,] nombres;

#endregion
        //metodo para llenar arreglo
        public void llenarArreglo()
        {
            for (int i = 0; i < this.valores.Length; i++)
            {
                this.valores[i] = i + 3;
            }
            for (int i = 0; i < this.valores.Length; i++)
            {
                this.valor[i] = this.valores[i];
            }
        }
        public void leerArregloExamen(int v1, int v2, int v3, int v4, int v5)
        {
            valores[0] = v1;
            valores[1] = v2;
            valores[2] = v3;
            valores[3] = v4;
            valores[4] = v5;
        }

        //imprimir arreglo
        public int[] imprimirArreglo()
        {
            /*for (int i = 0; i < this.valores.Length; i++)
            {
                this.valor[i] = this.valores[i];
            }*/
            return this.valor;
        }


    //nuevo arreglo con base al primero
    /*int[] valores2 = new int[int.Parse(valores.Length)];

    for (i, i<=10, i++){

    }
    //datos sin ordenar
    for (i, i<=10, i++){

    }
    //datos ordenados con sort
    for (i, i<=10, i++){

    }
    //pasando el arreglo numeros a otro nuevo
    //declaro una instancia del arreglo origen
    int[] numerotes = new int[numeros.Length];
    for (i, i<=10, i++){

    }
    */
}
}