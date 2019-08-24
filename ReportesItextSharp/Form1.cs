using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;
using System.IO;
namespace ReportesItextSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private static string CadenaCon()
        {
            try
            {
                return "server=localhost; database=puntoventa; user id=root;password=PWD56XZ ";
            }
            catch (Exception ex)
            {
                return "";
            }
        }
        public void CargarGrid() {
            string cadena = CadenaCon();
            MySqlConnection Conexion = new MySqlConnection(cadena);
            DataSet ds = new DataSet();
            MySqlDataAdapter data = new MySqlDataAdapter("Select * from usuarios",Conexion);
            Conexion.Open();
            data.Fill(ds, "usuarios");
            Conexion.Close();
            dataGridView1.DataSource = ds.Tables["usuarios"].DefaultView;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoResizeColumns();
            dataGridView1.BorderStyle = BorderStyle.None;
        }
        #region crearPDF
        private void To_pdf()
        {
            //itestshrp tiene el objeto document, y se instancia pasando propierdades
            //la propiedad deldocumento es PageSize.tamaño, rot los 10 son los margenes
                    Document doc = new Document(PageSize.LETTER.Rotate(), 10, 10, 10, 10);
                    //esta linea muestra la ventada de guardar archivo y la ruta se almacena en saveFileDialog1  
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            //con esta línea se muestra la ruta por default a mostrar
                    saveFileDialog1.InitialDirectory = @"C:";
            //el titulo de la ventana a mostrar con el save dialog
                    saveFileDialog1.Title = "Guardar Reporte";
            //esta linea hace que los documentos que se muestren en esa ruta, sean puros pdf
                    saveFileDialog1.DefaultExt = "pdf";
            //esta linea permite guardar el archivo como cualquiera o pdf, quitar all files
                    saveFileDialog1.Filter = "pdf Files (*.pdf)|*.pdf| All Files (*.*)|*.*";
            //no m e acuerdo
                    saveFileDialog1.FilterIndex = 2;

                    saveFileDialog1.RestoreDirectory = true;
            //en filename guardo el nombre del archivo se puede llamar de otra forma la variable
                    string filename = "";
            //verificac¿mos que se haya guardado correctamente
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        //filename toma la ruta que fue seleccionada
                        filename = saveFileDialog1.FileName;
                    }
            //el trim es una funcion para quitar espacios de una cadena
            //se tiene trim, trimend, trimstart
                    if (filename.Trim() != "")
                    {
                        //el filestream es para crear un almacenamiento de datos de bytes
                        //recoge la ruta y a guarda en memoria
                        FileStream file = new FileStream(filename,
                        //esta linea crea o abre el archivo
                        FileMode.OpenOrCreate,
                        //se le da acceso de lectura y escritura
                        FileAccess.ReadWrite,
                        //la opción de compartir es para poder leer y escribir
                        FileShare.ReadWrite);

                        //aqui hago un archivo pdf, con el obejto instanciado doc, en file se guardan todas
                        //las propiedades con las que se va a crear ese documento
                        PdfWriter.GetInstance(doc, file);
                        //la instancia abre el archivo para crearlo, todo es virtual, en memoria
                        doc.Open();
                        //adornos
                        string remito = "Autorizo: OSVALDO SANTIAGO ESTRADA";
                        string envio = "Fecha:" + DateTime.Now.ToString();
                        //el objeto chunk es un tipo de formato para el titulo, se puede usar en otras partes
                        //se añaden propiedades de tipo de letra tamaño
                        Chunk chunk = new Chunk("Reporte de General Usuarios", FontFactory.GetFont("ARIAL", 20, iTextSharp.text.Font.BOLD));
                        //agrego una nueva linea peor en blanco, es con paragraph add
                        doc.Add(new Paragraph(chunk));
                        //agrego un espacio en blanco
                        doc.Add(new Paragraph("                       "));
                        doc.Add(new Paragraph("                       "));
                        doc.Add(new Paragraph("------------------------------------------------------------------------------------------"));
                        doc.Add(new Paragraph("Lagos de moreno Jalisco"));
                        doc.Add(new Paragraph(remito));
                        doc.Add(new Paragraph(envio));
                        doc.Add(new Paragraph("------------------------------------------------------------------------------------------"));
                        doc.Add(new Paragraph("                       "));
                        doc.Add(new Paragraph("                       "));
                        doc.Add(new Paragraph("                       "));
                        //este metodo 
                        GenerarDocumento(doc);
                        doc.AddCreationDate();
                        doc.Add(new Paragraph("______________________________________________", FontFactory.GetFont("ARIAL", 20, iTextSharp.text.Font.BOLD)));
                        doc.Add(new Paragraph("Firma", FontFactory.GetFont("ARIAL", 20, iTextSharp.text.Font.BOLD)));
                        doc.Close();
                        Process.Start(filename);//Esta parte se puede omitir, si solo se desea guardar el archivo, y que este no se ejecute al instante
                    }
              
        }
        public void GenerarDocumento(Document document)
        { //este metodo recorre el dataset, haciendo un nuevo documento
            //se usa esta forma para no poner todo este codigo
            int i, j;
            //pdpftable crea una tabla, lo instanciamos con datatable
            PdfPTable datatable = new PdfPTable(dataGridView1.ColumnCount);
            //son propiedades como html
            datatable.DefaultCell.Padding = 3;
            //se usa header withs es una variable, la función de getTamañoColumnas
            //para tener el tamaño del ancho de las columnas del datagridview
            float[] headerwidths = GetTamañoColumnas(dataGridView1);
            //este indica que tan grande va a estar cada columna
            datatable.SetWidths(headerwidths);
            datatable.WidthPercentage = 100;
            datatable.DefaultCell.BorderWidth = 2;
            datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            for (i = 0; i < dataGridView1.ColumnCount; i++)
            {
                datatable.AddCell(dataGridView1.Columns[i].HeaderText);
            }
            datatable.HeaderRows = 1;
            datatable.DefaultCell.BorderWidth = 1;
            for (i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    if (dataGridView1[j, i].Value != null)
                    {
                        datatable.AddCell(new Phrase(dataGridView1[j, i].Value.ToString()));//En esta parte, se esta agregando un renglon por cada registro en el datagrid
                    }
                }
                datatable.CompleteRow();
            }
            document.Add(datatable);
        }
        public float[] GetTamañoColumnas(DataGridView dg)
        {
            //cuenta las columnas que tiene el datagrid y recorre los valores
            float[] values = new float[dg.ColumnCount];
            for (int i = 0; i < dg.ColumnCount; i++)
            {
                values[i] = (float)dg.Columns[i].Width;
            }
            //regresa el arreglo que se recorre alla arriba
            return values;

        }
        #endregion
        private void button2_Click(object sender, EventArgs e)
        {
            To_pdf();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarGrid();
        }
        /*
         *Eso es todo por el momento!! Cualquier duda, dejenme un comentario!!
         *Gracias
         */
    }
}
