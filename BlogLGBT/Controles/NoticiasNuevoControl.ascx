<%@ Control Language="C#" AutoEventWireup="true" CodeFile="NoticiasNuevoControl.ascx.cs" Inherits="Controles_NoticiasNuevoControl" %>
<p>
<asp:Label ID="Label1" runat="server" Text="Titulo"></asp:Label>
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
</p>
<p>
<asp:Label ID="Label2" runat="server" Text="Cuerpo"></asp:Label>
<asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine"></asp:TextBox>
</p>
<p>
  <asp:Label ID="Label3" runat="server" Text="Categoria"></asp:Label>
  <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
</p>