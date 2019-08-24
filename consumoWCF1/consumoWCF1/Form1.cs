using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace consumoWCF1
{
    public partial class Form1 : Form
    {
        servicioWCF.Service1Client clientServWCF = new servicioWCF.Service1Client();
        //hacemos una referencia detipo deportisga
        servicioWCF.deportista deportes = new servicioWCF.deportista();
        DataSet conjunto = new DataSet();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardarSP_Click(object sender, EventArgs e)
        {
            deportes.nombre = txtNombre.Text;
            deportes.apePaterno = txtApePaterno.Text;
            deportes.apeMaterno = txtApeMaterno.Text;
            deportes.edad = int.Parse( txtEdad.Text);
            deportes.estatus = ckbEstatus.Checked;
            deportes.nivel = cmbNivel.SelectedItem.ToString();
            if(clientServWCF.guardarDeportista(deportes))
            {
                MessageBox.Show("Guardado Correctamente");
            }
            else
            {
                MessageBox.Show("No se guardo correctamente");
            }
        }

        private void btnBuscarTodosSP_Click(object sender, EventArgs e)
        {
            conjunto = clientServWCF.seleccionarDeportistas();
            dgvDeportistas.DataSource = conjunto.Tables[0];
           
        }

        private void btnBuscarIDSP_Click(object sender, EventArgs e)
        {
            int id;
            id = int.Parse(txtID.Text);
            conjunto = clientServWCF.deportistaID(id);
            dgvDeportistas.DataSource = conjunto.Tables[0];
            txtNombre.Text = conjunto.Tables[0].Rows[0][1].ToString();
            txtApePaterno.Text = conjunto.Tables[0].Rows[0][2].ToString();
            txtApeMaterno.Text = conjunto.Tables[0].Rows[0][3].ToString();
            txtEdad.Text = conjunto.Tables[0].Rows[0][4].ToString();
            ckbEstatus.Checked = bool.Parse( conjunto.Tables[0].Rows[0][5].ToString());
            cmbNivel.SelectedItem = conjunto.Tables[0].Rows[0][6].ToString();
        }
    }
}
