<%@ Page Language="C#"  MasterPageFile="~/Site1.Master"  AutoEventWireup="true" CodeBehind="UpdateUser.aspx.cs" Inherits="Assignment17.UpdateUser" %>
<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
         <asp:Label ID="Status" Text="" runat="server" ForeColor="Red"></asp:Label>
    </div>
    <div>
        <asp:Label ID="IdLabel" runat="server" Text="Id:"></asp:Label>
        <asp:TextBox ID="Id" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Button runat="server" ID="GetDetails" Text="Get Details" OnClick="GetDetails_Click" />
    </div>
     <div>
        <asp:Label ID="NameLabel" runat="server" Text="Name:"></asp:Label>
        <asp:TextBox ID="Name" runat="server"></asp:TextBox>
    </div>
        <div>
        <asp:Label ID="StateLabel" runat="server" Text="State:"></asp:Label>
        <asp:TextBox ID="State" runat="server"></asp:TextBox>
    </div>
        <div>
        <asp:Label ID="StreamLabel" runat="server" Text="Stream:"></asp:Label>
        <asp:TextBox ID="Stream" runat="server"></asp:TextBox>
    </div>
        <div>
        <asp:Label ID="AgeLabel" runat="server" Text="Age:"></asp:Label>
        <asp:TextBox ID="Age" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Button ID="Edit" Text="Edit" runat="server" OnClick="Edit_Click" />
    </div>
</asp:Content>