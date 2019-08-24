using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Invocacion_ABCMV
{

    public partial class form1 : Form
    {

        WS_Javier.Service AP = new Invocacion_ABCMV.WS_Javier.Service();
        string Nombre, Domicilio, Telefono;
        double Saldo;
        int Edad,idd; 
        DataSet conjunto= new DataSet();

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Nombre=txtNombre.Text;
            Domicilio = txtDomicilio.Text;
            Telefono = txtTelefono.Text;
            Saldo = double.Parse(txtSaldo.Text);
            Edad = int.Parse(txtEdad.Text);
            if (AP.Do_Guardar(Nombre, Domicilio, Telefono, Edad, Saldo) == true)
            {
                MessageBox.Show("Guardado");
            }
            else
            {
                MessageBox.Show("no");
            }

        }

        private void form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEliminacion_Click(object sender, EventArgs e)
        {
            idd = int.Parse(txtId.Text);
            if (AP.Do_Eliminar(idd)
            {
                MessageBox.Show("Eliminado perfectamente");
            }
            else
            {
                MessageBox.Show("no se pudo eliminar");
            }
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            idd = int.Parse(txtId.Text);
            if (AP.Do_Verificar(idd) == true)
            {
                MessageBox.Show("Si existe");
            }
            else
            {
                MessageBox.Show("No Existe");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Nombre=txtNombre.Text;
            Domicilio = txtDomicilio.Text;
            Telefono = txtTelefono.Text;
            Saldo = double.Parse(txtSaldo.Text);
            Edad = int.Parse(txtEdad.Text);
            idd = int.Parse(txtId.Text);
            if (AP.Do_Actualizar(idd, Nombre, Domicilio, Telefono, Edad, Saldo) == true)
            {
                MessageBox.Show("Actualizacion correcta");
            }
            else
            {
                MessageBox.Show("No se pudo Actualizar");
            }
        }

        private void btnConsultarTodo_Click(object sender, EventArgs e)
        {
            conjunto = AP.Do_BuscarTodo();
            dataGridView1.DataSource = conjunto.Tables["DatosGenerales"];
        }

        private void btnConsultarRegistro_Click(object sender, EventArgs e)
        {
            idd = int.Parse(txtId.Text);
            conjunto = AP.Do_BuscarRegistro(idd);
            dataGridView1.DataSource = conjunto.Tables["DatosGenerales"];
        }

        private void btnConsultarSaldo_Click(object sender, EventArgs e)
        {
            idd = int.Parse(txtId.Text);
            Saldo = AP.Do_BuscarSaldo(idd);
            MessageBox.Show(Saldo.ToString());
        }

     


    }
}
