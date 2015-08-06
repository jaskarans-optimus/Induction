<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddStudent.aspx.cs" Inherits="Library_Management_System.AddStudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>
        Student Registraion
    </h1>
    <form id="form1" runat="server">
    <div>
        <div>
                    <=<a href="Login.aspx">Go Back</a>
        </div>
        <div>
            <asp:Label ID="lblStatus" Text="" runat="server"></asp:Label>
        </div>
        <div>
            <asp:Label ID="lblName" runat="server" Text="Name:"></asp:Label>
            <asp:TextBox ID="txtName" runat="server" ></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblUserName" runat="server" Text="UserName:"></asp:Label>
            <asp:TextBox ID="txtUserName" runat="server" ></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblPassword" runat="server" Text="Password:"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" ></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="btnSubmit" Text="Submit" runat="server" OnClick="btnSubmit_Click" />
        </div>
    </div>
    </form>
</body>
</html>
