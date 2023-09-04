<%--<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CaschingEx.aspx.cs" Inherits="WebAppSecureSM.Secure.CaschingEx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
</asp:Content>--%>

<%@ Page Title="" Language="C#" MasterPageFile="~/OurSite.Master" AutoEventWireup="true" CodeBehind="Caching.aspx.cs" Inherits="WebAppSecureSM.Secure.Caching" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Cache Example</h2>
  
        <asp:Button ID="btnClickMe" runat="server" Text="Click Here" OnClick="btnClickMe_Click" />
        <asp:Label ID="LblCache" runat="server" Text="Label"></asp:Label>
    </h2>
</asp:Content>