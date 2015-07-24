<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="UpdateUser.aspx.cs" Inherits="WebApplication4.UpdateUser" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div>
        <asp:Label ID="UserIDLabel" runat="server" Text="Enter UserId:&nbsp&nbsp"></asp:Label>
        <asp:TextBox ID="UserID" runat="server" ></asp:TextBox>
    </div>
    <asp:Button ID="GetDetails" runat="server" Text="Get Details" OnClick="GetDetails_Click" />
      <div>
        <asp:Label ID="Status" runat="server" Text="" ForeColor="Red"></asp:Label>
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
    <asp:Button ID="Update" runat="server" Text="Update" OnClick="Update_Click" />

</asp:Content>
