using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    serviciovc.servicioVCSoapClient alex = new serviciovc.servicioVCSoapClient();
    elGuille.ConversorSoapClient conversor = new elGuille.ConversorSoapClient();
    string nombre, apePAterno, apeMaterno, nivel;
    int edad;
    bool estatus;
    double resultado;
    DataSet conjunto = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnMostrarTodos_Click(object sender, EventArgs e)
    {
        conjunto = alex.deprtistaBuscarTodosSP();
        gdvDatos.DataSource = conjunto.Tables["DatosGenerales"];
        gdvDatos.DataBind();
    }

    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        nombre = txtNombre.Text;
        apePAterno = txtApePaterno.Text;
        apeMaterno = txtApeMaterno.Text;
        edad = int.Parse( txtEdad.Text);
        estatus = bool.Parse( txtEstatus.Text);
        nivel = txtNivel.Text;
        if(alex.deportistaGuardarSP(nombre, apePAterno,apeMaterno,edad,estatus,nivel)==true)
        {
            lblResultado.Text = "Guardado Correctamente";
        }
        else
        {
            lblResultado.Text = "Error al guardar";
        }
    }
    protected void btnFarenheit_Click(object sender, EventArgs e)
    {
        resultado = double.Parse(txtCentigrados.Text);
        resultado = conversor.CaF(resultado);
        lblFaren.Text = Convert.ToString(resultado);
    }
}