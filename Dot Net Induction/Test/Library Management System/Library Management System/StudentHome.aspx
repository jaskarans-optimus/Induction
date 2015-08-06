<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentHome.aspx.cs" Inherits="Library_Management_System.StudentHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Menu ID="StudentMenu" runat="server" Orientation="Horizontal">
            <Items>
                <asp:MenuItem Text="Home" NavigateUrl="~/StudentHome.aspx"></asp:MenuItem>
                <asp:MenuItem Text="Books" NavigateUrl="~/BookDetails.aspx"></asp:MenuItem>
                <asp:MenuItem Text="Search" NavigateUrl=""></asp:MenuItem>
            </Items>
        </asp:Menu>
    </div>
    </form>
</body>
</html>
