<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DeleteUser.aspx.cs" Inherits="WebApplication4.DeleteUser" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Status" Text="" runat="server"></asp:Label>
<div>
<asp:Label ID="IdLabel" Text="Enter ID:" runat="server"></asp:Label>
<asp:TextBox ID="UserID" Text="" runat="server"></asp:TextBox>    
</div>
    <asp:Button Text="Delete" ID="Delete" runat="server" OnClick="Delete_Click" />
</asp:Content>