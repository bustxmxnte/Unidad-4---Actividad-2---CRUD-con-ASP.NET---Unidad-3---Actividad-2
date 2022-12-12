<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Materia.aspx.vb" Inherits="CRUD_ASP.NET.Materia1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
            <p>
        <br />
    </p>


    <p class="text-center" style="font-size: large">
        <strong>LISTADO DE </strong><span style="font-weight: bold">MATERIAS</span></p>

    <asp:Button ID="btnAgregar" runat="server" Text="Agregar" Width="131px" />

    <br />

    <asp:placeholder ID="materias" runat="server" />

    <br />
</asp:Content>
