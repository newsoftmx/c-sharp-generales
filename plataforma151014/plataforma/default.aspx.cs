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
            MySqlConnection conectar = new MySqlConnection("server=localhost; database=plataforma; Uid=root; pwd=;");
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
            guardar.Parameters.AddWithValue("@sistemaAct", this.txtSistema.Text);
            guardar.Parameters.AddWithValue("@escuelaAct", this.txtEscuela.Text);
            guardar.Parameters.AddWithValue("@carreraAct", this.txtCarrera.Text);
            guardar.Parameters.AddWithValue("@nombreAct", this.txtNombre.Text);

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