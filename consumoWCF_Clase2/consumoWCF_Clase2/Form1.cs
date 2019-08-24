using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace consumoWCF_Clase2
{
    public partial class Form1 : Form
    {
         wcfclase2.Service1Client clientServWCF = new wcfclase2.Service1Client();
        //hacemos una referencia detipo deportisga
        wcfclase2.deportista deportes = new wcfclase2.deportista();
        DataSet conjunto = new DataSet();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
