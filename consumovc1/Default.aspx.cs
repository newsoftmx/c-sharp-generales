using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    serviciovc.servicioVCSoapClient serviciovc1 = new serviciovc.servicioVCSoapClient();
    DataSet ds = new DataSet();
    string nombre, apePaterno, apeMaterno, nivel;
    int edad;
    bool estatus;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnMostrarTodos_Click(object sender, EventArgs e)
    {
        ds=serviciovc1.deprtistaBuscarTodosSP();
        gdvDatos.DataSource = ds.Tables["DatosGenerales"];
        gdvDatos.DataBind();
    }
    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        nombre = txtNombre.Text;
        apePaterno = txtApePaterno.Text;
        apeMaterno = txtApeMaterno.Text;
        edad = int.Parse(txtEdad.Text);
        estatus = bool.Parse(txtEstatus.Text);
        nivel = txtNivel.Text;
        if (serviciovc1.deportistaGuardarSP(nombre, apePaterno, apeMaterno, edad, estatus, nivel) == true) 
        {
            lblResultado.Text = "Guardardo";
        }
        else
        {
            lblResultado.Text = "Error al Guardar";
        }
    }
}