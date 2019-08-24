using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
//agregar
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;

namespace invocacionWSVB
{
    public partial class Form1 : Form
    {
        //hacemos llabel1 instancia del servicio con store procedure
        WSVBSP.servicioVBSPSoapClient consumirSP = new WSVBSP.servicioVBSPSoapClient();
        //hacemos la instancia del servicio sin store procedure
        WSVB.servicioVBSoapClient consumirNormal = new
            WSVB.servicioVBSoapClient();
        string nombre, apePaterno, apeMaterno, nivel;
        int edad, id;
        bool estatus;
        DataSet conjunto = new DataSet();
        SqlDataAdapter datos = new SqlDataAdapter();
        public Form1()
        {
            InitializeComponent();
        }
        #region "controles SP"
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            nombre= txtNombre.Text;
            apePaterno=txtApePaterno.Text;
            apeMaterno=txtApeMaterno.Text;
            edad=int.Parse(txtEdad.Text);
            estatus=ckbEstatus.Checked;
            nivel= cmbNivel.SelectedItem.ToString();
            if(consumirSP.deportistaGuardarSP(nombre, apePaterno, apeMaterno, edad, estatus, nivel)==true)
            {
                MessageBox.Show("Guardado");
            }
            else
            {
                MessageBox.Show("Error al guardar");
            }
        }
        private void btnBuscarIDSP_Click_1(object sender, EventArgs e)
        {
            id =int.Parse(txtID.Text);
            conjunto = consumirSP.deportistaBuscarIDSP(id);
            dgvDeportistas.DataSource = conjunto.Tables["DatosGenerales"];
            //bajamos los datos al grid
            if (conjunto.Tables[0].Rows.Count>0)
            {
                txtNombre.Text = conjunto.Tables[0].Rows[0][1].ToString();
                txtApePaterno.Text = conjunto.Tables[0].Rows[0][2].ToString();
                txtApeMaterno.Text = conjunto.Tables[0].Rows[0][3].ToString();
                txtEdad.Text = conjunto.Tables[0].Rows[0][4].ToString();
                ckbEstatus.Checked=bool.Parse(conjunto.Tables[0].Rows[0][5].ToString());
                cmbNivel.SelectedItem = conjunto.Tables[0].Rows[0][6].ToString();
            }
            else
            {
                MessageBox.Show("No tenemos registros");
            }

        } 
        
        private void btnGuardarNormal_Click(object sender, EventArgs e)
        {
            nombre = txtNombre.Text;
            apePaterno = txtApePaterno.Text;
            apeMaterno = txtApeMaterno.Text;
            edad = int.Parse(txtEdad.Text);
            estatus = ckbEstatus.Checked;
            nivel = cmbNivel.SelectedItem.ToString();
            if (consumirNormal.deportistaGuardar(nombre, apePaterno, apeMaterno, edad, estatus, nivel) == true)
            {
                MessageBox.Show("guardado");
            }
            else
            {
                MessageBox.Show("Error al guardar");
            }
        }

        private void btnBuscarTodosSP_Click(object sender, EventArgs e)
        {
            conjunto = consumirSP.deportistaBuscarTodosSP();
            if (conjunto.Tables[0].Rows.Count > 0)
            {
                dgvDeportistas.DataSource = conjunto.Tables["DatosGenerales"];
            }
            else
            {
                MessageBox.Show("No existen registros");
            }
        }

        private void btnEliminarSP_Click(object sender, EventArgs e)
        {
            id = int.Parse(txtID.Text);
            if (consumirSP.deportistaEliminarSP(id) == true)
            {
                MessageBox.Show("Registro eliminado correctamente");
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el registro");
            }
        }

        private void btnActualizarSP_Click(object sender, EventArgs e)
        {
            nombre = txtNombre.Text;
            apePaterno = txtApePaterno.Text;
            apeMaterno = txtApeMaterno.Text;
            edad = int.Parse(txtEdad.Text);
            estatus = ckbEstatus.Checked;
            nivel = cmbNivel.SelectedItem.ToString();
            id = int.Parse(txtID.Text);
            if (consumirSP.deportistaActualizarSP(id,nombre, apePaterno, apeMaterno, edad, estatus,nivel) == true)
            {
                MessageBox.Show("Actualizado correctamente");
            }
            else
            {
                MessageBox.Show("Error al actualizar");
            }
        }

        private void btnBuscarIDNormal_Click(object sender, EventArgs e)
        {
            id = int.Parse(txtID.Text);
            conjunto = consumirSP.deportistaBuscarIDSP(id);
            //bajamos los datos al grid
            if (conjunto.Tables[0].Rows.Count > 0)
            {
                txtNombre.Text = conjunto.Tables[0].Rows[0][1].ToString();
                txtApePaterno.Text = conjunto.Tables[0].Rows[0][2].ToString();
                txtApeMaterno.Text = conjunto.Tables[0].Rows[0][3].ToString();
                txtEdad.Text = conjunto.Tables[0].Rows[0][4].ToString();
                ckbEstatus.Checked = bool.Parse(conjunto.Tables[0].Rows[0][5].ToString());
                cmbNivel.SelectedItem = conjunto.Tables[0].Rows[0][6].ToString();
            }
            else
            {
                MessageBox.Show("No tenemos registros");
            }
        }

        private void btnEliminarNormal_Click(object sender, EventArgs e)
        {
            id = int.Parse(txtID.Text);
            if (consumirSP.deportistaEliminarSP(id) == true)
            {
                MessageBox.Show("Registro eliminado correctamente");
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el registro");
            }
        }

        private void btnBuscarTodosNormal_Click(object sender, EventArgs e)
        {
            conjunto = consumirNormal.deportistaBuscarTodos();
            if (conjunto.Tables[0].Rows.Count > 0)
            {
                dgvDeportistas.DataSource = conjunto.Tables["DatosGenerales"];
            }
            else
            {
                MessageBox.Show("No existen registros");
            }
        }

        private void btnActualizarNormal_Click(object sender, EventArgs e)
        {
            nombre = txtNombre.Text;
            apePaterno = txtApePaterno.Text;
            apeMaterno = txtApeMaterno.Text;
            edad = int.Parse(txtEdad.Text);
            estatus = ckbEstatus.Checked;
            nivel = cmbNivel.SelectedItem.ToString();
            id = int.Parse(txtID.Text);
            if (consumirSP.deportistaActualizarSP(id, nombre, apePaterno, apeMaterno, edad, estatus, nivel) == true)
            {
                MessageBox.Show("Actualizado correctamente");
            }
            else
            {
                MessageBox.Show("Error al actualizar");
            }
        }
        #endregion



    }
}
