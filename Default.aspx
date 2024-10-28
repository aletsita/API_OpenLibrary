<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="API_OpenLibrary._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


<asp:TextBox ID="Titulo" runat="server" placeholder="Título del libro" 
    BorderColor="Gray"></asp:TextBox>

<asp:Button ID="BtnBuscar" runat="server" Text="Buscar" OnClick="BtnBuscar_Click" 
    BackColor="LightGray" 
    BorderStyle="Outset" 
    BorderColor="Black" />

    <br />
    <br />
    <asp:Image ID="Portada" runat="server" Width="150px" Height="200px" />
    <br />
    <br />

<asp:Label ID="LblResultado" runat="server" Text="Aqui se mostrara el resultado de la busqueda"></asp:Label>

</asp:Content>
