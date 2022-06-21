<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="ServicioClientePublico.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <div>
        <h1>Servicios web con asp.net utilizando base de datos PostgreSQL</h1>
    </div>
    <br />

    <form id="form1" runat="server">
        <h3>Datos de consulta: </h3>
        <br />
       <asp:TextBox ID="TxtB1" runat="server"></asp:TextBox>
       <br />
       <br />
       <asp:Button ID="Bt1" runat="server" Height="35px" Text="Consulta por ID" OnClick="Bt1_Click" />
    <br />
    <div>
        <label>Datos consultados: </label>
        <br />
        <br />
        <label>Nombre: </label><asp:Label ID="Lbl1" runat="server" Text="Label" Height="29px" Width="188px"></asp:Label>
        <br />
        <label>Apellido Paterno: </label><asp:Label ID="Lbl2" runat="server" Text="Label" Height="29px" Width="188px"></asp:Label>
        <br />
        <label>Apellido Materno: </label><asp:Label ID="Lbl3" runat="server" Text="Label" Height="29px" Width="188px"></asp:Label>
    </div>
    <br />
    <div>
        <asp:Button ID="BtnAll" runat="server" Text="Mostrar todo" OnClick="BtnAll_Click" />
        <br /> 
        <br />
        <label>Elemento consultados</label>
        <asp:GridView ID = "GridView1" runat="server" AutoGenerateColumns="true">
        </asp:GridView>
        <br /> 
        
        <br />
        

    </div>
        
    </form>
            
    </body>
</html>
