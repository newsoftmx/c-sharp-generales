using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

public partial class invocacion : System.Web.UI.Page
{
    //hacemos llabel1 instancia del servicio con store procedure
    WSVB2SP.servicioVBSPSoapClient consumirSP = new WSVB2SP.servicioVBSPSoapClient();
    //hacemos la instancia del servicio sin store procedure
    WSVB.servicioVBSoapClient consumirNormal = new WSVB.servicioVBSoapClient();
    string nombre, apePaterno, apeMaterno, nivel;
    int edad;
    bool estatus;
    DataSet conjunto = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnGuardarSP_Click(object sender, EventArgs e)
    {
        nombre = txtNombre.Text;
        apePaterno = txtApePaterno.Text;
        apeMaterno = txtApeMaterno.Text;
        edad = int.Parse(txtEdad.Text);
        estatus = ckbEstatus.Checked;
        nivel = ddlNivel.SelectedItem.ToString();
        if (consumirSP.deportistaGuardarSP(nombre, apePaterno, apeMaterno, edad, estatus, nivel) == true)
        {
            lblEstado.Text = "Gaurdado Correctamente";
        }
        else
        {
           lblEstado.Text = "Error al guardar";
        }
    }
    protected void btnGuardarNormal_Click(object sender, EventArgs e)
    {

    }
}