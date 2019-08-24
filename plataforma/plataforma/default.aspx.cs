using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
///agrego la lbreria
using MySql.Data.MySqlClient;
using System.Data;

namespace plataforma
{
    public partial class _default : System.Web.UI.Page
    {
        #region "variables"
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=plataforma; Uid=root; pwd=;");
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnProbarConexion_Click(object sender, EventArgs e)
        {
            try 
	        {	        
		        conectar.Open();
                conectar.Close();
                lblProceso.Text="Conexion Correcta";
	        }
	        catch (Exception)
	        {
                conectar.Clone();

	        }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            ///in sistemaAct int, in escuelaAct int, in carreraAct int, in nombreAct varchar(150))
            MySqlCommand guardar = new MySqlCommand("spPlataGua" , conectar);
            guardar.CommandType = CommandType.StoredProcedure;

            guardar.Parameters.AddWithValue("@campusAct", this.ddlCampus.SelectedValue);
            guardar.Parameters.AddWithValue("@sistemaAct", this.ddlNivelSistema.SelectedValue);
            guardar.Parameters.AddWithValue("@escuelaAct", this.ddlEscuelaFacultad.SelectedValue);
            guardar.Parameters.AddWithValue("@carreraAct", this.ddlNombreCarrera.SelectedValue);
            guardar.Parameters.AddWithValue("@nombreAct", this.ddlNombreCarrera.SelectedItem);

            try
            {
                conectar.Open();
                guardar.ExecuteNonQuery();
                conectar.Close();
                lblProceso.Text = "Guardado Correctamente";
            }
            catch (Exception)
            {
                conectar.Close();
                lblProceso.Text = "Error al Gaurdar";
            }
        }
    }
}