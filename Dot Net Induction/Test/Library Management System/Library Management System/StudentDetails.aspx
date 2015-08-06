<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentDetails.aspx.cs" Inherits="Library_Management_System.StudentDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   
    <form id="form1" runat="server">
         <div>
    <asp:Menu Id="AdminMenu" runat="server" Orientation="Horizontal">
        <Items>
            <asp:MenuItem Text="Home" NavigateUrl="~/AdminHome.aspx"></asp:MenuItem>
            <asp:MenuItem Text="Students Details" NavigateUrl="~/StudentDetails.aspx"></asp:MenuItem>
            <asp:MenuItem Text="Books" NavigateUrl="~/BookDetails.aspx"></asp:MenuItem>
            <asp:MenuItem Text="Issue History" NavigateUrl=""></asp:MenuItem>
            <asp:MenuItem Text="Issue" NavigateUrl=""></asp:MenuItem>
            <asp:MenuItem Text="Return" NavigateUrl=""></asp:MenuItem>
        </Items>
    </asp:Menu>
    </div>
    <div>
    s<asp:GridView ID="gvStudents" runat="server"></asp:GridView>
    </div>
    </form>
</body>
</html>
