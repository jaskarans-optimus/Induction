<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AddStudent.aspx.cs" Inherits="Assignment17.AddStudent" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label ID="Status" Text="" runat="server" ForeColor="Red"></asp:Label>
    </div>
    <div>
        <asp:Label ID="IdLabel" runat="server" Text="Id:"></asp:Label>
        <asp:TextBox ID="Id" runat="server"></asp:TextBox>
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
            <asp:Button ID="Add" Text="Add Student" runat="server" OnClick="Add_Click" />
        </div>
    
   </asp:Content>