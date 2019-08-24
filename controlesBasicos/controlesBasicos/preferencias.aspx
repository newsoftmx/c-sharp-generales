<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="preferencias.aspx.cs" Inherits="controlesBasicos.preferencias" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <p>
        Estimado pasajero, le informamos que su viaje inicia el 
        <br /> <% 
                  %>
        <br /> Deporte a prácticar
        <br /> <% Response.Write(Request.Form["ddlDeporte"].ToString()); %>
        <br /> Nivel de inglés
        <br /> <% Response.Write(Request.Form["calFechaViaje"].ToString()); %>
        <br /> Deporte a prácticar
        <br /> <% Response.Write(Request.Form["textbox1"].ToString()); %>
        <br /> Nivel de office
        <br /> <% Response.Write(Request.Form["textbox1"].ToString()); %>
        <br /> Música a escuchar
        <br /> <% Response.Write(Request.Form["textbox1"].ToString()); %>
        <br /> Visiatara la disco
        <br /> <% Response.Write(Request.Form["textbox1"].ToString()); %>
        <br /> Ciudades a visitar
        <br /> <% Response.Write(Request.Form["textbox1"].ToString()); %>
        <br /> <% Response.Write(Request.Form["textbox1"].ToString()); %>
    </p>
    </div>
    </form>
</body>
</html>
