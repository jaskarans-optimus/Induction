<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication4.Login" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Status" runat="server" Text="" ForeColor="Red"></asp:Label>
    <asp:Login ID="Login1" runat="server" OnAuthenticate="Login1_Authenticate"></asp:Login>
    <asp:Button ID="Register" runat="server" Text="Register" OnClick="Register_Click" />
</asp:Content>
