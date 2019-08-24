using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
///Agrego las librerias necesarias
///
using MySql.Data.MySqlClient;
using System.Data;

namespace conexionDatosMySQL
{
    
    public partial class _default : System.Web.UI.Page
    {
        #region "variables"
        MySqlConnection conexion = new MySqlConnection
        ("server=localhost; database=programacionpw; Uid=root; pwd=;");
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnProbarConexion_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                lblProceso.Text = "Conexion establecida";
                conexion.Close();
            }
            catch (Exception)
            {
                conexion.Close();
                lblProceso.Text="Error al conectar con el servidor";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MySqlCommand guardar = new MySqlCommand("spEmplGua", conexion);
            guardar.CommandType = CommandType.StoredProcedure;
            //agrego los parametros de forma similar al SQL
            guardar.Parameters.AddWithValue
                ("@nombreU", this.txtNombre.Text);
            guardar.Parameters.AddWithValue
                ("@apellidosU", this.txtApellidos.Text);
            guardar.Parameters.AddWithValue
                ("@edadU", this.txtEdad.Text);
            try
            {
                conexion.Open();
                guardar.ExecuteNonQuery();
                conexion.Close();
                lblProceso.Text = "Guardado con éxito";
            }
            catch (Exception)
            {
                conexion.Close();
                lblProceso.Text = "Error al guardar la información";
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            MySqlCommand actualizar = new MySqlCommand("spEmplAct", conexion);
            actualizar.CommandType = CommandType.StoredProcedure;
            //agrego los parametros de forma similar al SQL
            actualizar.Parameters.AddWithValue("@idU", this.txtId.Text);
            actualizar.Parameters.AddWithValue
                ("@nombreU", this.txtNombre.Text);
            actualizar.Parameters.AddWithValue
                ("@apellidosU", this.txtApellidos.Text);
            actualizar.Parameters.AddWithValue
                ("@edadU", this.txtEdad.Text);
            try
            {
                conexion.Open();
                actualizar.ExecuteNonQuery();
                conexion.Close();
                lblProceso.Text = "Actualizado con éxito";
            }
            catch (Exception)
            {
                conexion.Close();
                lblProceso.Text = "Error al actualizar la información";
            }
        }

        protected void btnBuscarID_Click(object sender, EventArgs e)
        {
            MySqlCommand buscarID = new MySqlCommand
                ("spEmpleBuscarID", conexion);
            buscarID.CommandType=CommandType.StoredProcedure;
            MySqlDataAdapter datos = new MySqlDataAdapter();
            datos.SelectCommand=buscarID;
            DataSet conjunto = new DataSet();
            buscarID.Parameters.AddWithValue("@idU", this.txtId.Text);
            try
            {
                conexion.Open();
                datos.Fill(conjunto, "Datos");
                conexion.Close();
                txtNombre.Text = conjunto.Tables[0].Rows[0][1].ToString();
                txtApellidos.Text = conjunto.Tables[0].Rows[0][2].ToString();
                txtEdad.Text = conjunto.Tables[0].Rows[0][3].ToString();
                lblProceso.Text = "Registro Mostrado correctamente";
            }
            catch (Exception ex)
            {
                conexion.Close();
                lblProceso.Text = 
                    "El registro no existe o se presento el error" + ex;
            }
        }

    }
}