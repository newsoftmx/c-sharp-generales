using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//agreggue estas librerías
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;
using System.Text;
//fin de librerías
namespace conexionesDatos_SQL_AJAX
{
    public partial class Clase : System.Web.UI.Page
    {
        #region variables
        SqlConnection conexion = new SqlConnection
            ("Data Source=vibecohack; Initial Catalog=programacionpw; User ID=sa; Password=allispossible;");
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnProbarConexion_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                lblEstadoConexion.Text = "Se ha conectado al servidor";
                conexion.Close();
            }
            catch (Exception)
            {
                conexion.Close();
                lblEstadoConexion.Text = "Ha FALLADO LA CONEXION Al Servidor";
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            ///declaro el comando sql llamado guardar, con el cual ejecuta
            ///el procedimiento almacenado llamado spDepGuardar, conectandose
            ///con la cadena de conexion llamada conexion
            SqlCommand guardar = new SqlCommand("spDepGuardar", conexion);
            ///ahora indico que mi comando sql es un comando de procedimiento almacenado
            guardar.CommandType = CommandType.StoredProcedure;
            ///ahora agrego los parametros donde pasare los datos a guardar
            ///
            guardar.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = txtNombre.Text;
            guardar.Parameters.Add("@apePaterno", SqlDbType.NVarChar).Value = txtApePaterno.Text;
            guardar.Parameters.Add("@apeMaterno", SqlDbType.NVarChar).Value = txtApeMAterno.Text;
            guardar.Parameters.Add("@edad", SqlDbType.NVarChar).Value = txtEdad.Text;
            guardar.Parameters.Add("@estatus", SqlDbType.Bit).Value = ckbEstatus.Checked;
            guardar.Parameters.Add("@nivel", SqlDbType.NVarChar).Value = ddlNivel.SelectedValue;

            try
            {
                conexion.Open();
                guardar.ExecuteNonQuery();
                conexion.Close();
                lblProceso.Text = "Registro Guardado Correctamente";
            }
            catch (Exception)
            {
                conexion.Close();
                lblProceso.Text = "Error al guardar el registro";
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            ///declaro mi comando sql para poder procesar la actualizar
            ///
            SqlCommand actualizar = new SqlCommand("spDepAct", conexion);
            ///indico que mi comando sql es de tipo procedimiento almacenado
            ///
            actualizar.CommandType = CommandType.StoredProcedure;
            ///ahora indico los parametros a usar para realizar la operación
            ///
            actualizar.Parameters.Add("@id", SqlDbType.Int).Value = txtID.Text;
            actualizar.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = txtNombre.Text;
            actualizar.Parameters.Add("@apePaterno", SqlDbType.NVarChar).Value = txtApePaterno.Text;
            actualizar.Parameters.Add("@apeMaterno", SqlDbType.NVarChar).Value = txtApeMAterno.Text;
            actualizar.Parameters.Add("@edad", SqlDbType.Int).Value = txtEdad.Text;
            actualizar.Parameters.Add("@estatus", SqlDbType.Bit).Value = ckbEstatus.Checked;
            actualizar.Parameters.Add("@nivel", SqlDbType.NVarChar).Value = ddlNivel.SelectedValue;

            try
            {
                conexion.Open();
                actualizar.ExecuteNonQuery();
                conexion.Close();
                lblProceso.Text = "Registro Guardado Correctamente";
            }
            catch (Exception)
            {
                conexion.Close();
                lblProceso.Text = "Error al guardar el registro";
            }

        }

        protected void btnBuscarID_Click(object sender, EventArgs e)
        {
            SqlCommand buscarID = new SqlCommand("spBusDepID", conexion);
            buscarID.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter datos = new SqlDataAdapter();
            datos.SelectCommand = buscarID;
            DataSet conjunto = new DataSet();
            try
            {
                buscarID.Parameters.Add("@id", SqlDbType.Int).Value = txtID.Text;
                conexion.Open();
                datos.Fill(conjunto, "datos");
                conexion.Close();
                txtNombre.Text = conjunto.Tables[0].Rows[0][1].ToString();
                txtApePaterno.Text = conjunto.Tables[0].Rows[0][2].ToString();
                txtApeMAterno.Text = conjunto.Tables[0].Rows[0][3].ToString();
                txtEdad.Text = conjunto.Tables[0].Rows[0][4].ToString();
                ckbEstatus.Checked = bool.Parse(conjunto.Tables[0].Rows[0][5].ToString());
                ddlNivel.SelectedValue = conjunto.Tables[0].Rows[0][6].ToString();
            }
            catch (Exception)
            {
                conexion.Close();
                lblProceso.Text = "Error al buscar el registro";
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
                lblProceso.Text = "Eliminado Correctamente";
            }
            catch (Exception)
            {
                conexion.Close();
                lblProceso.Text = "Error al eliminar la información";
            }
        }

        protected void btnBuscarTodos_Click(object sender, EventArgs e)
        {
            SqlCommand buscarTodos = new SqlCommand("spBusDep", conexion);
            buscarTodos.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter datos = new SqlDataAdapter();
            datos.SelectCommand = buscarTodos;
            DataSet conjunto = new DataSet();
            try
            {
                conexion.Open();
                datos.Fill(conjunto, "Datos");
                conexion.Close();
                grvDatos.DataSource = conjunto.Tables["datos"];
                grvDatos.DataBind();
            }
            catch (Exception)
            {
                conexion.Close();
                lblProceso.Text = "No se pueden mostrar los datos";
            }
        }
    }
}