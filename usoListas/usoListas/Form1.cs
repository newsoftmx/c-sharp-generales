using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace usoListas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Contacto dato = new Contacto();
            dato.Id = 1;
            dato.Nombre = "Osvaldo";
            dato.Domicilio = "Lagos";
            
            dato.Id = 2;
            dato.Nombre = "Victor";
            dato.Domicilio = "Lagos";

            List<Contacto> listContacot = new List<Contacto>();
            for (int i = 0; i < 2; i++)
            {
                listContacot[i].Add(item);
            }
            listContacot.Add(dato);

            foreach (var item in listContacot)
            {
                MessageBox.Show("Algo" + item.Nombre);
            }
        }
    }
}
