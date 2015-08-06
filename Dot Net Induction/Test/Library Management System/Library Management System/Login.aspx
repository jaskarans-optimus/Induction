<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Library_Management_System.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>
            <asp:Label runat="server" ID="lblStatus" Text=""></asp:Label>
        </div>
         <div>
             <asp:Login ID="Login1" runat="server" OnAuthenticate="Login1_Authenticate" CreateUserUrl="~/AddStudent.aspx"></asp:Login>
         </div>
    </div>
    </form>
    <script></script>
</body>
</html>
