﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
    protected void btnContratoPrivacidad_Click(object sender, EventArgs e)
    {
        string hola = txtNombre1.Text;
        txtNombre.Text = hola;
        btnContratoPrivacidad_ModalPopupExtender.Show();
    }
    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        btnContratoPrivacidad_ModalPopupExtender.Hide();
    }
}