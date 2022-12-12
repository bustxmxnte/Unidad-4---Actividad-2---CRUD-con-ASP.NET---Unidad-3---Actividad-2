<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="EliminarMateria.aspx.vb" Inherits="CRUD_ASP.NET.EliminarMateria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <p>
        <br />
    </p>


    <p class="text-center" style="font-size: large">
        <strong>ELIMINAR DATOS DE MATERIA</strong></p>

    <table align="center" style="width: 60%; border: 2px solid #0066FF; background-color: #99CCFF">
        <tr>
            <td class="text-right" style="width: 114px; height: 20px;"></td>
            <td style="width: 33px; height: 20px;"></td>
            <td style="width: 561px; height: 20px;"></td>
        </tr>
        <tr>
            <td class="text-right" style="width: 114px">ID Materia</td>
            <td style="width: 33px">&nbsp;</td>
            <td style="width: 561px">
                <asp:TextBox ID="TxtId" runat="server" Width="122px" Enabled="False" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="width: 114px">&nbsp;</td>
            <td style="width: 33px">&nbsp;</td>
            <td style="width: 561px">&nbsp;</td>
        </tr>
<tr>
            <td class="text-right" style="width: 114px">Materia</td>
            <td style="width: 33px">&nbsp;</td>
            <td style="width: 561px">
                <asp:TextBox ID="txtMateria" runat="server" Width="258px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="width: 114px; height: 20px;"></td>
            <td style="width: 33px; height: 20px;"></td>
            <td style="width: 561px; height: 20px;">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="text-right" style="width: 114px; height: 22px;">&nbsp;</td>
            <td style="width: 33px; height: 22px;"></td>
            <td style="width: 561px; height: 22px;">
            </td>
        </tr>
        <tr>
            <td class="text-right" style="width: 114px; height: 22px;">Id carrera</td>
            <td style="width: 33px; height: 22px;">&nbsp;</td>
            <td style="width: 561px; height: 22px;">
                <asp:TextBox ID="txtIdCarrera" runat="server" Width="122px" Enabled="False" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="width: 114px">&nbsp;</td>
            <td style="width: 33px">&nbsp;</td>
            <td style="width: 561px">
                &nbsp;</td>
        </tr>
                <tr>
            <td class="text-right" style="width: 114px">Unidades Valorativas</td>
            <td style="width: 33px">&nbsp;</td>
            <td style="width: 561px">
                <asp:TextBox ID="txtUv" runat="server" Width="258px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="width: 114px; height: 20px;"></td>
            <td style="width: 33px; height: 20px;"></td>
            <td style="width: 561px; height: 20px;">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="text-right" style="width: 114px">&nbsp;</td>
            <td style="width: 33px">&nbsp;</td>
            <td style="width: 561px">&nbsp;</td>
        </tr>
        <tr>
            <td class="text-right" style="width: 114px">&nbsp;</td>
            <td style="width: 33px">&nbsp;</td>
            <td style="width: 561px">
                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" />
                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" />
            </td>
        </tr>
        <tr>
            <td class="text-right" style="width: 114px">&nbsp;</td>
            <td style="width: 33px">&nbsp;</td>
            <td style="width: 561px">&nbsp;</td>
        </tr>
    </table>
    <p>
    </p>
    <p>
    </p>

</asp:Content>
