<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="U1_W3_D3_Homework_Backend.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        .immagineAuto {
            width: 250px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row my-2">
                <div class="col-6 my-2">
                    <h1>Seleziona la tua Auto</h1>
                    <asp:DropDownList ID="ListaAuto" runat="server" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="ImageSelect">
                        <asp:ListItem Value="" Text=""></asp:ListItem>
                        <asp:ListItem Value="4000,00" Text="Macchina di Paperino"></asp:ListItem>
                        <asp:ListItem Value="500,00" Text="Macchina dei Flintstones"></asp:ListItem>
                        <asp:ListItem Value="100000,00" Text="Batmobile"></asp:ListItem>
                        <asp:ListItem Value="50000,00" Text="DeLorean DMC-12"></asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="col-6 my-2 d-flex flex-column justify-content-center align-items-center">
                    <asp:Image ID="ImmagineAuto" runat="server" CssClass="immagineAuto" />
                    <asp:Label ID="PrezzoImmagine" runat="server" Text=""></asp:Label>
                </div>
            </div>
            <div>
                <div class="row my-2">
                    <div class="col-6 my-2">
                        <h1>Seleziona i tuoi Optional</h1>
                        <asp:CheckBoxList ID="ListaOptional" runat="server">
                            <asp:ListItem Text="Turbo" Value="1000,00" />
                            <asp:ListItem Text="Carica al Plutonio" Value="10000,00" />
                            <asp:ListItem Text="Clacson con verso di Brontosauro" Value="100,00" />
                            <asp:ListItem Text="Antifurto con verso Pterodattilo" Value="250,00" />
                        </asp:CheckBoxList>
                    </div>
                </div>
            </div>
            <div class="row my-2">
                <div class="col-6 my-2">
                    <asp:DropDownList ID="ListaAnniGaranzia" runat="server">
                        <asp:ListItem Text="1 Anno di Garanzia" Value="1" />
                        <asp:ListItem Text="2 Anno di Garanzia" Value="2" />
                        <asp:ListItem Text="3 Anno di Garanzia" Value="3" />
                    </asp:DropDownList>
                </div>
            </div>
            <asp:Button ID="BottonePreventivo" runat="server" Text="Preventivo" OnClick="CalcoloPreventivo" />
            <asp:Label ID="LabelPreventivo" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
