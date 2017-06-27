<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="RepublicDatabaseAutoservice.Search" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<p>
    <asp:Label ID="Label1" runat="server" Text="По области"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="Найти" OnClick="Button1_Click" />
</p>
<p>
    <asp:Label ID="Label2" runat="server" Text="По району "></asp:Label>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <asp:Button ID="Button2" runat="server" Text="Найти" OnClick="Button2_Click" />
    
</p>
<p>
    <asp:Label ID="Label3" runat="server" Text="По городу "></asp:Label>
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    <asp:Button ID="Button3" runat="server" Text="Найти" OnClick="Button3_Click" />
</p>
<p>
    <asp:Label ID="Label4" runat="server" Text="По категории "></asp:Label>
    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    <asp:Button ID="Button4" runat="server" Text="Найти" OnClick="Button4_Click" />
</p>
<p>
    <asp:Label ID="Label5" runat="server" Text="По бренду"></asp:Label>
    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
    <asp:Label ID="Label6" runat="server" Text=" и модели "></asp:Label>
    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
    <asp:Button ID="Button5" runat="server" Text="Найти" OnClick="Button5_Click" />
</p>
<p>
    <asp:Label ID="Label7" runat="server" Text="По бренду "></asp:Label>
    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
    <asp:Button ID="Button6" runat="server" Text="Найти" OnClick="Button6_Click" />
</p>
<p>
    <asp:Label ID="Label8" runat="server" Text="По возрасту авто "></asp:Label>
    <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
    <asp:Button ID="Button7" runat="server" Text="Найти" OnClick="Button7_Click" />
</p>
<p>
    <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
</p>
</asp:Content>
