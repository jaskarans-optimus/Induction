<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="WebApplication4.register" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Registration</h1>
    <div>
        <asp:Label ID="Status" runat="server" Text="" ForeColor="Red"></asp:Label>
    </div>
    <div>
    <asp:Label ID="UserIDLabel" runat="server" Text="UserID:&nbsp&nbsp"></asp:Label>
        <asp:TextBox ID="UserID" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="PasswordLabel" runat="server" Text="Password&nbsp&nbsp"></asp:Label>
        <asp:TextBox ID="Pass" runat="server"></asp:TextBox>
    </div>

       <div>
        <asp:Label ID="CountryLabel" runat="server" Text="Country&nbsp&nbsp" ></asp:Label>
        <asp:TextBox ID="Country" runat="server" ></asp:TextBox>
    </div>
        <div>
        <asp:Label ID="GenderLabel" runat="server" Text="Gender&nbsp&nbsp" ></asp:Label>
        <asp:TextBox ID="Gender" runat="server" ></asp:TextBox>
    </div>
    <asp:Button ID="Registerme" runat="server" Text="Register" OnClick="RegisterMe_Click" />
    <div>

    </div>
</asp:Content>
