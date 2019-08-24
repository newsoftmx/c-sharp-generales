using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

namespace proyectoU2
{
    public class procesos
    {
        #region "variables"
        double[] preciosMascotas = new double[5];
        string[] arregloTipoMascota;
        ArrayList tipoMascotaSeleccionada = new ArrayList();
        #endregion
        public double[] leerPreciosMascotas()
        {
            preciosMascotas[0] = 200;
            preciosMascotas[1] = 250;
            preciosMascotas[2] = 300;
            preciosMascotas[3] = 350;
            preciosMascotas[4] = 400;
            return preciosMascotas;
        }
        //metodo para almacenar los valores en un arreglo
        public ArrayList guardarTipoMascota(string tipoMascota)
        {
            //tomar el valor que llega a la variable tipoMascota y almacenarlo
            //en un arreglo
            tipoMascotaSeleccionada.Add(tipoMascota);
            return tipoMascotaSeleccionada;
        }
        //metodo para leer los valores de un arreglo
    }
}