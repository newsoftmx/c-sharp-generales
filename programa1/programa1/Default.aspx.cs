using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace programa1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAreaCirculo_Click(object sender, EventArgs e)
        {
            /*lo que sea
            declaro la variable radio de tipo double
            para soportar numeros con decimales
            y que sean muy largos.*/
            double radio, area, perimetro;
            //leer el radio del circulo
            radio = double.Parse(txtRadio.Text);
            //obtenemos el area del circulo
            area = 3.1416 * radio*radio;
            //mostramos el valor del area en el label
            lblAreaCirculo.Text = Convert.ToString(area);
            //obtener el perimetro del circulo
            perimetro = 3.1416 * (2 * radio);
            //muestro el valor del perimetro
            lblPerimetroCirculo.Text = Convert.ToString(perimetro);
        }

        protected void btnAreaTriangulo_Click(object sender, EventArgs e)
        {
            float baseTriangulo, altura, area;
            baseTriangulo = float.Parse(txtBaseTriangulo.Text);
            altura = float.Parse(txtAltura.Text);
            area = (baseTriangulo * altura) / 2;
            lblAreaTriangulo.Text = Convert.ToString(area);
            //ahora aprendemos el uso de la instruccion IF
            //se usa para verificar si se cumple o no
            //una condición, 
            if (area <= 0)
            {
                if(baseTriangulo<=0)
                {
                    lblObservaciones.Text = "Por favor corrija el valor de la base";
                }
                if (altura <= 0)
                {
                    lblObservaciones.Text = "Por favor corrija el valor de la altura";
                }
                if (altura<=0 && baseTriangulo <= 0)
                {

                }
            }
            else//significa contrario, en caso de no cumplirse la condición
            {
                lblObservaciones.Text = "Su triangulo es correcto";
                /************************************************/
                //      PRACTICA            2 
                //REALIZAR EN ESTE PROYECTO, TODO LO NECESARIO PARA
                //CALCULAR EL AREA Y PERIMETRO DE LAS FIGURAS
                // CIRCULO, CUADRADO, HEXAGONO, PENTAGONO
                //ROMBOIDE Y TRAPECIO
                //FECHA DE ENTREGA, LUNES 11/SEP/2017-22:00 HORAS EN PLATAFORMA
                //EN PLATAFORMA SE PEGA EL LINK O URL DE LA CARPETA DE LA NUBE
                //EN LA CUAL ESTA LOCALIZADO EL PROYECTO
                //ES REQUISITO PARA PODER PRESENTAR EXAMEN


            }
        }
    }
}