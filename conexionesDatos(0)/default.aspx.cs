using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//agregar
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;
using System.Text;

public partial class _default : System.Web.UI.Page
{
    #region variables
    SqlConnection conexion = new SqlConnection
        ("Data Source=vibecohack; Initial Catalog=programacionpw; User ID=sa; Password=allispossible;");
    //string cn, coni;
    //conexion = "";
    
    //cn = "Data Source = VIBECOHACK; Initial Catalog = Programacionpw.mdf; user id=";
    //coni = "Data Source=VIBECOHACK;Initial Catalog=programacionpw; user id=sa; password=Victornash1982";
    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }    
    protected void btnProbarConexon_Click(object sender, EventArgs e)
    {
        try
        {
            conexion.Open();
            lblConexion.Text = "Se ha conectado satisfactoriamente";
            conexion.Close();
        }
        catch (Exception)
        {
            
            throw;
        }
    }
    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        SqlCommand guardar = new SqlCommand("spDepGuardar", conexion);
        guardar.CommandType = CommandType.StoredProcedure;
        guardar.Parameters.Add("@nombre",SqlDbType.NVarChar).Value= txtNombre.Text;
        guardar.Parameters.Add("@apePaterno", SqlDbType.NVarChar).Value = txtApePaterno.Text;
        guardar.Parameters.Add("@apeMaterno", SqlDbType.NVarChar).Value = txtApeMaterno.Text;
        guardar.Parameters.Add("@edad", SqlDbType.Int).Value = txtEdad.Text;
        guardar.Parameters.Add("@estatus", SqlDbType.Bit).Value = ckbEstatus.Checked;
        guardar.Parameters.Add("@nivel", SqlDbType.NVarChar).Value = ddlNivel.SelectedValue;
        try
        {
            conexion.Open();
            guardar.ExecuteNonQuery();
            conexion.Close();
            lblEstatusGuardar.Text = "Guardado Correctamente";
            return;
        }
        catch (Exception)
        {
            lblEstatusGuardar.Text = "Un error al guardar la informacion";
                conexion.Close();
        }

    }
    protected void btnBuscarTodos_Click(object sender, EventArgs e)
    {
        SqlCommand buscar = new SqlCommand("spBusDep", conexion);
        buscar.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter datos = new SqlDataAdapter();
        datos.SelectCommand = buscar;
        DataSet conjunto = new DataSet();
        try 
	    {	        
		    conexion.Open();
            datos.Fill(conjunto, "Datos");
            conexion.Close();
            gridDeportistas.DataSource= conjunto.Tables["Datos"];
            gridDeportistas.DataBind();
	    }
	    catch (Exception)
	    {
            conexion.Close();
	    }
        
    }
    protected void btnBuscarID_Click(object sender, EventArgs e)
    {
        SqlCommand buscar = new SqlCommand("spBusDepID", conexion);
        buscar.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter datos = new SqlDataAdapter();
        datos.SelectCommand = buscar;
        DataSet conjunto = new DataSet();
        try
        {
            buscar.Parameters.Add("@id", SqlDbType.Int).Value = txtID.Text;
            conexion.Open();
            datos.Fill(conjunto, "Datos");
            conexion.Close();
            txtNombre.Text=conjunto.Tables[0].Rows[0][1].ToString();
            txtApePaterno.Text = conjunto.Tables[0].Rows[0][2].ToString();
            txtApeMaterno.Text = conjunto.Tables[0].Rows[0][3].ToString();
            txtEdad.Text = conjunto.Tables[0].Rows[0][4].ToString();
            ckbEstatus.Checked = bool.Parse( conjunto.Tables[0].Rows[0][5].ToString());
            ddlNivel.SelectedValue = conjunto.Tables[0].Rows[0][6].ToString();
            gridDeportistas.DataSource = conjunto.Tables["Datos"];
        }
        catch (Exception)
        {

            throw;
        }
    }
    protected void btnEliminarID_Click(object sender, EventArgs e)
    {
        SqlCommand eliminar = new SqlCommand("spEliDepID", conexion);
        eliminar.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter datos = new SqlDataAdapter();
        datos.SelectCommand = eliminar;
        try
        {
            eliminar.Parameters.Add("@id", SqlDbType.Int).Value = txtID.Text;
            conexion.Open();
            eliminar.ExecuteNonQuery();
            conexion.Close();
            lblEstatusGuardar.Text = "Registro Eliminado Correctamente";
        }
        catch (Exception)
        {
            conexion.Close();
        }
    }


    protected void btnActualizar_Click(object sender, EventArgs e)
    {
        SqlCommand actualizar = new SqlCommand("spDepAct", conexion);
        actualizar.CommandType = CommandType.StoredProcedure;
        actualizar.Parameters.Add("id", SqlDbType.Int).Value = txtID.Text;
        actualizar.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = txtNombre.Text;
        actualizar.Parameters.Add("@apePaterno", SqlDbType.NVarChar).Value = txtApePaterno.Text;
        actualizar.Parameters.Add("@apeMaterno", SqlDbType.NVarChar).Value = txtApeMaterno.Text;
        actualizar.Parameters.Add("@edad", SqlDbType.Int).Value = txtEdad.Text;
        actualizar.Parameters.Add("@estatus", SqlDbType.Bit).Value = ckbEstatus.Checked;
        actualizar.Parameters.Add("@nivel", SqlDbType.NVarChar).Value = ddlNivel.SelectedValue;
        try
        {
            conexion.Open();
            actualizar.ExecuteNonQuery();
            conexion.Close();
            lblEstatusGuardar.Text = "Actualizado Correctamente";
            return;
        }
        catch (Exception)
        {
            lblEstatusGuardar.Text = "Un error al actualizar la informacion";
            conexion.Close();
        }
    }
}