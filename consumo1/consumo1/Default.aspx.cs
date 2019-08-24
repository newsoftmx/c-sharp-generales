using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//agrogo esto
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace consumo1
{
    public partial class _Default : System.Web.UI.Page
    {
        //instanciamos el servicio del que tenemos la referencia 
       //serviceReference1.servicioVCSoapClient serviciovc1 = new serviceReference1.servicioVCSoapClient();
       servicioElGuille.ConversorSoapClient conversor = new servicioElGuille.ConversorSoapClient();
       //s2.servicioVCSoapClient snuevo = new s2.servicioVCSoapClient();
       //geoIP.GeoIPServiceSoapClient ip = new geoIP.GeoIPServiceSoapClient();
        string nombre, apePaterno, apeMaterno, nivel;
        bool estatus;
        int edad;
        double resultado;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnFarenheit_Click(object sender, EventArgs e)
        {
            resultado = double.Parse(txtCentigrados.Text);
            resultado = conversor.CaF(resultado);
            lblFaren.Text = Convert.ToString( resultado);
        }

        protected void btnCelcius_Click(object sender, EventArgs e)
        {
            resultado = double.Parse(txtFarenheit.Text);
            resultado = conversor.FaC(resultado);
            lblCelcius.Text =Convert.ToString(resultado);
        }

        protected void btnClima_Click(object sender, EventArgs e)
        {
            string clima = txtClima.Text;
            
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            nombre=txtNombre.Text;
            apePaterno=txtApePaterno.Text;
            apeMaterno=txtApeMaterno.Text;
            edad= int.Parse(txtEdad.Text);
            estatus = ckbEstatus.Checked;
            nivel= txtNivel.Text;
            /*
            if(serviciovc1.deportistaGuardarSP(nombre,apeMaterno,apeMaterno,edad, estatus, nivel)==true)
            {
                lblDatos.Text = "correcto";
            }
            else
            {
                lblDatos.Text = "Error";
            }*/
        }

        protected void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            DataSet datosObtenidos = new DataSet();
            //datosObtenidos=snuevo.deprtistaBuscarTodosSP();

            
            //DataSet ds = mo.MobileDataset();
            gdvDatos.DataSource = datosObtenidos.Tables["DatosGenerales"];
            gdvDatos.DataBind();
            /*if(datosObtenidos.Tables[0].Rows.Count>0)
            {*/
                //gdvDatos.DataSource = datosObtenidos.Tables["DatosGenerales"];
            //gdvDatos.DataSource = datosObtenidos.Tables[0].DefaultView;    
            //gdvDatos.DataBind();
            /*
            }
            else
            {
                lblDatos.Text = "No existen registros";
            }*/
        }

        protected void btnObtenerInfo_Click(object sender, EventArgs e)
        {
            string direccion;
            direccion = txtIP.Text;
            DataSet ipds = new DataSet();
            //ipds = ip.GetGeoIP(direccion);
            //ip.GetGeoIP(direccion);
        }
    }
}