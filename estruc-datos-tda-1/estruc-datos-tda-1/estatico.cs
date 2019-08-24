using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace estruc_datos_tda_1
{
    public class estatico
    {
        #region "variables"
        int gabriela;
        int[] valores = new int[5];
        int[] mireles = new int[5];
        #endregion
        
        #region "metodos"
        public  void llenarArreglo()
        {
            for (gabriela=0; gabriela<= this.valores.Length-1; gabriela++)
             {
                this.valores[gabriela] = gabriela + 4;
             }
        }
        public int[] imprimirArreglo()
        {
            for(gabriela=0; gabriela <= this.valores.Length - 1; gabriela++)
            {
                this.mireles[gabriela] = this.valores[gabriela];
            }
            return this.mireles;
        }
        #endregion
    }
}