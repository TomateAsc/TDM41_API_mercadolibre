<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="TDM41_API_mercadolibre.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="index.css" rel="stylesheet" type="text/css" />
    <title>buscquedas con mercado libre</title>
</head>
<body>
    <div class="cuerpo">
        <div class="estilop1">
            <div>
                <img src="https://dvalor-media.s3.us-west-1.amazonaws.com/img/2020/08/08142721/283142_1.jpg" width="600" height="300"/>
            </div>
            <div>
                <h1> Busquedas con mercado libre </h1>
            </div>
            <br />
            <form id="form1" runat="server">
                <div>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
                </div>
            </form>
        </div>
        <div class="estilop1">
            <h2>
                <asp:Panel ID="Panel1" runat="server">
                </asp:Panel>
            </h2>
        </div>
    </div>
</body>
</html>
