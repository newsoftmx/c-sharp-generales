using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace subirArchivo
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubir_Click(object sender, EventArgs e)
        {
            string fileName = "";
            string rootPath = "";
            //verifica mos si el file upload tiene archivos
            if ( fluSubir.HasFile)
            {
                //declaramos la ruta que tendra rootPath, indicando una del servidor
                rootPath = Server.MapPath("~/Images");
                //agregamos el archivo del control a la carpeta que usaremos para guardar los datos
                foreach (HttpPostedFile file in fluSubir.PostedFiles)
                {
                    //agregamos el nombre del archivo
                    fileName = Path.GetFileName(file.FileName);
                    //indicamos que el archivo se guardara en la ruta indicada, con el nombre del archivo indicado
                    file.SaveAs(Path.Combine(rootPath, fileName));
                }
            }
            //Image1.ImageUrl = rootPath + "\\" + fileName;
        }
    }
}